using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;

namespace PlasticosCerriDeposito
{
    public partial class DepositosCarga : Form
    {
        private static int id;
        private static bool nuevo;

        public static int Id { get => id; set => id = value; }
        public static bool Nuevo { get => nuevo; set => nuevo = value; }
        public DepositosCarga()
        {
            InitializeComponent();
            if (!nuevo)
            {
                TxtCodigo.Enabled = false;
            }
        }

        private void DepositosCarga_Load(object sender, EventArgs e)
        {
            if (nuevo)
            {
                PlasticosDBContext db = new PlasticosDBContext();
                try
                {
                    if (db.depositos.Where(p => p.eliminado == 0).Any())
                    {
                        int numero = db.depositos.Where(p => p.eliminado == 0).OrderByDescending(p => p.codigo).FirstOrDefault().codigo;
                        TxtCodigo.Text = (numero + 1).ToString("D4");
                    }
                    else
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
            }
        }
        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("Falta ingresar código de depósito", "Falta código", MessageBoxButtons.OK);
                TxtCodigo.Focus();
                return;
            }

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Falta ingresar Nombre de depósito", "Falta nombre", MessageBoxButtons.OK);
                TxtDescripcion.Focus();
                return;
            }

            if (nuevo)
            {
                PlasticosDBContext db1 = new PlasticosDBContext();
                int codigo = int.Parse(TxtCodigo.Text.ToString());
                if (db1.depositos.Where(c => c.codigo == codigo && c.eliminado == 0).Any())
                {
                    MessageBox.Show("Código de depósito en uso. Seleccione otro.", "Código Duplicado", MessageBoxButtons.OK);
                    TxtCodigo.Focus();
                    return;
                }
                db1.Dispose();
            }

            depositos deposito = new depositos
            {
                codigo = int.Parse(TxtCodigo.Text.ToString()),
                nombre = TxtDescripcion.Text,
                eliminado = 0
            };
            PlasticosDBContext db = new PlasticosDBContext();
            try
            {
                if (nuevo)
                {
                    db.depositos.Add(deposito);
                } else
                {
                    deposito.id = id;
                    db.Entry(deposito).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                id = deposito.id;
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
    }
}
