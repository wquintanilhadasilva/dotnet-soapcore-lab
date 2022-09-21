using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class PerfomanceTeste
{

    private readonly ILogger _logger;

    public PerfomanceTeste(ILogger logger)
    {
        _logger = logger;
    }

    public RetornoTeste executar()
    {
        var watch = Stopwatch.StartNew();
        var retorno = new RetornoTeste();

        for (int i = 2; i < 20; i++)
        {
            var result = SumRootN(i);
            _logger.LogInformation("root {0}  :  {1}", i, result);
        }

        retorno.TempoA = watch.ElapsedMilliseconds;
        _logger.LogInformation("Tempo decorrido A: {0}", retorno.TempoA);

        _logger.LogInformation("---------------------------------------------------");
        _logger.LogInformation("");

        watch.Reset();
        watch.Start();

        Parallel.For(2, 20, (i) =>
        {
            var result = SumRootN(i);
            _logger.LogInformation("root {0}  :  {1}", i, result);
        });

        retorno.TempoB = watch.ElapsedMilliseconds;
        _logger.LogInformation("Tempo decorrido B: {0}", retorno.TempoB);

        return retorno;

    }

    public double SumRootN(int root)
    {
        double result = 0;
        for (int i = 1; i < 10000000; i++)
        {
            result += Math.Exp(Math.Log(i) / root);
        }

        return result;
    }

}

public class RetornoTeste {
    public long TempoA {get; set; }
    public long TempoB {get; set; }
}