﻿using GenericController.Controllers;
using GenericController.Entities;
using GenericController.Intefaces;

namespace GenericControllerProject.Controllers
{
    public class PersonController : GenericController<Person, IPersonService>
    {
        public PersonController(IPersonService personService) : base(personService)
        {

        }
    }
}
