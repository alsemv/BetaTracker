using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BetaTracker.Models;
using BetaTracker.Models.GameModel;
using BetaTracker.Services.PlaystationStoreServices;

namespace BetaTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public string Test(SingleGameService single)
        {
            Task<Root> root = single.LoadData("EP0001-CUSA08393_00-GAMEACEMPIRE0000");
            Root gameInfo = root.Result;
            return gameInfo.long_desc;
        }
    }
}
