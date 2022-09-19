using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace ClassLibStandard.Contracts
{
    [ServiceContract]
    public interface TesteContract
    {

        [OperationContract]
        string Ping(string s);


    }
}
