using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iinches_toYards" in both code and config file together.
    [ServiceContract]
    public interface inches_convert
    {
        [OperationContract]
        double inches_toYards(int a);
        [OperationContract]
        double inches_toFeet(int a);
        //float Inches_toYards(int a);
    }
}
