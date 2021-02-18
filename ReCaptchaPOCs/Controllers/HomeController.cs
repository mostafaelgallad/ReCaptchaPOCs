using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ReCaptchaPOCs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReCaptchaPOCs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verify(IndexModel indexModel)
        {

            return View("Index");
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReCAPTCHAServiceResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ReCAPTCHAServiceResponse> VerifyRecaptcha(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var res = httpClient.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret=6Ld58VgaAAAAAMM5Zh5X3RfQAfo6VgeJ6YhcM2LX&response={token}").Result;
                    var response = JsonConvert.DeserializeObject<ReCAPTCHAServiceResponse>(res);
                    return response;
                }
            }
            return BadRequest();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public class ReCAPTCHAServiceResponse
        {
            public bool success { get; set; }
            public double score { get; set; }
            public string action { get; set; }
            public string hostname { get; set; }
            public DateTime challenge_ts { get; set; }
        }
    }
}
