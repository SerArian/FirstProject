using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    public abstract class Storage
    {
        public abstract void InsertProduct(Product product);
        public abstract void UpdateProduct(int id, string name, string measurementUnit);
        public abstract void DeleteProduct(int id);
        public abstract List<Product> GetProducts();
    }

}
