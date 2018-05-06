using HackTillDawnProject.ModelManager;
using HackTillDawnProject.Models;
using HackTillDawnProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        private FootageManager _FootageManager { get; }
        public UploadController(FootageManager fm,
            IFootageStorageService ifss,
            IRegisteredDeviceService irds,
            IAPIResultTypeService iapits,
            IDeviceEventIntermediateService ideis,
            IEventService ies,
            IChannelContactService iccs,
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
            _ChannelContactService = iccs;
            _ChannelService = ics;
            _StaffEventIntermediateService = iseis;
            _ContactService = icos;


        }

        public JsonResult UploadNotificationFootage(IFormFile video)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            try
            {
                //var device = _RegisteredDeviceService.Add(new RegisteredDevice()
                //{
                //    DateRegistered = DateTime.UtcNow,
                //    DeviceIdName = "Test1",
                //    RegisteredById = "c748fbb9-3960-408c-9c8d-8d117e98994e"
                //});
                //var Event = _EventService.Add(new Models.Event()
                //{
                //    Name = "HackTillDawn",
                //    Description = "AngelHack Event"
                //});
                //var channel = _ChannelService.Add(new Channel()
                //{
                //    Description = "Identify People In Need",
                //    Name = "Health Channel",
                //    EventId = Event.IdEvent
                //});
                //var device_event = _DeviceEventIntermediateService.Add(new DeviceEventIntermediate()
                //{
                //    IdEventId = Event.IdEvent,
                //    IdRegisteredDeviceId = device.IdRegisteredDevice,
                //    DeviceLocation = "Dev Area"
                //});
                //var APItype = _APIResultTypeService.Add(new APIResultType()
                //{
                //    APIName = "Anomaly",
                //    Description = "Detects out of the ordinary things",
                //    Name = "Anomaly"
                //});
                //var footage = _FootageStorageService.Add(new FootageStorage()
                //{
                //    APIResultTypeId = APItype.IdResultType,
                //    FileName = "test",
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
