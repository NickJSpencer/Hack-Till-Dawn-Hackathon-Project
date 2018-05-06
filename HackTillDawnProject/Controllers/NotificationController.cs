using HackTillDawnProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Controllers
{
    public class NotificationController : Controller
    {
        private IFootageStorageService _FootageStorageService { get; }
        public NotificationController(IFootageStorageService ifss)
        {
            _FootageStorageService = ifss;
        }

        public JsonResult GetNotifications(string channel_id)
        {
            Guid channel_guid;
            if(Guid.TryParse(channel_id, out channel_guid))
            {

                return Json(_FootageStorageService.GetAllForChannel(channel_guid));
            }
            else
            {
                return Json(new Result()
                {
                    result = "Failure",
                    result_description = "Invalid GUID format",
                    status_code = 406
                });
            }
        }
    }


    public class Result
    {
        public string result { get; set; }
        public string result_description { get; set; }
        public int status_code { get; set; }
        public string result_data { get; set; }
    }
}
