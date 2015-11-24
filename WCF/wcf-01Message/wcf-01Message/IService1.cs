using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_01Message
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Mesaj();
    }
}
