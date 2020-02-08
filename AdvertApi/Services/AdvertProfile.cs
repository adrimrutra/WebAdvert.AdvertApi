using AdvertApi.Models;
using AutoMapper;
using WebAdvert.Models;

namespace AdvertApi.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile ()
        {
            CreateMap<AdvertModel, AdvertDbModel>();
        }
    }
}
