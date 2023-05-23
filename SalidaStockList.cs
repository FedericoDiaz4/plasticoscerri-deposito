using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class SalidaStockList : Form
    {
        private SalidaStockCarga SalidaStockCarga;
        public SalidaStockList()
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
            Cargar();
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
                    Flex.DataSource = (from v in db.salidastock
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

            SalidaStockCarga.Id = 0;
            SalidaStockCarga.Nuevo = true;

            CreoObjetoCarga();
            SalidaStockCarga.ShowDialog();
            SalidaStockCarga.Dispose();

            Cargar();
            Show();
        }

        private void CreoObjetoCarga()
        {
            SalidaStockCarga salidaStockCarga = new SalidaStockCarga();
            SalidaStockCarga = salidaStockCarga;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            if (Flex.RowCount == 0 || Flex.CurrentRow == null)
            {
                return;
            }

            Hide();
            SalidaStockCarga.Nuevo = false;
            SalidaStockCarga.Id = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int IdVenta = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                var Venta = db.salidastock.FirstOrDefault(v => v.id == IdVenta);
                CreoObjetoCarga();
                SalidaStockCarga.DtpFecha.Value = Venta.fecha;
                SalidaStockCarga.TxtNumComprobante.Text = Venta.numero.ToString("D8");
                SalidaStockCarga.IdDeposito = Venta.iddeposito;
                SalidaStockCarga.Modificando = true;
                SalidaStockCarga.ShowDialog();
                SalidaStockCarga.Dispose();

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
