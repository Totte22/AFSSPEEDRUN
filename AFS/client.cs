using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.Windows;

namespace AFS
{
    public class Reques
    {
        public class fuel
        {
            public string address { get; set; }
            public string type1 { get; set; }
            public decimal price1 { get; set; }
            public int amount1 { get; set; }
            public string type2 { get; set; }
            public decimal price2 { get; set; }
            public int amount2 { get; set; }
            public string type3 { get; set; }
            public decimal price3 { get; set; }
            public int amount3 { get; set; }
            public string type4 { get; set; }
            public decimal price4 { get; set; }
            public int amount4 { get; set; }
        }
        public static async Task<fuel> client(string a)
        {
            try
            {
                HttpClient _client = new HttpClient();
                string resp = await _client.GetStringAsync("http://localhost:57208/api/fuelINFO?id=" + a);
                var b = JsonConvert.DeserializeObject<fuel>(resp);
                return b;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
