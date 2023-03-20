using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class ArticulosList : Form
    {
        private ArticulosCarga ArticulosCarga;

        public ArticulosList()
        {
            InitializeComponent();
            CboBuscar.SelectedIndex = 0;
            Cargar();
        }

        private void OrdenaFlex()
        {
            Flex.Columns[0].HeaderText = "Id";
            Flex.Columns[0].Visible = false;
            Flex.Columns[1].HeaderText = "Código SKU";
            Flex.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[2].HeaderText = "Descripción";
            Flex.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[3].HeaderText = "Stock Minimo";
            Flex.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[3].DefaultCellStyle.Format = "N2";
            Flex.Columns[4].HeaderText = "Codigo Cerri";
            Flex.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void OrdenaFlexExpo()
        {
            Flex.Columns[0].HeaderText = "Código SKU";
            Flex.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[1].HeaderText = "Descripción";
            Flex.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[2].HeaderText = "Tipo Producto";
            Flex.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[3].HeaderText = "Stock Minimo";
            Flex.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[4].HeaderText = "Codigo Cerri";
            Flex.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Flex.Columns[4].DefaultCellStyle.Format = "N2";
            Flex.Columns[5].HeaderText = "Eliminado";
            Flex.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void CargarExpo()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                Flex.DataSource = (from arts in db.articulos
                                   join tipos in db.tipoproductos on arts.idtipo equals tipos.id
                                   where arts.eliminado == 0
                                   select new
                                   {
                                       arts.codigo,
                                       arts.descripcion,
                                       tipos.nombre,
                                       arts.stockminimo,
                                       arts.codigocerri,
                                       arts.eliminado,
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
            OrdenaFlexExpo();
        }

        public void Cargar()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                Flex.DataSource = (from arts in db.articulos
                                   where arts.eliminado == 0 &&
                                   ((CboBuscar.Text == "CODIGO SKU" && (TxtBuscar.Text == "" || arts.codigo.Contains(TxtBuscar.Text))) ||
                                   (CboBuscar.Text == "DESCRIPCION" && (TxtBuscar.Text == "" || arts.descripcion.ToString().Contains(TxtBuscar.Text))))
                                   select new
                                   {
                                       arts.id,
                                       arts.codigo,
                                       arts.descripcion,
                                       arts.stockminimo,
                                       arts.codigocerri
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

            DialogResult dialogResult = MessageBox.Show("DESEA ELIMINAR EL ARTICULO " + Flex.CurrentRow.Cells[2].Value + "?", "Eliminando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                int idArticulo = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                articulos art = db.articulos.FirstOrDefault(c => c.id == idArticulo && c.eliminado == 0);
                if (art != null)
                {
                    art.eliminado = 1;
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

            ArticulosCarga.Id = 0;
            ArticulosCarga.Nuevo = true;
            CreoObjetoCarga();
            

            ArticulosCarga.ShowDialog();
            ArticulosCarga.Dispose();

            Cargar();
            Show();
        }

        private void CreoObjetoCarga()
        {
            ArticulosCarga Articuloscarga = new ArticulosCarga();
            ArticulosCarga = Articuloscarga;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            if (Flex.CurrentRow.Cells[0] == null)
            {
                return;
            }

            Hide();
            ArticulosCarga.Nuevo = false;
            ArticulosCarga.Id = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
            PlasticosDBContext db = new PlasticosDBContext();
            articulos articulos = null;
            try
            {
                int idArticulo = int.Parse(Flex.CurrentRow.Cells[0].Value.ToString());
                articulos = db.articulos.FirstOrDefault(p => p.id == idArticulo && p.eliminado == 0);
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

            ArticulosCarga.TxtCodigoSKU.Text = articulos.codigo.ToString();
            ArticulosCarga.TxtDescripcion.Text = articulos.descripcion;
            ArticulosCarga.TxtCodigoCerri.Text = articulos.codigocerri;
            ArticulosCarga.TxtStockMinimo.Text = articulos.stockminimo.ToString();
            ArticulosCarga.IdTipo = articulos.idtipo;

            ArticulosCarga.ShowDialog();
            ArticulosCarga.Dispose();

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

        private void CmdExcel_Click(object sender, EventArgs e)
        {
            CargarExpo();

            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

            hoja_trabajo.Cells[1, 1] = "CODIGO";
            hoja_trabajo.Cells[1, 2] = "DESCRIPCION";
            hoja_trabajo.Cells[1, 3] = "TIPO PRODUCTO";
            hoja_trabajo.Cells[1, 4] = "P. COMPRA";
            hoja_trabajo.Cells[1, 5] = "P. VENTA MAYPRISTA";
            hoja_trabajo.Cells[1, 6] = "P. VENTA DIRECTA";
            hoja_trabajo.Cells[1, 7] = "ELIMINADO";

            pBar.Visible = true;
            pBar.Maximum = Flex.Rows.Count;
            pBar.Value = 1;
            pBar.Step = 1;
            int final = 0;
            for (int i = 0; i < Flex.Rows.Count; i++)
            {
                for (int j = 0; j < Flex.Columns.Count; j++)
                {
                    if (j >= 3 && j <= 5)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1].NumberFormat = "$#.##0,00";
                        hoja_trabajo.Cells[i + 2, j + 1] = Flex.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = Flex.Rows[i].Cells[j].Value.ToString();
                    }
                }
                final = i;
                pBar.PerformStep();
            }
            pBar.Value = 0;
            pBar.Maximum = 0;
            pBar.Visible = false;
            aplicacion.Visible = true;
            Cargar();
        }
    }
}
