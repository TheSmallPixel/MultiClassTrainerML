using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Test
    {
        public TrainData data;
        public Dictionary<float, string> Index;
    }
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task Main(string[] args) {

            var data = GenerateRandomDataPoints(1000);///TrainData.DB(10);
            var testData = GenerateRandomDataPoints(10, seed: 123);

            Task<HttpResponseMessage> response = client.PostAsync(
                 "http://localhost:5000/api/Learn",
                 new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
                 );
            response.Wait();
            Console.WriteLine("=================================");
            string r = await response.Result.Content.ReadAsStringAsync();
            Console.WriteLine(r);
            response.Dispose();


            Task<HttpResponseMessage> responseTest = client.PostAsync(
                "http://localhost:5000/api/Test",
                new StringContent(JsonConvert.SerializeObject(testData), Encoding.UTF8, "application/json")
                );
            responseTest.Wait();
            string rb = await responseTest.Result.Content.ReadAsStringAsync();
            responseTest.Dispose();
            Console.WriteLine(rb);



            Console.ReadLine();
        }
        private static IEnumerable<TrainData> GenerateRandomDataPoints(int count,
            int seed = 0) {
            var random = new Random(seed);
            float randomFloat() => (float)(random.NextDouble() - 0.5);
            for (int i = 0; i < count; i++) {
                // Generate Labels that are integers 1, 2 or 3
                var label = random.Next(1, 4);
                yield return new TrainData {
                    Label = (uint)label,
                    Features = Enumerable.Repeat(label, 20)
                        .Select(x => randomFloat() + label * 0.2f).ToArray()

                };
            }
        }
        public static Dictionary<float, string> ConvertD(string[] data) {
            Dictionary<float, string> returndata = new Dictionary<float, string>();
            for (int i = 0; i < data.Length; i++) {
                returndata.Add(i, data[i]);
            }
            return returndata;
        }
        
    }

}