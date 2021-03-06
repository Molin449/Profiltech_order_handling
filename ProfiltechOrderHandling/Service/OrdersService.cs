using Newtonsoft.Json;
using ProfiltechOrderHandling.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProfiltechOrderHandling.Service {
    class OrdersService {
        private string SecretKey = "consumer_secret=cs_e8a2af9cd6ba82b2facf921607efbc6792ecd989";
        private string ConsumerKey = "consumer_key=ck_73c957bfdcd6f0f60e8922f971807f7c4d24aa4e";
        private string Url = "https://profiltech.dk/";


        public Order GetOrder(string orderNumber) {
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri(Url);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            // List all Names.
            HttpResponseMessage response = client.GetAsync($"wp-json/wc/v3/orders/{orderNumber}?{SecretKey}&{ConsumerKey}").Result;  // Blocking call!

            Order order = new Order();
            if (response.IsSuccessStatusCode) {
                string orderJson = response.Content.ReadAsStringAsync().Result;
               
                order = JsonConvert.DeserializeObject<Order>(orderJson);
            }

            return order;


        }






        public List<Order> GetOrders(string orderNumber) {
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri(Url);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            // List all Names.
            HttpResponseMessage response = client.GetAsync($"wp-json/wc/v3/orders/?{SecretKey}&{ConsumerKey}").Result;  // Blocking call!

            List<Order> orders = new List<Order>();
            if (response.IsSuccessStatusCode) {
                string orderJson = response.Content.ReadAsStringAsync().Result;


                orders = JsonConvert.DeserializeObject<List<Order>>(orderJson);
            }

            return orders;


        }
    }
}
