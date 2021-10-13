using LeedsBeerQuest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeedsBeerQuest.Web.Controllers
{
    public class PubReviewsController : Controller
    {
        string baseUrl = "http://localhost:10440";

        public async Task<IActionResult> Index()
        {
            var pubs = new List<PubViewModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage Res = await client.GetAsync("api/pubreviews/pubs");
                if (Res.IsSuccessStatusCode)
                {
                    var pubsResponse = Res.Content.ReadAsStringAsync().Result;
                    pubs = JsonConvert.DeserializeObject<List<PubViewModel>>(pubsResponse);
                }
                return View(pubs);
            }
        }
    }
}
