using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DitiGestionStock.View;

namespace DitiGestionStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            MdiForm f = new MdiForm();
            f.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
