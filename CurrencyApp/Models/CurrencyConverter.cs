namespace CurrencyApp.Models
{
    /// <summary>
    /// Класс отвечающий за конвертацию валюь. Относительно ррубля
    /// </summary>
    public class CurrencyConverter
    {
        /// <summary>
        /// Доллар
        /// </summary>
        public decimal USD { get; set; }
        public decimal ConvertToUSD(decimal priceRUB) => priceRUB / USD;

        /// <summary>
        /// Евро
        /// </summary>
        public decimal EUR { get; set; }
        public decimal ConvertToEUR(decimal priceRUB) => priceRUB / EUR;

        /// <summary>
        /// Гривны
        /// </summary>
        //10 гривен номинал (такие данные от ЦБ)
        public decimal UAH10 { get; set; }
        public decimal ConvertToUAH(decimal priceRUB) => priceRUB / (UAH10 / 10);
    }
}
