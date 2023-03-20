using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using PlasticosCerriDeposito.Models;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace PlasticosCerriDeposito
{
    public class Modulo
    {
        public static bool CambioPunto(TextBox text, int KeyAscii)
        {
            int h;
            int i;
            string cadena;
            bool coma = false;

            if (KeyAscii == 46)
            {
                KeyAscii = 44;
            }

            h = text.Text.Length;
            cadena = text.Text;

            for (i = 1; i <= h; i++)
            {
                if (Strings.Mid(cadena, i, 1) == ','.ToString())
                {
                    coma = true;
                    break;
                }
            }

            if (coma)
            {
                if (Strings.InStr("0123456789", Convert.ToChar(KeyAscii).ToString()) == 0)
                {
                    if (KeyAscii != 8) { return true; }
                }
            }
            else
            {
                if (Strings.InStr("0123456789,", Convert.ToChar(KeyAscii).ToString()) == 0)
                {
                    if (KeyAscii != 8) { return true; }
                }
            }

            return false;
        }

        public static bool SoloEnteros(Int16 KeyAscii)
        {
            return !((Char.IsDigit(Convert.ToChar(KeyAscii))) || (char.IsControl(Convert.ToChar(KeyAscii))));
        }

        public static void ModificoItemStock(int idArt, int cantidad, string operacion, int idDeposito, int idPosicion)
        {
            PlasticosDBContext db = new PlasticosDBContext();
            if (db.stock.Where(s => s.idarticulo == idArt && s.idposicion == idPosicion && s.iddeposito == idDeposito).Any())
            {
                stock stockArt = db.stock.FirstOrDefault(s => s.idarticulo == idArt && s.idposicion == idPosicion && s.iddeposito == idDeposito);
                if (operacion == "-")
                {
                    stockArt.cantstock -= cantidad;
                }
                else
                {
                    stockArt.cantstock += cantidad;
                }
                db.Entry(stockArt).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
            }
            else
            {
                int cantidadStock = 0;
                if (operacion == "-")
                {
                    cantidadStock -= cantidad;
                }
                else
                {
                    cantidadStock += cantidad;
                }
                stock stockArt = new stock
                {
                    idarticulo = idArt,
                    iddeposito = idDeposito,
                    idposicion = idPosicion,
                    cantstock = cantidadStock,
                    eliminado = 0,
                };
                db.stock.Add(stockArt);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public static void CreoPDF(string ruta, byte[] bytes, bool abroPDF)
        {
            try
            {
                FileStream archivo = new FileStream(ruta, FileMode.Create);
                archivo.Write(bytes, 0, bytes.Length);
                archivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (abroPDF)
            {
                try
                {
                    if (ExisteArchivo(ruta))
                    {
                        if (!EstaAbierto(ruta))
                        {
                            Process proceso = new Process();
                            proceso.StartInfo.FileName = ruta;
                            proceso.StartInfo.Arguments = "";
                            proceso.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private static bool EstaAbierto(string ruta)
        {
            try
            {
                FileStream fileOpen = File.OpenWrite(ruta);
                fileOpen.Close();
            }
            catch
            {
                return true;
            }
            return false;
        }

        public static bool ExisteArchivo(string StrFile)
        {
            string StrName;
            StrName = FileSystem.Dir(StrFile);
            return !(StrName == "");
        }
    }
}
