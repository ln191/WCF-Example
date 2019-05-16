using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPairArihmeticService" in both code and config file together.
    [ServiceContract]
    public interface IPairArihmeticService
    {
        [OperationContract]
        Pair Add(Pair p1, Pair p2);

        [OperationContract]
        Pair Subtract(Pair p1, Pair p2);
    }
}