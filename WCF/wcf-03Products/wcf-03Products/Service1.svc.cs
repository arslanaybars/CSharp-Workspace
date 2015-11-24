using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_03Products
{
    public class Service1 : IService1
    {

        public List<Product> listProducts()
        {
            List<Product> liste = new List<Product>();

            Product p;
            p = new Product();
            p.ID = 1;
            p.Name = "Portakal";
            p.Price = 4;
            p.Description = "Finike Portakalı";
            liste.Add(p);

            p = new Product();
            p.ID = 2;
            p.Name = "Şeftali";
            p.Price = 3;
            p.Description = "Bursa Şeftalisi";
            liste.Add(p);

            p = new Product();
            p.ID = 3;
            p.Name = "Elma";
            p.Price = 2;
            p.Description = "Amasya Elması";
            liste.Add(p);

            p = new Product();
            p.ID = 4;
            p.Name = "Karpuz";
            p.Price = 10;
            p.Description = "Diyarbakır Karpuzu";
            liste.Add(p);

            return liste;
        }
    }
}
