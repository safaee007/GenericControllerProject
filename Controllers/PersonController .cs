using AutoMapper;
using GenericController.Controllers;
using GenericController.Entities;
using GenericController.Intefaces;
using GenericControllerProject.DTOs;

namespace GenericControllerProject.Controllers
{
    public class PersonController : GenericController<Person, IPersonService, PersonDTO>
    {
        public PersonController(IPersonService personService, IMapper mapper) : base(personService, mapper)
        {

        }
    }
}
