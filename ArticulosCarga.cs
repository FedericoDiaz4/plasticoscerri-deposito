using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class ArticulosCarga : Form
    {
        private static int id;
        private static bool nuevo;
        private static int idTipo;

        public static int Id { get => id; set => id = value; }
        public static bool Nuevo { get => nuevo; set => nuevo = value; }

        public static int IdTipo { get => idTipo; set => idTipo = value; }
        public ArticulosCarga()
        {
            InitializeComponent();
            CargarComboTipos();
            if (!nuevo)
            {
                TxtCodigoSKU.Enabled = false;
            }
        }

        private void ArticulosCarga_Load(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                PlasticosDBContext db = new PlasticosDBContext();
                CboTipoProducto.Text = db.tipoproductos.FirstOrDefault(tp => tp.id == idTipo).nombre;
                db.Dispose();
            }
        }

        private void CargarComboTipos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                CboTipoProducto.DisplayMember = "nombre";
                CboTipoProducto.ValueMember = "id";
                CboTipoProducto.DataSource = db.tipoproductos.Where(c => c.eliminado == 0).OrderBy(r => r.id).ToList();
                CboTipoProducto.SelectedIndex = -1;
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

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoSKU.Text == "")
            {
                MessageBox.Show("Falta ingresar Código SKU", "Falta código", MessageBoxButtons.OK);
                TxtCodigoSKU.Focus();
                return;
            }

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Falta ingresar Descripción", "Falta Descripción", MessageBoxButtons.OK);
                TxtDescripcion.Focus();
                return;
            }

            if (CboTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Falta ingresar tipo de producto", "Falta tipo", MessageBoxButtons.OK);
                CboTipoProducto.Focus();
                return;
            }

            if(TxtStockMinimo.Text == "")
            {
                TxtStockMinimo.Text = "0";
            }

            if (nuevo)
            {
                PlasticosDBContext db1 = new PlasticosDBContext();
                string codigo = TxtCodigoSKU.Text.Trim();
                if (db1.articulos.Where(c => c.codigo == codigo && c.eliminado == 0).Any())
                {
                    MessageBox.Show("Código SKU de artículo en uso. Seleccione otro.", "Código Duplicado", MessageBoxButtons.OK);
                    TxtCodigoSKU.Focus();
                    return;
                }
                db1.Dispose();
            }

            sbyte idTipo = sbyte.Parse(CboTipoProducto.SelectedValue.ToString());
            double stockMinimo = double.Parse(TxtStockMinimo.Text);

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                articulos articulo = new articulos
                {
                    codigo = TxtCodigoSKU.Text.ToUpper().Trim(),
                    idtipo = idTipo,
                    descripcion = TxtDescripcion.Text.ToUpper().Trim(),
                    codigocerri = TxtCodigoCerri.Text.ToUpper().Trim(),
                    stockminimo = stockMinimo,
                    eliminado = 0
                };
                if (nuevo)
                {
                    db.articulos.Add(articulo);
                }
                else
                {
                    articulo.id = id;
                    db.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                nuevo = false;
                id = articulo.id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                db.Dispose();
            }

            Close();
        }

        private void TxtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("."))
            {
                e.KeyChar = char.Parse(",");
            }
            e.Handled = Modulo.CambioPunto(TxtStockMinimo, (int)e.KeyChar);
        }

    }
}
