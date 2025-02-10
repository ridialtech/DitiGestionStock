using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DitiGestionStock.Model;
namespace DitiGestionStock.View
{
    public partial class frmVente : Form

    {
        private BdDitiGestionStockContext db = new BdDitiGestionStockContext();
        public frmVente()
        {
            InitializeComponent();
        }

        private void txtCTelephone_MouseLeave(object sender, EventArgs e)
        {
            var c = db.Clients.Where(a => a.Telephone == txtCTelephone.Text).FirstOrDefault();

            if (c != null)
            {
                txtCDate.Text = c.DateNaissance.ToString();
                txtCEmail.Text = c.Email;
                txtCNomPrenom.Text = c.NomPrenom;
                txtCQuartier.Text = c.Quartier;

            }
        }

        private void frmVente_Load(object sender, EventArgs e)
        {

        }

        private void txtPCode_MouseLeave(object sender, EventArgs e)
        {
            var p = db.Produits.Where(a => a.CodeProduit == txtPCode.Text).FirstOrDefault();
            if (p != null)
            {
                txtPDatePremption.Text = p.
            }
        }
    }
}
