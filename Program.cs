using System;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace test
{

    

    class Program
    {
        static void  Main(string[] args)
        {
            string url = string.Format("https://60cbfbd371b73400171f6cfb.mockapi.io/api/v1/products/1");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            //Method1(args).GetAwaiter().GetResult();
            //int test = await prog.Request();
            var jsonString =  client.GetStringAsync(url).GetAwaiter().GetResult();
                

            JToken token = JToken.Parse(jsonString);
            foreach (var item in token)
            {
                Console.WriteLine(item.ToString());
            }

            
        }

        static async Task Method1(string[] args)
        //public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }
        public int Request(){
            return 1;
        }

    }
}
