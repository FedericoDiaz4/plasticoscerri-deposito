using PlasticosCerriDeposito.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PlasticosCerriDeposito
{
    public partial class PosicionesList : Form
    {
        private PosicionesCarga PosicionesCarga;
        public PosicionesList()
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
            Flex.Columns[3].HeaderText = "Capacidad";
            Flex.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void Cargar()
        {
            int codigo = 0;
            if (CboBuscar.Text == "CODIGO" && TxtBuscar.Text != "")
            {
                codigo = int.Parse(TxtBuscar.Text);
            }
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                Flex.DataSource = (from pos in db.posiciones
                                   where pos.eliminado == 0 &&
                                   ((CboBuscar.Text == "CODIGO" && (TxtBuscar.Text == "" || pos.codigo == codigo)) ||
                                   (CboBuscar.Text == "DESCRIPCION" && (TxtBuscar.Text == "" || pos.nombre.ToString().Contains(TxtBuscar.Text))))
                                   select new
                                   {
                                       pos.id,
                                       pos.codigo,
                                       pos.nombre,
                                       pos.capacidad
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

            DialogResult dialogResult = MessageBox.Show("DESEA ELIMINAR LA POSICION " + Flex.CurrentRow.Cells[2].Value + "?", "Eliminando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int idPosicion = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                posiciones pos = db.posiciones.FirstOrDefault(c => c.id == idPosicion && c.eliminado == 0);
                if (pos != null)
                {
                    pos.eliminado = 1;
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

            PosicionesCarga.Id = 0;
            PosicionesCarga.Nuevo = true;
            CreoObjetoCarga();


            PosicionesCarga.ShowDialog();
            PosicionesCarga.Dispose();

            Cargar();
            Show();
        }

        private void CreoObjetoCarga()
        {
            PosicionesCarga posicionesCarga = new PosicionesCarga();
            PosicionesCarga = posicionesCarga;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            if (Flex.CurrentRow.Cells[0] == null)
            {
                return;
            }

            Hide();
            PosicionesCarga.Nuevo = false;
            PosicionesCarga.Id = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            posiciones posicion = null;
            try
            {
                int idPosicion = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                posicion = db.posiciones.FirstOrDefault(p => p.id == idPosicion && p.eliminado == 0);
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

            PosicionesCarga.TxtCodigo.Text = posicion.codigo.ToString("D4");
            PosicionesCarga.TxtDescripcion.Text = posicion.nombre;
            PosicionesCarga.TxtCapacidad.Text = posicion.capacidad.ToString("N2");
            PosicionesCarga.IdDeposito = posicion.iddeposito;

            PosicionesCarga.ShowDialog();
            PosicionesCarga.Dispose();

            Cargar();
            Show();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CboBuscar.Text == "CODIGO")
            {
                e.Handled = Modulo.SoloEnteros(Convert.ToInt16(e.KeyChar));
            }
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
    }
}
