using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace DitiGestionStock.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdDitiGestionStockContext : DbContext
    {
        public BdDitiGestionStockContext() : base("bdditigestionstockContext")
        { }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }


    }
}
