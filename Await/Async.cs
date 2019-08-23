using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Await
{
    public class Async
    {
        private delegate void SpeakerEventHandle();
        public static void Main()
        {
            SpeakerEventHandle speaker = new SpeakerEventHandle(Say);
            Task<int> task = StartAsync();
            speaker();
            Thread.Sleep(5000);
        }

        static async Task<int> StartAsync()
        {
            Console.WriteLine("start...");
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync("https://www.visualstudio.com/");
            string str = await result;
            return str.Length;
        }
        static void Say()
        {

        }
    }
}
