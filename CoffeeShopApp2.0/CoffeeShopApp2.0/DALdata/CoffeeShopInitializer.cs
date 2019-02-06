using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CoffeeShopApp2._0.DALdata
{
    public class CoffeeShopInitializer : System.Data.Entity.DropCreateDatabaseAlways<CoffeeShopContext>
    {
        //ADD hardcoded list of store inventory
    }
}