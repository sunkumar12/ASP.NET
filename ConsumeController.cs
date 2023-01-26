using MynewASPWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MynewASPWEBAPI.Controllers
{
    public class ConsumeController : Controller
    {
        // GET: Consume
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<employee_tab1> list = new List<employee_tab1>();
            client.BaseAddress = new Uri("https://localhost:44334/api/NewAPI");
            var response = client.GetAsync("NewAPI");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<employee_tab1>>();
                display.Wait();
                list = display.Result;

            }

            return View(list);
        }
    }
}