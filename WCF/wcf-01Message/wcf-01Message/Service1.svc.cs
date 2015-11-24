using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_01Message
{
    public class Service1 : IService1
    {
        public string Mesaj()
        {
            return "HELLO WCF SERVICES!";
        }
    }
}
