using GenericController.Entities;
using GenericController.Intefaces;
using GenericControllerProject.Enums;

namespace GenericController.Services
{
    public class PersonService : IPersonService
    {
        public async Task<(SharedVariables.ApiResultStatusCode, List<Person>)> List()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person
            {
                UID = Guid.NewGuid(),
                Age = 1,
                Name = "Saeed Safaee",
            });
            people.Add(new Person
            {
                UID = Guid.NewGuid(),
                Age = 1,
                Name = "SaeedSafaee2",
            });

            return (SharedVariables.ApiResultStatusCode.Success, people);
        }

        public async Task<(SharedVariables.ApiResultStatusCode, Person)> Item(Guid uid)
        {
            Person person = new Person();

            person.UID = Guid.NewGuid();
            person.Age = 1;
            person.Name = "Saeed Safaee";

            return (SharedVariables.ApiResultStatusCode.Success, person);
        }

        public async Task<SharedVariables.ApiResultStatusCode> Add(Person model)
        {
            return SharedVariables.ApiResultStatusCode.Success;
        }

        public async Task<SharedVariables.ApiResultStatusCode> Edit(Person model)
        {
            return SharedVariables.ApiResultStatusCode.Success;
        }

        public async Task<SharedVariables.ApiResultStatusCode> Delete(Guid uid)
        {
            return SharedVariables.ApiResultStatusCode.Success;
        }
    }
}
