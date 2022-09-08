using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAPPMVC.Helper;
using WebAPPMVC.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace WebAPPMVC.Controllers
{
    public class HomeController : Controller
    {
        public string contain { get; set; }
        TimeTrackingAPI _api = new TimeTrackingAPI();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/employee");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                empDetails = JsonConvert.DeserializeObject<List<EmployeeDetails>>(results);
                contain = "admin";
            }
            return View(empDetails);
        }
        public async Task<IActionResult> Index1()
        {
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/employee");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                empDetails = JsonConvert.DeserializeObject<List<EmployeeDetails>>(results);
                contain = "staff";
            }
            return View(empDetails);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var empDetails = new EmployeeDetails();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/employee/Id?Id={Id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                empDetails = JsonConvert.DeserializeObject<EmployeeDetails>(results);

            }
            return View(empDetails);
        }
        public async Task<IActionResult> Edit(int Id)
        {
            var empDetails = new EmployeeDetails();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/employee/Id?Id={Id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                empDetails = JsonConvert.DeserializeObject<EmployeeDetails>(results);

            }
            return View(empDetails);
        }

        public ActionResult create()
        {
            return View();
        }
        public ActionResult update()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Login", new { area = "" });
        }

        [HttpPost]
        public IActionResult create(EmployeeDetails empDetails)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<EmployeeDetails>("api/employee", empDetails);
            postTask.Wait();


            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPut]
        public IActionResult update(EmployeeDetails empDetails)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PutAsJsonAsync<EmployeeDetails>("api/employee", empDetails);
            postTask.Wait();


            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Wedit(EmployeeDetails objEmp)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PutAsJsonAsync<EmployeeDetails>("api/employee", objEmp);
            postTask.Wait();


            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                string x = TempData["contain"].ToString();
                if ( x == "admin") {
                    return RedirectToAction("Index");
                }
                else {
                    return RedirectToAction("Index1");
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteEmployee(int Id)
        {
            var empDetails = new EmployeeDetails();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/employee/Id?Id={Id}");

            return RedirectToAction("Index");
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
    }
}
