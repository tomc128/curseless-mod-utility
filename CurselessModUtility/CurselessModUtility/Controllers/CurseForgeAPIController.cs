using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurselessModUtility.Controllers
{
    internal class CurseForgeAPIController
    {
        // singleton
        private static readonly CurseForgeAPIController _instance = new CurseForgeAPIController();
        public static CurseForgeAPIController Instance => _instance;


        private static Uri BaseURI { get => new Uri("https://api.curseforge.com"); }

        private readonly HttpClient client = new HttpClient();

        public void Init()
        {
            client.BaseAddress = BaseURI;
            client.DefaultRequestHeaders.Add("x-api-key", "$2a$10$SO2fbSrD9xGV5MCSwQ.bXOMi.Exgg9UXm9PWIXtghK2rm/sQc58ae");
        }

        public async Task<dynamic> Request(string url)
        {
            var response = await client.GetAsync(url);
            return response;
        }

        public async Task GetMod(string url)
        {
            throw new NotImplementedException();
        }
    }
}
