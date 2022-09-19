using System;
using WebAppServerCore31.Contracts;

namespace WebAppServerCore31
{
    public class TesteContractService : TesteContract
    {
        public string Ping(string s)
        {
            Console.WriteLine("Exec ping methdo");
            return $"Pong para {s}";
        }
    }
}
