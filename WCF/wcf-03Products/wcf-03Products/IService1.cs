using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_03Products
{
    [ServiceContract]
    public interface IService1
    {
        //metodların dışarıya açılması için
        [OperationContract]
        List<Product> listProducts();
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}