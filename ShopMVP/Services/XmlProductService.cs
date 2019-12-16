using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ShopMVP.Models;

namespace ShopMVP.Services
{
    public class XmlProductService : IProductService
    {
        private string path = "shop.xml";

        public List<Product> GetProducts()
        {
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    List<Product> emptyList = new List<Product>();
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    serializer.Serialize(fs, emptyList);
                    return emptyList;
                }
            }
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                return serializer.Deserialize(fs) as List<Product>;
            }
        }

        public void AddProduct(Product product)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                var products = serializer.Deserialize(fs) as List<Product>;
                product.Id = (products.Count == 0 ? 1 : products.Max(p => p.Id) + 1);
                products.Add(product);
                fs.Seek(0, SeekOrigin.Begin);
                serializer.Serialize(fs, products);
            }
        }

        public void RemoveProduct(Product product)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                var products = serializer.Deserialize(fs) as List<Product>;
                products.Remove(products.Find(p => p.Id == product.Id));
                fs.SetLength(0);
                serializer.Serialize(fs, products);
            }
        }
    }
}
