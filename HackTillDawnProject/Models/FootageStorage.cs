using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class FootageStorage : DataRowProperty
    {
        public FootageStorage()
        {
        }
        //PK
        public Guid IdFootageStorage { get; set; }
        //
        public DateTime DateTimeCaptureStartUtc { get; set; }
        public DateTime DateTimeCaptureEndUtc { get; set; }
        public string Tags { get; set; }
        public string TriggerDescription { get; set; }
        public decimal TriggerConfidencePercent { get; set; }
        public string FileLocation { get; set; }
        public string FileName { get; set; }

        public RegisteredDevice RegisteredDevice { get; set; }
        public Guid RegisteredDeviceId { get; set; }

        public APIResultType APIResultType { get; set; }
        public Guid APIResultTypeId { get; set; }

    }
}
