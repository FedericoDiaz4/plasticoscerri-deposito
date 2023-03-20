using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class IngresoStockList : Form
    {
        private IngresoStockCarga IngresoStockCarga;
        public IngresoStockList()
        {
            InitializeComponent();
            if (DateTime.Today.Month == 1)
            {
                DtpDesde.Value = new DateTime(DateTime.Today.Year - 1, 12, 1);
            }
            else
            {
                DtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
            }
            DtpHasta.Value = DateTime.Now;
            CboTipoComprobante.SelectedIndex = 0;
            CmdBuscar.PerformClick();
        }

        private void OrdenaFlex()
        {
            Flex.Columns[0].HeaderText = "Id";
            Flex.Columns[0].Visible = false;
            Flex.Columns[1].HeaderText = "Fecha";
            Flex.Columns[1].Width = 90;
            Flex.Columns[2].HeaderText = "Numero";
            Flex.Columns[2].Width = 90;
            Flex.Columns[2].DefaultCellStyle.Format = "D8";
            Flex.Columns[3].HeaderText = "Deposito";
            Flex.Columns[3].Width = 250;
        }

        public void Cargar()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                {
                    int numero = 0;
                    if (TxtNumero.Text == "")
                    {
                        numero = 0;
                    }
                    else
                    {
                        numero = int.Parse(TxtNumero.Text);
                    }
                    Flex.DataSource = (from v in db.ingresostock
                                       join d in db.depositos on v.iddeposito equals d.id
                                       where (v.fecha >= DtpDesde.Value && v.fecha <= DtpHasta.Value) &&
                                              (v.numero == numero || numero == 0)
                                       orderby v.fecha
                                       orderby v.numero
                                       select new
                                       {
                                           v.id,
                                           v.fecha,
                                           v.numero,
                                           d.nombre
                                       }).ToList();
                }
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

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            Hide();

            IngresoStockCarga.Id = 0;
            IngresoStockCarga.Nuevo = true;

            CreoObjetoCarga();
            IngresoStockCarga.ShowDialog();
            IngresoStockCarga.Dispose();

            Cargar();
            Show();
        }

        private void CreoObjetoCarga()
        {
            IngresoStockCarga ingresoStockCarga = new IngresoStockCarga();
            IngresoStockCarga = ingresoStockCarga;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            if (Flex.RowCount == 0 || Flex.CurrentRow == null)
            {
                return;
            }

            Hide();
            IngresoStockCarga.Nuevo = false;
            IngresoStockCarga.Id = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int IdVenta = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                var Venta = db.ingresostock.FirstOrDefault(v => v.id == IdVenta);
                CreoObjetoCarga();
                IngresoStockCarga.DtpFecha.Value = Venta.fecha;
                IngresoStockCarga.TxtNumComprobante.Text = Venta.numero.ToString("D8");
                IngresoStockCarga.CboDeposito.Text = db.depositos.Find(Venta.iddeposito).nombre;
                IngresoStockCarga.Modificando = true;
                IngresoStockCarga.ShowDialog();
                IngresoStockCarga.Dispose();

                Cargar();
                Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Modulo.SoloEnteros(Convert.ToInt16(e.KeyChar));
        }

        private void Flex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CmdModificar.PerformClick();
            }
        }

        private void Flex_DoubleClick(object sender, System.EventArgs e)
        {
            CmdModificar.PerformClick();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            if (CboTipoComprobante.Text == "")
            {
                MessageBox.Show("Falta tipo de comprobante.");
                return;
            }

            Cargar();
        }
    }
}
