using HackTillDawnProject.Models;
using HackTillDawnProject.Models.JsonModels;
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
        private IContactService _ContactService;
        public NotificationController(IFootageStorageService ifss, IContactService ics)
        {
            _FootageStorageService = ifss;
            _ContactService = ics;
        }

        public JsonResult GetNotifications(string channel_id)
        {
            Guid channel_guid;
            if(Guid.TryParse(channel_id, out channel_guid))
            {
                List<FootageStorage> storages = _FootageStorageService.GetAllForChannel(channel_guid);
                List<NotificationJson> notifications = new List<NotificationJson>();
                foreach (FootageStorage storage in storages)
                {
                    NotificationJson notification = new NotificationJson
                    {
                        IdFootageStorage = storage.IdFootageStorage.ToString(),
                        DateTimeCaptureStartUtc = storage.DateTimeCaptureStartUtc,
                        DateTimeCaptureEndUtc = storage.DateTimeCaptureEndUtc,
                        Tags = storage.Tags,
                        TriggerDescription = storage.TriggerDescription,
                        TriggerConfidencePercent = storage.TriggerConfidencePercent,
                        FileLocation = storage.FileLocation,
                        FileName = storage.FileName,

                        //APIResultTypeName = storage.APIResultType.Name,

                        DeviceName = storage.FileName,

                        is_read = storage.IsReviewed,
                    };
                    notifications.Add(notification);
                }

                return Json(notifications);
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

        public JsonResult GetAllContacts()
        {
            List<ContactJson> contactsJson = new List<ContactJson>();
            List<Contact> contacts = _ContactService.GetAll();

            foreach(Contact contact in contacts)
            {
                ContactJson contactJson = new ContactJson
                {
                    id = contact.IdContact.ToString(),
                    name = contact.Name,
                    role = contact.Role,
                    phoneNumber = contact.PhoneNumber,
                    comChannel = contact.ComChannel,
                };
                contactsJson.Add(contactJson);
            }

            return Json(contactsJson);
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
