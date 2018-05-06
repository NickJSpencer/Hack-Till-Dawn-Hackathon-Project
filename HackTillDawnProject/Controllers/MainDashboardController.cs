using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTillDawnProject.Models;
using HackTillDawnProject.Models.JsonModels;
using Microsoft.AspNetCore.Mvc;

namespace HackTillDawnProject.Controllers
{
    public class MainDashboardController : Controller
    {

        /* Services */
        //IFootageStorageService _FootageStorageService;
        public MainDashboardController(/*IFootageStorageService ifss*/)
        {
            //_FootageStorageService = ifss;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCurrentNotifications()
        {
            List<NotificationJson> notifications = new List<NotificationJson>();

            //List<FootageStorage> videos = _FootageStorageService.GetAllCurrent();

            return null;
        }
    }
}