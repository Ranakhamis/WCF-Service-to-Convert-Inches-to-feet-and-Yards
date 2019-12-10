using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "inches_toYards" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select inches_toYards.svc or inches_toYards.svc.cs at the Solution Explorer and start debugging.
    public class inches_toYards : inches_convert
    {
       

        double inches_convert.inches_toFeet(int a)
        {
           return a* (1.0 / 12.0);
        }

        //double inches_convert.Inches_toYards(int a)
        //{
        //    return  a * (1.0 / 36.0);       
        //}

        double inches_convert.inches_toYards(int a)
        {
            return a * (1.0 / 36.0);

        }
    }
}
