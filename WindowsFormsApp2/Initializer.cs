using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Initializer : CreateDatabaseIfNotExists<ProjeContext>
    {
        protected override void Seed(ProjeContext context)
        {

            context.Products.Add(new Entities.Product { Id = 1 , Name = "Deneme" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
