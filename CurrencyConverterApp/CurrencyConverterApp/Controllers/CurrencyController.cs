using CurrencyConverterApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;

namespace CurrencyConverterApp.Controllers
{
    public class CurrencyConverterController : Controller
    {
        private readonly IMemoryCache memoryCache;
        private readonly ILogger<CurrencyConverterController> _logger;

        public CurrencyConverterController(ILogger<CurrencyConverterController> logger, IMemoryCache memoryCache)
        {
            _logger = logger;
            this.memoryCache = memoryCache;
        }

       
        public IActionResult Index()
        {
           
            return View();
        }



        [HttpPost]
        [Route("CurrencyConverter/GetCurrency")]

        [HttpPost]
        public IActionResult GetCurrency(decimal Amount)
        {
            try
            {
                CurrencyConverter model = GetDataFromSource();

                //  конвертации и кэширования

                return View("../Home/Index", model); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка обработки POST-запроса.");
                return RedirectToAction("Error");
            }
        }





        // Пример метода для получения данных
        private CurrencyConverter GetDataFromSource()
        {
            
            return new CurrencyConverter();
        }
    }
}
