using LRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LRS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> GetResult(string Code, string PhoneNumber)
        {
            HttpClient client = new HttpClient();
            string apiServer = _configuration.GetValue<string>("ConnectionStrings:Connection");
            
            try
            {
                var response = client.GetAsync(apiServer + "Result/GetResult?Code=" + Code + "&PhoneNumber=" + PhoneNumber);
                if (response.Result.IsSuccessStatusCode)
                {
                    var respond = response.Result.Content.ReadAsStringAsync();
                    if (respond.Result == "NotExist")
                    {
                        return Ok("NotExist");
                    }

                    

                    return File(response.Result.Content.ReadAsStream(), /*response.Result.Content.Headers.ContentType.ToString()*/"APPLICATION/pdf", response.Result.Content.Headers.ContentDisposition.FileName.ToString());
                }
                else
                {
                    return Ok("Error");
                }
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
