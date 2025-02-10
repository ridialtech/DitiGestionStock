using DitiGestionStock.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using DitiGestionStock.Model;

namespace DitiGestionStock.View
{
    public partial class Client : Form
    {
        private BdDitiGestionStockContext db = new BdDitiGestionStockContext();

        public Client()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            //ResetForm();
            dgClient.DataSource = db.Clients.ToList();

        }

        public void ResetForm()
        {
            txtEmail.Text= String.Empty;
            txtSexe.Text= String.Empty;
            txtQuartier.Text= String.Empty;
            txtTelephone.Text= String.Empty;
            txtNomPrenom.Text = String.Empty;
            dgClient.DataSource = db.Clients.ToList();



        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Model.Client c = new Model.Client();
           c.NomPrenom = txtNomPrenom.Text;
           c.Email = txtEmail.Text;
           c.Quartier = txtQuartier.Text;
           c.Sexe = txtSexe.Text;
           c.Telephone = txtTelephone.Text;
            DateTime DateNaissance = dtpDateNaissance.Value;
            c.DateNaissance = DateTime.Parse(DateNaissance.ToString()); 
            db.Clients.Add(c);
           db.SaveChanges();
          ResetForm();
        }
    }
}
