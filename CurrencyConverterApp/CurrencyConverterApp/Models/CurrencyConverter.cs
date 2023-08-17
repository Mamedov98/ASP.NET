namespace CurrencyConverterApp.Models
{
    public class CurrencyConverter
    {

        

        public decimal USD { get; set; }
        public decimal ConvertToUSD(decimal priceAzn) => priceAzn / USD;
      
        
        public decimal EUR { get; set; }
        public decimal ConvertToEU(decimal priceAzn) => priceAzn / EUR;
         public decimal TRY { get; set; }
        public decimal ConvertToTL(decimal priceAzn) => priceAzn / TRY;



        public decimal RUB { get; set; }
        public decimal ConvertToRUB(decimal priceAzn)
        {
            if (RUB != 0)
            {
                return priceAzn / RUB;
            }
            else
            {
                
                // сделал это,чтобы вместо ошибки 0 выходило хотя бы,не могу понять почему 0 
                return 0;
            }
        }

    }
}
