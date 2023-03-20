using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class PosicionesCarga : Form
    {
        private static int id;
        private static bool nuevo;
        private static int idDeposito;

        public static int Id { get => id; set => id = value; }
        public static bool Nuevo { get => nuevo; set => nuevo = value; }
        public static int IdDeposito { get => idDeposito; set => idDeposito = value; }
        public PosicionesCarga()
        {
            InitializeComponent();
            if (!nuevo)
            {
                TxtCodigo.Enabled = false;
            }
            CargarDepositos();
        }

        private void CargarDepositos()
        {
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                CboDeposito.DisplayMember = "nombre";
                CboDeposito.ValueMember = "id";
                CboDeposito.DataSource = db.depositos.Where(c => c.eliminado == 0).OrderBy(r => r.id).ToList();
                CboDeposito.SelectedIndex = -1;
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

        private void PosicionesCarga_Load(object sender, EventArgs e)
        {
            if (nuevo)
            {
                PlasticosDBContext db = new PlasticosDBContext();
                try
                {
                    if(db.posiciones.Where(p=>p.eliminado == 0).Any())
                    {
                        int numero = db.posiciones.Where(p => p.eliminado == 0).OrderByDescending(p => p.codigo).FirstOrDefault().codigo;
                        TxtCodigo.Text = (numero + 1).ToString("D4");
                    } else
                    {
                        TxtCodigo.Text = 1.ToString("D4");
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
            } else
            {
                CboDeposito.SelectedValue = idDeposito;
            }
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("Falta ingresar código de Posición", "Falta código", MessageBoxButtons.OK);
                TxtCodigo.Focus();
                return;
            }

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Falta ingresar Nombre de Posición", "Falta nombre", MessageBoxButtons.OK);
                TxtDescripcion.Focus();
                return;
            }

            if(TxtCapacidad.Text == "")
            {
                TxtCapacidad.Text = "0";
            }

            if (nuevo)
            {
                PlasticosDBContext db1 = new PlasticosDBContext();
                int codigo = int.Parse(TxtCodigo.Text.ToString());
                if (db1.posiciones.Where(c => c.codigo == codigo && c.eliminado == 0).Any())
                {
                    MessageBox.Show("Código de posición en uso. Seleccione otro.", "Código Duplicado", MessageBoxButtons.OK);
                    TxtCodigo.Focus();
                    return;
                }
                db1.Dispose();
            }

            posiciones pos = new posiciones
            {
                codigo = int.Parse(TxtCodigo.Text.ToString()),
                nombre = TxtDescripcion.Text,
                capacidad = double.Parse(TxtCapacidad.Text),
                iddeposito = (int)CboDeposito.SelectedValue,
                eliminado = 0
            };

            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                if (nuevo)
                {
                    db.posiciones.Add(pos);
                } else
                {
                    pos.id = id;
                    db.Entry(pos).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                id = pos.id;
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
            nuevo = false;
            Close();
        }
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("."))
            {
                e.KeyChar = char.Parse(",");
            }
            e.Handled = Modulo.CambioPunto(TxtCodigo, (int)e.KeyChar);
        }

        private void TxtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("."))
            {
                e.KeyChar = char.Parse(",");
            }
            e.Handled = Modulo.CambioPunto(TxtCapacidad, (int)e.KeyChar);
        }
    }
}
