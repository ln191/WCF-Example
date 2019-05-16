using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PairArihmeticService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PairArihmeticService.svc or PairArihmeticService.svc.cs at the Solution Explorer and start debugging.
    public class PairArihmeticService : IPairArihmeticService
    {
        Pair IPairArihmeticService.Add(Pair p1, Pair p2)
        {
            Pair result = new Pair();

            result.First = p1.First + p2.First;
            result.Second = p1.Second + p2.Second;

            return result;
        }

        Pair IPairArihmeticService.Subtract(Pair p1, Pair p2)
        {
            Pair result = new Pair();

            result.First = p1.First - p2.First;
            result.Second = p1.Second - p2.Second;

            return result;
        }
    }
}