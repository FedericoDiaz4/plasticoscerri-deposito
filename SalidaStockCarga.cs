﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PlasticosCerriDeposito.Clases;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class SalidaStockCarga : Form
    {
        private static int id;
        private static bool nuevo;
        private static bool modificando;
        private static int idDeposito;

        public static int Id { get => id; set => id = value; }
        public static bool Nuevo { get => nuevo; set => nuevo = value; }
        public static bool Modificando { get => modificando; set => modificando = value; }
        public static int IdDeposito { get => idDeposito; set => idDeposito = value; }

        public SalidaStockCarga()
        {
            InitializeComponent();
            DtpFecha.Value = DateTime.Now;
            CargarCombos();
        }

        private void SalidaStockCarga_Load(object sender, EventArgs e)
        {
            if (nuevo)
            {
                CargarNumero();
                BorroHuerfanos();
                TxtNumComprobante.Enabled = false;
                CboDeposito.SelectedIndex = -1;
                
            } else
            {
                CboDeposito.Enabled = false;
                DtpFecha.Enabled = false;
                TxtNumComprobante.Enabled = false;
                CboTipo.Enabled = false;
                CboDeposito.SelectedItem = idDeposito;
            }
            Cargar();
            CboTipo.SelectedIndex = 0;
            TxtCodArt.Text = "";
        }

        private void CargarNumero()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int numero = 0;
                if (db.salidastock.Any())
                {
                    numero = db.salidastock.OrderByDescending(ins => ins.numero).FirstOrDefault().numero;
                }
                TxtNumComprobante.Text = (numero + 1).ToString().PadLeft(8, char.Parse("0"));
                TxtNumComprobante.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
        }

        private static void BorroHuerfanos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                db.salidastockd.RemoveRange(db.salidastockd.Where(vd => vd.idsalida == 0));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
        }

        private void CargarCombos()
        {
            CargarComboArticulos();
            CargarComboDepositos();
        }

        private void CargarComboArticulos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                CboArticulo.DisplayMember = "descripcion";
                CboArticulo.ValueMember = "id";
                CboArticulo.DataSource = db.articulos.Where(c => c.eliminado == 0).OrderBy(r => r.id).ToList();
                CboArticulo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }

            CboArticulo.AutoCompleteCustomSource = LoadAutoCompleteArticulos();
            CboArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private AutoCompleteStringCollection LoadAutoCompleteArticulos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                List<articulos> listaArticulos = db.articulos.Where(c => c.eliminado == 0).OrderBy(r => r.descripcion).ToList();
                foreach (articulos articulo in listaArticulos)
                {
                    stringCol.Add(articulo.descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return stringCol;
        }

        private void CargarComboDepositos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                CboDeposito.DisplayMember = "nombre";
                CboDeposito.ValueMember = "id";
                CboDeposito.DataSource = db.depositos.Where(c => c.eliminado == 0).OrderBy(r => r.id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
        }

        private void CargarComboPosiciones()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int idDeposito = (int)CboDeposito.SelectedValue;
                int idArticulo = (int)CboArticulo.SelectedValue;
                List<posiciones> lstPosiciones = db.posiciones.Where(c => c.eliminado == 0 && c.iddeposito == idDeposito).OrderBy(r => r.id).ToList();
                List<posiciones> posicionesEnUso = new List<posiciones>();
                foreach (posiciones posiciones in lstPosiciones)
                {
                    if (db.stock.Where(s=> s.idposicion == posiciones.id && s.idarticulo == idArticulo && s.iddeposito == idDeposito).Any())
                    {
                        if (db.stock.FirstOrDefault(s => s.idposicion == posiciones.id && s.idarticulo == idArticulo && s.iddeposito == idDeposito).cantstock > 0)
                        {
                            posicionesEnUso.Add(posiciones);
                        }
                    }
                }
                CboPosicion.DisplayMember = "nombre";
                CboPosicion.ValueMember = "id";
                CboPosicion.DataSource = posicionesEnUso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
            CboPosicion.SelectedIndex = -1;
            LimpiarLabels();
        }

        private void Cargar()
        {
            if (nuevo)
            {
                CmdGuardar.Enabled = true;
                CmdImprimir.Enabled = false;
                cmdDel.Enabled = true;
                CmdAdd.Enabled = true;
            }
            else
            {
                CmdGuardar.Enabled = false;
                CmdImprimir.Enabled = true;
                cmdDel.Enabled = false;
                CmdAdd.Enabled = false;
            }

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                Flex.DataSource = (from i in db.salidastockd
                                   join p in db.posiciones on i.idposicion equals p.id
                                   where i.idsalida == id
                                   orderby i.id
                                   select new
                                   {
                                       i.id,
                                       i.idart,
                                       i.idposicion,
                                       i.codart,
                                       i.art,
                                       i.cantidad,
                                       p.nombre,
                                   }).ToList();
                OrdenaFlex();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                db.Dispose();
            }

        }

        private void OrdenaFlex()
        {
            Flex.Columns[0].HeaderText = "id";
            Flex.Columns[0].Visible = false;
            Flex.Columns[1].HeaderText = "idart";
            Flex.Columns[1].Visible = false;
            Flex.Columns[2].HeaderText = "idposicion";
            Flex.Columns[2].Visible = false;
            Flex.Columns[3].HeaderText = "Código";
            Flex.Columns[3].Width = 125;
            Flex.Columns[4].HeaderText = "Artículo";
            Flex.Columns[4].Width = 400;
            Flex.Columns[5].HeaderText = "Cant";
            Flex.Columns[5].Width = 50;
            Flex.Columns[6].HeaderText = "Pos";
            Flex.Columns[6].Width = 75;
        }

        private void Add()
        {

            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Focus();
                return;
            }
            if (CboArticulo.Text == "")
            {
                CboArticulo.Focus();
                return;
            }

            if (CboPosicion.Text == "")
            {
                CboPosicion.Focus();
                return;
            }

            double cantidad = double.Parse(TxtCantidad.Text);
            double cantidadTotalPosicion = ObtengoStockDisponibleEnPosicion((int)CboDeposito.SelectedValue, (int)CboPosicion.SelectedValue);
            if (cantidad > cantidadTotalPosicion)
            {
                MessageBox.Show("Stock a retirar mayor a disponibilidad de posicion.");
                return;
            }

            PlasticosDBContext context = new PlasticosDBContext();
            try
            {
                int idArt = (int)CboArticulo.SelectedValue;
                int idPosicion = (int)CboPosicion.SelectedValue;
                var detalle = new salidastockd
                {
                    idsalida = id,
                    idart = idArt,
                    codart = TxtCodArt.Text,
                    art = CboArticulo.Text,
                    cantidad = int.Parse(TxtCantidad.Text),
                    idposicion = idPosicion
                };
                context.salidastockd.Add(detalle);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                context.Dispose();
            }

            Cargar();

            TxtCodArt.Text = "";
            CboArticulo.SelectedIndex = -1;
            CboPosicion.SelectedIndex = -1;
            TxtCantidad.Text = "";
            LimpiarLabels();
            TxtCodArt.Focus();
        }

        private double ObtengoStockDisponibleEnPosicion(int idDeposito, int idPosicion)
        {
            double stockActual = 0;
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                if (db.stock.Where(s=>s.iddeposito == idDeposito && s.idposicion == idPosicion).Any())
                {
                    stockActual = db.stock.FirstOrDefault(s => s.iddeposito == idDeposito && s.idposicion == idPosicion).cantstock;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return stockActual;
        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            id = 0;
            modificando = false;
            nuevo = true;
            Close();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if(Flex.RowCount == 0)
            {
                return;
            }

            if(CboDeposito.SelectedIndex == -1)
            {
                return;
            }

            if(TxtNumComprobante.Text == "")
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿DESEA GUARDAR EL COMPROBANTE?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int idDeposito = (int)CboDeposito.SelectedValue;
            try
            {
                var salidaStock = new salidastock
                {
                    fecha = DtpFecha.Value,
                    numero = int.Parse(TxtNumComprobante.Text),
                    iddeposito = idDeposito,
                    eliminado = 0
                };
                PlasticosDBContext db = new PlasticosDBContext();
                if (nuevo)
                {
                    db.salidastock.Add(salidaStock);
                }

                db.SaveChanges();
                id = salidaStock.id;
                db.Dispose();
                nuevo = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            try
            {
                PlasticosDBContext db = new PlasticosDBContext();
                List<salidastockd> salidaStockD = db.salidastockd.Where(vd => vd.idsalida == 0).ToList();
                foreach (salidastockd sald in salidaStockD)
                {
                    sald.idsalida = id;
                }
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            ActualizoStock(id);
            Cargar();
        }

        private void ActualizoStock(int idIngreso)
        {
            try
            {
                PlasticosDBContext db = new PlasticosDBContext();
                List<salidastockd> listaArts = db.salidastockd.Where(vd => vd.idsalida == idIngreso).ToList();
                
                int idDeposito = (int)CboDeposito.SelectedValue;
                foreach (salidastockd art in listaArts)
                {
                    Modulo.ModificoItemStock(art.idart, int.Parse(art.cantidad.ToString()), "-", art.idposicion, idDeposito);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void TxtCodArt_TextChanged(object sender, System.EventArgs e)
        {
            if (TxtCodArt.Text == "")
            {
                CboArticulo.SelectedIndex = -1;
                return;
            }

            try
            {
                PlasticosDBContext db = new PlasticosDBContext();
                string codArt = TxtCodArt.Text;
                if (db.articulos.Where(c => c.eliminado == 0 && c.codigo == codArt).Any())
                {
                    CboArticulo.Text = db.articulos.FirstOrDefault(c => c.eliminado == 0 && c.codigo == codArt).descripcion;
                }
                else
                {
                    CboArticulo.SelectedIndex = -1;
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            TxtCodArt.SelectionStart = TxtCodArt.Text.Length;
        }

        private void CboArticulo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (CboArticulo.SelectedIndex != -1)
            {
                try
                {
                    PlasticosDBContext context = new PlasticosDBContext();
                    TxtCodArt.Text = context.articulos.FirstOrDefault(c => c.id == (int)CboArticulo.SelectedValue).codigo.ToString();
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            if (CboDeposito.SelectedIndex != -1 && CboArticulo.SelectedIndex != -1)
            {
                CargarComboPosiciones();
            }
            CboPosicion.SelectedIndex = -1;
        }

        private void CboPosiciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPosicion.SelectedIndex != -1)
            {
                PlasticosDBContext db = new PlasticosDBContext();
                try
                {
                    int idDeposito = (int)CboDeposito.SelectedValue;
                    int idPosicion = (int)CboPosicion.SelectedValue;
                    int idArt = (int)CboArticulo.SelectedValue;
                    int stockActual = 0;
                    if(db.stock.Where(s => s.iddeposito == idDeposito && s.idposicion == idPosicion).Any())
                    {
                        stockActual = db.stock.FirstOrDefault(s => s.iddeposito == idDeposito && s.idposicion == idPosicion).cantstock;
                    }
                    if(db.salidastockd.Where(s=>s.idsalida == 0 && s.idposicion == idPosicion && s.idart == idArt).Any())
                    {
                        List<salidastockd> stockEnUso = db.salidastockd.Where(s => s.idsalida == 0 && s.idposicion == idPosicion && s.idart == idArt).ToList();
                        foreach (salidastockd st in stockEnUso)
                        {
                            stockActual -= st.cantidad;
                        }
                    }
                    double capacidadTotal = db.posiciones.FirstOrDefault(p => p.id == idPosicion).capacidad;
                    double capacidadDisponible = ObtengoStockDisponibleEnPosicion(idDeposito, idPosicion);
                    //capacidadDisponible -= stockActual;
                    LblStockActual.Text = "Stock Actual: " + stockActual;
                    LblCapacidadTotal.Text = "Capacidad Total: " + capacidadTotal;
                    LblCapacidadDisponible.Text = "Capacidad Disponible: " + capacidadDisponible;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    db.Dispose();
                } 
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (Flex.CurrentRow.Cells[0] == null || Flex.CurrentRow.Cells[0].Value.ToString() == "null")
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("DESEA ELIMINAR EL Articulo " + Flex.CurrentRow.Cells[4].Value + "?", "Eliminando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int idMovD = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                db.salidastockd.Remove(db.salidastockd.Find(idMovD));
                db.SaveChanges();
                Vaciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.Dispose();
            }
            Cargar();
        }
        private void Vaciar()
        {
            TxtCodArt.Text = "";
            CboArticulo.Text = "";
            TxtCantidad.Text = "";
            CboPosicion.DataSource = null;
        }

        private void LimpiarLabels()
        {
            LblStockActual.Text = "Stock Actual: ";
            LblCapacidadTotal.Text = "Capacidad Total: ";
            LblCapacidadDisponible.Text = "Capacidad Disponible: ";
        }

        private void CmdImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
            Close();
        }

        private void Imprimir()
        {
            Comprobantes formComprobantes = new Comprobantes();

            PlasticosDBContext db = new PlasticosDBContext();
            salidastock salidaStock = db.salidastock.FirstOrDefault(a => a.id == id);

            formComprobantes.reportViewer1.LocalReport.ReportEmbeddedResource = "PlasticosCerriDeposito.Reportes.IngresoStock.rdlc";
            formComprobantes.reportViewer1.LocalReport.DataSources.Clear();
            formComprobantes.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DetalleAjustes", GeneroListaDetalle(id)));
            formComprobantes.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosAjuste", GeneroListaDatos(id)));

            var deviceInfo = @"<DeviceInfo>
                                    <EmbedFonts>None</EmbedFonts>
                                </DeviceInfo>";

            //var ruta = @"\\YORLIS-PC\MovStock\0001-" + ingresoStock.numero.ToString("D8") + "-" + ingresoStock.fecha.ToString("dd.MM.yyyy") + ".pdf";
            string ruta = @"C:\sistema\0001-" + salidaStock.numero.ToString("D8") + "-" + salidaStock.fecha.ToString("dd.MM.yyyy") + ".pdf";
            db.Dispose();
            byte[] bytes = formComprobantes.reportViewer1.LocalReport.Render("PDF", deviceInfo);
            Modulo.CreoPDF(ruta, bytes, true);
        }

        private static List<DetalleAjusteStock> GeneroListaDetalle(int idSalida)
        {
            List<DetalleAjusteStock> listaDetalle = new List<DetalleAjusteStock>();
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                var detalle = db.salidastockd.Where(ms => ms.idsalida == idSalida);
                foreach (salidastockd ms in detalle)
                {
                    PlasticosDBContext db1 = new PlasticosDBContext();
                    string codigo = db1.articulos.FirstOrDefault(a => a.id == ms.idart).codigo;
                    string posicion = db1.posiciones.FirstOrDefault(p => p.id == ms.idposicion).nombre;
                    db1.Dispose();
                    DetalleAjusteStock detalleA = new DetalleAjusteStock
                    {
                        Codigo = codigo,
                        Descripcion = ms.art,
                        Cantidad = int.Parse(ms.cantidad.ToString()),
                        Posicion = posicion
                    };
                    listaDetalle.Add(detalleA);
                }
                return listaDetalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private static List<DatosAjusteStock> GeneroListaDatos(int idSalida)
        {
            PlasticosDBContext db = new PlasticosDBContext();
            salidastock salida = db.salidastock.FirstOrDefault(v => v.id == idSalida);
            string deposito = db.depositos.FirstOrDefault(d => d.id == salida.iddeposito).codigo + " - " + db.depositos.FirstOrDefault(d => d.id == salida.iddeposito).nombre;
            DatosAjusteStock datos = new DatosAjusteStock
            {
                TipoAjuste = "Baja de Stock",
                NumeroAjuste = "N° 0001" + "-" + salida.numero.ToString("D8"),
                FechaAjuste = "Fecha: " + salida.fecha.Day.ToString("D2") + "/" + salida.fecha.Month.ToString("D2") + "/" + salida.fecha.Year.ToString("D4"),
                Deposito = deposito
            };
            List<DatosAjusteStock> datosFacturas = new List<DatosAjusteStock>
            {
                datos
            };
            db.Dispose();
            return datosFacturas;
        }
    }
}
