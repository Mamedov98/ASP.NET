using Microsoft.Extensions.Caching.Memory;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyConverterApp.Models
{
    public class CurrencyService : BackgroundService
    {
     private readonly IMemoryCache memoryCache;

        public CurrencyService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested) 
            {
                try
                {

                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    XDocument xml = XDocument.Load("https://www.cbar.az/currencies/17.07.2023.xml");
                    CurrencyConverter currencyConverter = new CurrencyConverter();


                    //currencyConverter.USD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("ValType").Elements("Valute")
                    //   .FirstOrDefault(x => x.Attribute("Code")?.Value == "AZN")?.Element("Value")?.Value);

                    currencyConverter.USD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("ValType").Elements("Valute")
                        .FirstOrDefault(x => x.Attribute("Code")?.Value == "USD")?.Element("Value")?.Value);

                    currencyConverter.EUR = Convert.ToDecimal(xml.Elements("ValCurs").Elements("ValType").Elements("Valute")
                        .FirstOrDefault(x => x.Attribute("Code")?.Value == "EUR")?.Element("Value")?.Value);

                    currencyConverter.TRY = Convert.ToDecimal(xml.Elements("ValCurs").Elements("ValType").Elements("Valute")
                        .FirstOrDefault(x => x.Attribute("Code")?.Value == "TRY")?.Element("Value")?.Value);

                    currencyConverter.RUB = Convert.ToDecimal(xml.Elements("ValCurs").Elements("ValType").Elements("Valute")
                        .FirstOrDefault(x => x.Attribute("Code")?.Value == "RUB")?.Element("Value")?.Value);


                    
                    memoryCache.Set("key_currency", currencyConverter, TimeSpan.FromMinutes(1440));
                }
                catch 
                {
                    

                }
                await Task.Delay(3600000,stoppingToken);
            }
        }
    }
}
