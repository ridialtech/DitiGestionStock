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
    public partial class frmProduit : Form
    {
        private BdDitiGestionStockContext db = new BdDitiGestionStockContext();
        public frmProduit()
        {
            InitializeComponent();
        }

       
        private void frmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = db.Produits.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.PuProduit = float.Parse(txtPrixUnitaire.Text);
            p.DescriptionProduit = txtDescription.Text;
            p.CodeProduit = txtCode.Text;
            p.LibelleProduit = txtLibelle.Text;
            p.QuantiteMinimale = float.Parse(txtQuantiteMinimale.Text);
            p.QuantiteSeuil = float.Parse(txtQuantiteSeuil.Text);
            p.Persissable = cbbPerissable.Text;
            db.Produits.Add(p);
            db.SaveChanges();
            Effacer();

        }

        public void Effacer()
        {
            txtQuantiteSeuil.Text = String.Empty;
            txtCode.Text = String.Empty;
            txtQuantiteMinimale.Text = String.Empty;
            txtPrixUnitaire.Text= String.Empty;
            txtDescription.Text =String.Empty;
            txtLibelle.Text = String.Empty;
            cbbPerissable.Text = String.Empty;
            dgProduit.DataSource = db.Produits.ToList();
            txtCode.Focus();



        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            txtQuantiteSeuil.Text = p.QuantiteSeuil.ToString();
            txtCode.Text = p.CodeProduit;
            txtQuantiteMinimale.Text = p.QuantiteMinimale.ToString();
            txtDescription.Text = p.DescriptionProduit;
            txtLibelle.Text = p.LibelleProduit;
            cbbPerissable.Text = p.Persissable;
            txtPrixUnitaire.Text = p.PuProduit.ToString();


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            p.DescriptionProduit = txtDescription.Text;
            p.CodeProduit = txtCode.Text;
            p.LibelleProduit = txtLibelle.Text;
            p.QuantiteMinimale = float.Parse(txtQuantiteMinimale.Text);
            p.QuantiteSeuil = float.Parse(txtQuantiteSeuil.Text);
            p.Persissable = cbbPerissable.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            db.Produits.Remove(p);
            db.SaveChanges();
            Effacer();
        }
    }
}
