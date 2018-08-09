using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OnlineShopping.Hubs;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IHubContext<ChatHub> hubcontext)
        {
            HubContext = hubcontext;
            //https://stackoverflow.com/questions/46904678/call-signalr-core-hub-method-from-controller
        }

        private IHubContext<ChatHub> HubContext
        {
            get;
            set;
        }

        public IActionResult Index()
        {
            var lstVideo = ListVideo.Videoes();
            ViewBag.Videoes = lstVideo;
            return View();
        }

        public IActionResult QrGenerate()
        {
            return View();
        }

        public async Task<IActionResult> ApiCall(string ip, int id)
        {

            await this.HubContext.Clients.All.SendAsync(ip, id, ListVideo.Videoes().First(x => x.Id == Convert.ToInt32(id)).URL);
            VideoOwned.AddUser(ip, id);
            return Content("successfull");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
