using CoffeeShopApp2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CoffeeShopApp2._0.DALdata
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext() : base("CoffeeContext")
        {

        }

        public DbSet<UserClient> UserClients { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<CoffeeShopApp2._0.Models.InventoryCoffee> InventoryCoffees { get; set; }
    }
}