using AutoMapper;
using GenericController.Entities;
using GenericControllerProject.DTOs;

namespace GenericControllerProject.Configurations
{
    public class AutoMaggerProfile: Profile
    {
        public AutoMaggerProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
        }
    }
}
