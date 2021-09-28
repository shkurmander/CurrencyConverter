using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class ValuteRepository
    {
        const string URL = "https://www.cbr-xml-daily.ru/daily_json.js";

        private readonly List<Valute> _valutes = new List<Valute>();


        public ValuteRepository()
        {
            Load();
        }
        public IEnumerable<Valute> GetAll() => _valutes;

        public Valute GetByCharCode(string charCode) => _valutes.FirstOrDefault(v => v.CharCode == charCode);

      
        private void Load()
        {
            _valutes.Add(new Valute()
            {
                Id = "00000",
                NumCode = 810,
                CharCode = "RUB",
                Nominal = 1,
                Name = "Российский рубль",
                Value = 1,
                Previous = 1
            });

            using (WebClient client = new WebClient())
            {
                var jsonStr = client.DownloadString(URL);
                var jObj = JObject.Parse(jsonStr);
                //избавляемся от вложенности и конвертим в словарь.
                var jList = (jObj["Valute"]);
                jObj = (JObject)jList;
                var courses = jObj.ToObject<Dictionary<string, Valute>>();

                foreach (var item in courses)
                {
                    _valutes.Add(item.Value);
                }
            }
        }
    }
}
