using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Entities;
using WebApplication.ViewModels;

namespace WebApplication.Data
{
    public class WebAppMappingProfile : Profile
    {
        public WebAppMappingProfile()
        {
            CreateMap<Car, CarViewModel>().ReverseMap();
        }
    }
}
