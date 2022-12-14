using ClassLibStandard;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore31.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // LabService labService = new LabService();
            // labService.Testar();
            PerfomanceTeste perfomanceTeste = new PerfomanceTeste(this._logger);
            RetornoTeste retorno = perfomanceTeste.executar();
            ViewData["Dados"] = retorno;
        }
    }
}
