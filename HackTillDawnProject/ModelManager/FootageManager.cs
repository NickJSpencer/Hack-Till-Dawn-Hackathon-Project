using HackTillDawnProject.Models;
using HackTillDawnProject.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.ModelManager
{
    public class FootageManager
    {
        private IFootageStorageService _FootageStorageService { get; }
        private IRegisteredDeviceService _RegisteredDeviceService { get; }
        public FootageManager(IFootageStorageService ifss, IRegisteredDeviceService irds)
        {
            _FootageStorageService = ifss;
            _RegisteredDeviceService = irds;
        }
        
        public bool SaveVideoPartial(MemoryStream FilePartial, string DeviceIdName, DateTime CaptureStart, bool IsFinished = false, DateTime? CaptureFinish = null)
        {
            //Will append this stream to the end of the other file
            RegisteredDevice Camera = _RegisteredDeviceService.GetDeviceByName(DeviceIdName);
            var footage = _FootageStorageService.GetFootage(Camera.IdRegisteredDevice, CaptureStart);
            return false;
        }
        public bool SaveVideo(MemoryStream FilePartial, string DeviceIdName, DateTime CaptureStart, DateTime CaptureEnd)
        {
            //Save Video To Footage (new)

            return false;
        }

        


    }
}
