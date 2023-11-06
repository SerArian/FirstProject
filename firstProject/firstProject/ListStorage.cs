using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class ListStorage : Storage
    {
        private List<Product> productList = new List<Product>();

        public override void InsertProduct(Product product)
        {
            productList.Add(product);
        }

        public override void UpdateProduct(int id, string name, string measurementUnit)
        {
            // Find the product in your list based on the ID
            Product product = productList.FirstOrDefault(p => p.ID == id);

            if (product != null)
            {
                // Update the product's properties
                product.Name = name;
                product.MeasurementUnit = measurementUnit;
            }
        }

        public override void DeleteProduct(int id)
        {
            // Find the product in the list with the matching ID and remove it
            Product product = productList.FirstOrDefault(p => p.ID == id);

            if (product != null)
            {
                productList.Remove(product);
            }
        }



        public override List<Product> GetProducts()
        {
            return productList;
        }
    }
}
