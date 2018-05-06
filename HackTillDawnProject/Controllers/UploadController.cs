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
using Twilio;
using Twilio.Converters;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

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

        public JsonResult AddContact()
        {
            var contact = _ContactService.Add(new Contact()
            {
                IdContact = Guid.NewGuid(),
                Name = "Mitch Marsh",
                Role = "Security",
                PhoneNumber = "555-982-5696",
                ComChannel = 5
            });
            contact = _ContactService.Add(new Contact()
            {
                IdContact = Guid.NewGuid(),
                Name = "Nick Spencer",
                Role = "Medical",
                PhoneNumber = "555-982-4876",
                ComChannel = 4
            });
            contact = _ContactService.Add(new Contact()
            {
                IdContact = Guid.NewGuid(),
                Name = "Collin O'Shagnasty",
                Role = "Medical",
                PhoneNumber = "555-982-4626",
                ComChannel = 4
            });
            return Json(true);
        }

        public async Task<JsonResult> SendSMSMessageAsync()
        {
            // Your Account SID from twilio.com/console
            var accountSid = "ACe41c624d47a1d067094dc7d5ec6849ec";
            // Your Auth Token from twilio.com/console
            var authToken = "0a922556ca8b1a7d0a85bec7aa971447";

            TwilioClient.Init(accountSid, authToken);
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "symbol.png");

            var uri = new Uri(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "symbol.png"));
            var message = await MessageResource.CreateAsync(
                to: new PhoneNumber("+18057056133"),
                from: new PhoneNumber("+18053086371"),
                body: "Sending an image",
                mediaUrl: Promoter.ListOfOne((uri))); 


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
