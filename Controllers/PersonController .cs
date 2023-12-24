using GenericController.Controllers;
using GenericController.Entities;
using GenericController.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace GenericControllerProject.Controllers
{
    public class PersonController : GenericController<Person, IPersonService>
    {
        public PersonController(IPersonService personService) : base(personService)
        {

        }
    }
}
