using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DitiGestionStock.View
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seDeconnecterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent=this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmVente f = new frmVente();
            f.MdiParent=this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            Client client = new Client();
            client.MdiParent=this;
            client.Show();
            client.WindowState = FormWindowState.Maximized;

        }
    }
}
 