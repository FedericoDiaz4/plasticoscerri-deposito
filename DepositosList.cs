using PlasticosCerriDeposito.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PlasticosCerriDeposito
{
    public partial class DepositosList : Form
    {
        private DepositosCarga DepositosCarga;
        public DepositosList()
        {
            InitializeComponent();
            CboBuscar.SelectedIndex = 0;
            Cargar();
        }

        private void OrdenaFlex()
        {
            Flex.Columns[0].HeaderText = "Id";
            Flex.Columns[0].Visible = false;
            Flex.Columns[1].HeaderText = "Código";
            Flex.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[2].HeaderText = "Nombre";
            Flex.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void Cargar()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int codigo = 0;
                if(CboBuscar.Text == "CODIGO" && TxtBuscar.Text != "")
                {
                    codigo = int.Parse(TxtBuscar.Text);
                }
                Flex.DataSource = (from depo in db.depositos
                                   where depo.eliminado == 0 &&
                                   ((CboBuscar.Text == "CODIGO" && (TxtBuscar.Text == "" || depo.codigo == codigo)) ||
                                   (CboBuscar.Text == "DESCRIPCION" && (TxtBuscar.Text == "" || depo.nombre.ToString().Contains(TxtBuscar.Text))))
                                   select new
                                   {
                                       depo.id,
                                       depo.codigo,
                                       depo.nombre
                                   }).ToList();
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
            OrdenaFlex();
        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (Flex.CurrentRow.Cells[0] == null)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("DESEA ELIMINAR EL DEPOSITO " + Flex.CurrentRow.Cells[1].Value + "?", "Eliminando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int idDeposito = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                depositos depo = db.depositos.FirstOrDefault(c => c.id == idDeposito && c.eliminado == 0);
                if (depo != null)
                {
                    depo.eliminado = 1;
                    db.SaveChanges();
                }
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
            Cargar();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            Hide();

            DepositosCarga.Id = 0;
            DepositosCarga.Nuevo = true;
            CreoObjetoCarga();


            DepositosCarga.ShowDialog();
            DepositosCarga.Dispose();

            Cargar();
            Show();
        }

        private void CreoObjetoCarga()
        {
            DepositosCarga depositosCarga = new DepositosCarga();
            DepositosCarga = depositosCarga;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            if (Flex.CurrentRow.Cells[0] == null)
            {
                return;
            }

            Hide();
            DepositosCarga.Nuevo = false;
            DepositosCarga.Id = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            depositos deposito = null;
            try
            {
                int idDeposito = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                deposito = db.depositos.FirstOrDefault(p => p.id == idDeposito && p.eliminado == 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            CreoObjetoCarga();

            DepositosCarga.TxtCodigo.Text = deposito.codigo.ToString("D4");
            DepositosCarga.TxtDescripcion.Text = deposito.nombre;

            DepositosCarga.ShowDialog();
            DepositosCarga.Dispose();

            Cargar();
            Show();
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Flex.Focus();
            }
        }

        private void Flex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CmdModificar.PerformClick();
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Flex_DoubleClick(object sender, EventArgs e)
        {
            CmdModificar.PerformClick();
        }
        private void CboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtBuscar.Text = "";
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CboBuscar.Text == "CODIGO")
            {
                e.Handled = Modulo.SoloEnteros(Convert.ToInt16(e.KeyChar));
            }
        }
    }
}
