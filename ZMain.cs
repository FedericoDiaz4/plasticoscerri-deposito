using System;
using System.Windows.Forms;

namespace PlasticosCerriDeposito
{
    public partial class ZMain : Form
    {
        private ArticulosList ArticulosList;
        private DepositosList DepositosList;
        private PosicionesList PosicionesList;
        private IngresoStockList IngresoStockList;
        private SalidaStockList SalidaStockList;
        public ZMain()
        {
            InitializeComponent();
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void ARTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ArticulosList == null)
            {
                ArticulosList articulosList = new ArticulosList();
                ArticulosList = articulosList;
                ArticulosList.MdiParent = this;
                ArticulosList.FormClosed += new FormClosedEventHandler(CerrarArticulos);
                ArticulosList.Show();
            }
            else
            {
                ArticulosList.Show();
                ArticulosList.BringToFront();
            }
        }
        private void CerrarArticulos(object sender, FormClosedEventArgs e)
        {
            ArticulosList = null;
        }

        private void DEPOSITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DepositosList == null)
            {
                DepositosList depositosList = new DepositosList();
                DepositosList = depositosList;
                DepositosList.MdiParent = this;
                DepositosList.FormClosed += new FormClosedEventHandler(CerrarDepositos);
                DepositosList.Show();
            }
            else
            {
                DepositosList.Show();
                DepositosList.BringToFront();
            }
        }

        private void CerrarDepositos(object sender, FormClosedEventArgs e)
        {
            DepositosList = null;
        }

        private void POSICIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PosicionesList == null)
            {
                PosicionesList posicionesList = new PosicionesList();
                PosicionesList = posicionesList;
                PosicionesList.MdiParent = this;
                PosicionesList.FormClosed += new FormClosedEventHandler(CerrarPosiciones);
                PosicionesList.Show();
            }
            else
            {
                PosicionesList.Show();
                PosicionesList.BringToFront();
            }
        }

        private void CerrarPosiciones(object sender, FormClosedEventArgs e)
        {
            PosicionesList = null;
        }

        private void iNGRESOSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresoStockList == null)
            {
                IngresoStockList ingresoStockList = new IngresoStockList();
                IngresoStockList = ingresoStockList;
                IngresoStockList.MdiParent = this;
                IngresoStockList.FormClosed += new FormClosedEventHandler(CerrarIngresoStockList);
                IngresoStockList.Show();
            }
            else
            {
                IngresoStockList.Show();
                IngresoStockList.BringToFront();
            }
        }

        private void CerrarIngresoStockList(object sender, FormClosedEventArgs e)
        {
            IngresoStockList = null;
        }

        private void sALIDASTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SalidaStockList == null)
            {
                SalidaStockList salidaStockList = new SalidaStockList();
                SalidaStockList = salidaStockList;
                SalidaStockList.MdiParent = this;
                SalidaStockList.FormClosed += new FormClosedEventHandler(CerrarSalidaStockList);
                SalidaStockList.Show();
            }
            else
            {
                SalidaStockList.Show();
                SalidaStockList.BringToFront();
            }
        }

        private void CerrarSalidaStockList(object sender, FormClosedEventArgs e)
        {
            SalidaStockList = null;
        }
    }
}
