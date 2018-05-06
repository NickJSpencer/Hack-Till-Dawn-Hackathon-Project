using HackTillDawnProject.Data;
using HackTillDawnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HackTillDawnProject.Services
{
    public interface IAPIResultTypeService : IBasicModelService<APIResultType>
    {

    }
    public class APIResultTypeService : BasicModelServiceImplementation<APIResultType>, IAPIResultTypeService
    {
        public APIResultTypeService(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }

    public interface IChannelContactService : IBasicModelService<ChannelContactIntermediate>
    {

    }
    public class ChannelContactService : BasicModelServiceImplementation<ChannelContactIntermediate>, IChannelContactService
    {
        public ChannelContactService(ApplicationDbContext ctx) :base(ctx)
        {

        }
    }

    public interface IChannelService : IBasicModelService<Channel>
    {

    }
    public class ChannelService : BasicModelServiceImplementation<Channel>, IChannelService
    {
        public ChannelService(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }

    public interface IContactService : IBasicModelService<Contact>
    {

    }
    public class ContactService : BasicModelServiceImplementation<Contact>, IContactService
    {
        public ContactService(ApplicationDbContext ctx) : base(ctx)
        {
                
        }
    }

    public interface IDeviceEventIntermediateService : IBasicModelService<DeviceEventIntermediate>
    {

    }
    public class DeviceEventIntermediateService : BasicModelServiceImplementation<DeviceEventIntermediate>, IDeviceEventIntermediateService
    {
        public DeviceEventIntermediateService(ApplicationDbContext cyx) : base(cyx)
        {

        }
    }

    public interface IEventService : IBasicModelService<Event>
    {

    }
    public class EventService : BasicModelServiceImplementation<Event>, IEventService
    {
        public EventService(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }

    public interface IFootageStorageService : IBasicModelService<FootageStorage>
    {
        List<FootageStorage> GetAllForChannel(Guid channel_id);
        FootageStorage GetFootage(Guid device_id, DateTime BeginCapturedUtc);
    }
    public class FootageStorageService : BasicModelServiceImplementation<FootageStorage>, IFootageStorageService
    {
        public FootageStorageService(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public List<FootageStorage> GetAllForChannel(Guid channel_id)
        {
            var channel = _context.Channel.FirstOrDefault(e => e.IdChannel == channel_id);
            if (channel == null) return new List<FootageStorage>();
            return _context.DeviceEventIntermediate
                .Include(e => e.RegisteredDevice)
                .ThenInclude(e => e.FootageStored)
                .Where(e => e.IdEventId == channel.EventId)
                .SelectMany(e => e.RegisteredDevice.FootageStored)
                .ToList();

        }

        public FootageStorage GetFootage(Guid device_id, DateTime BeginCapturedUtc)
        {
            return _context.FootageStorage.FirstOrDefault(e => e.RegisteredDeviceId == device_id && e.DateTimeCaptureStartUtc == BeginCapturedUtc);
        }
    }

    public interface IRegisteredDeviceService : IBasicModelService<RegisteredDevice>
    {
        RegisteredDevice GetDeviceByName(string name_id_device);
    }
    public class RegisteredDeviceService : BasicModelServiceImplementation<RegisteredDevice>, IRegisteredDeviceService
    {
        public RegisteredDeviceService(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public RegisteredDevice GetDeviceByName(string name_id_device)
        {
            return _context.RegisteredDevice.FirstOrDefault(e => e.DeviceIdName == name_id_device);
        }
    }

    public interface IStaffEventIntermediateService : IBasicModelService<StaffEventIntermediate>
    { }
    public class StaffEventIntermediateService : BasicModelServiceImplementation<StaffEventIntermediate>, IStaffEventIntermediateService
    {
        public StaffEventIntermediateService(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }
    
}
