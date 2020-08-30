using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entities;

namespace WindowsFormsApp2
{
    public class ProjeContext : DbContext
    {

        public ProjeContext():base("DenemeDb")
        {
            Database.SetInitializer<ProjeContext>(new Initializer());
            Database.Initialize(true); // Normalde bu satırı yazmassan ilk entity sorgunda initializer çalışır ama bunu yazarsan projen çalışınca initializer çalışır ve vten oluşur
        }

        public DbSet<Product> Products { get; set; }


    }
}
