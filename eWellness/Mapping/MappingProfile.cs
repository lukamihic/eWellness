using AutoMapper;
using eWellness.Core.Common.Models;
using eWellness.Core.Models;

namespace eWellness.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, IUser>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<ActivityLog, IActivityLog>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Client, IClient>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Employee, IEmployee>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Appointment, IAppointment>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Invoice, IInvoice>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Payment, IPayment>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<PaymentMethod, IPaymentMethod>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<Service, IService>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<ServiceCategory, IServiceCategory>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
            CreateMap<SpecialOffer, ISpecialOffer>().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();
        }
    }
}
