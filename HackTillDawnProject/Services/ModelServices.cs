using HackTillDawnProject.Data;
using HackTillDawnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    }
    public class FootageStorageService : BasicModelServiceImplementation<FootageStorage>, IFootageStorageService
    {
        public FootageStorageService(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }

    public interface IRegisteredDeviceService : IBasicModelService<RegisteredDevice>
    {
       
    }
    public class RegisteredDeviceService : BasicModelServiceImplementation<RegisteredDevice>, IRegisteredDeviceService
    {
        public RegisteredDeviceService(ApplicationDbContext ctx) : base(ctx)
        {

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
