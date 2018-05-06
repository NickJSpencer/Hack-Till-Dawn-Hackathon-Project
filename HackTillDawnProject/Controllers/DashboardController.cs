using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTillDawnProject.Models;
using HackTillDawnProject.Models.JsonModels;


namespace HackTillDawnProject.Controllers
{
    public class DashboardController : Controller
    {
        /* Services */
        IFootageStorageService _FootageStorageService;
        public DashboardController(IFootageStorageService ifss)
        {
            _FootageStorageService = ifss;
        }

        public IActionResult Index()
        {
            return View();
        }

        public GetAllCurrentNotifications()
        {
            List<NotificationJson> notifications = new List<NotificationJson>();

            List<FootageStorage> videos = _FootageStorageService.GetAllCurrent();
            

        }
    }
}
