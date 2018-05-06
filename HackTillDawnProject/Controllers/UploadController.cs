using HackTillDawnProject.ModelManager;
using HackTillDawnProject.Models;
using HackTillDawnProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Controllers
{
    public class UploadController : Controller
    {
        private IFootageStorageService _FootageStorageService { get; }
        private IRegisteredDeviceService _RegisteredDeviceService { get; }
        private IAPIResultTypeService _APIResultTypeService { get; }
        private IDeviceEventIntermediateService _DeviceEventIntermediateService { get; }
        private IEventService _EventService { get; }
        private IChannelContactService _ChannelContactService { get; }
        private IChannelService _ChannelService { get; }
        private IStaffEventIntermediateService _StaffEventIntermediateService { get; }
        private IContactService _ContactService { get; }
        private IAWSService _AWSService { get; }
        private FootageManager _FootageManager { get; }
        public UploadController(FootageManager fm,
            IFootageStorageService ifss,
            IRegisteredDeviceService irds,
            IAPIResultTypeService iapits,
            IDeviceEventIntermediateService ideis,
            IEventService ies,
            IChannelContactService iccs,
            IAWSService iawss,
            IChannelService ics,
            IStaffEventIntermediateService iseis,
            IContactService icos
            )
        {
            _FootageManager = fm;
            _FootageStorageService = ifss;
            _RegisteredDeviceService = irds;
            _APIResultTypeService = iapits;
            _DeviceEventIntermediateService = ideis;
            _EventService = ies;
            _AWSService = iawss;
            _ChannelContactService = iccs;
            _ChannelService = ics;
            _StaffEventIntermediateService = iseis;
            _ContactService = icos;


        }

        public JsonResult UploadNotificationFootage(IFormFile video)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Videos", video.FileName);
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                FootageStorage NewFootage = new FootageStorage()
                {
                    FileName = video.FileName,
                    FileLocation = path,
                    APIResultTypeId = Guid.Parse("19FCC874-77CB-4B41-2BD1-08D5B31651E5")
                };

                video.OpenReadStream().CopyTo(fs);
                _FootageStorageService.Add(NewFootage);
            }
            return Json(true);
        }


        public JsonResult SimulateTest1()
        {
            var footage = _FootageStorageService.Add(new FootageStorage()
            {
                APIResultTypeId = Guid.Parse("19FCC874-77CB-4B41-2BD1-08D5B31651E5"),
                FileName = "test",
                RegisteredDeviceId = Guid.Parse("DFB3A04B-AF60-4E59-9AA3-08D5B3164CB7"),
                TriggerConfidencePercent = 60
            });
            return Json(true);
        }
        public JsonResult SimulateTest2()
        {
            var footage = _FootageStorageService.Add(new FootageStorage()
            {
                APIResultTypeId = Guid.Parse("19FCC874-77CB-4B41-2BD1-08D5B31651E5"),
                FileName = "test2",
                RegisteredDeviceId = Guid.Parse("A0331C35-8454-402F-F613-08D5B318489E"),
                TriggerConfidencePercent = 60
            });
            return Json(true);
        }

        public IActionResult Index()
        {
            try
            {
                //var device = _RegisteredDeviceService.Add(new RegisteredDevice()
                //{
                //    DateRegistered = DateTime.UtcNow,
                //    DeviceIdName = "Test2",
                //    RegisteredById = "c748fbb9-3960-408c-9c8d-8d117e98994e"
                //});
                ////var Event = _EventService.Add(new Models.Event()
                ////{
                ////    Name = "HackTillDawn",
                ////    Description = "AngelHack Event"
                ////});
                ////var channel = _ChannelService.Add(new Channel()
                ////{
                ////    Description = "Identify People In Need",
                ////    Name = "Health Channel",
                ////    EventId = Event.IdEvent
                ////});
                //var device_event = _DeviceEventIntermediateService.Add(new DeviceEventIntermediate()
                //{
                //    IdEventId = Guid.Parse("F0ADC736-E4A9-40B0-651D-08D5B3164EAF"),
                //    IdRegisteredDeviceId = device.IdRegisteredDevice,
                //    DeviceLocation = "Dev Area"
                //});
                ////var APItype = _APIResultTypeService.Add(new APIResultType()
                ////{
                ////    APIName = "Anomaly",
                ////    Description = "Detects out of the ordinary things",
                ////    Name = "Anomaly"
                ////});
                //var footage = _FootageStorageService.Add(new FootageStorage()
                //{
                //    APIResultTypeId = Guid.Parse("19FCC874-77CB-4B41-2BD1-08D5B31651E5"),
                //    FileName = "test2",
                //    RegisteredDeviceId = device.IdRegisteredDevice,
                //    TriggerConfidencePercent = 60
                //});
            }
            catch(Exception ex)
            {

            }




            return Json(true);
        }

    }
}
