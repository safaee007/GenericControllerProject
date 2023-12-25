using GenericController.Entities;
using GenericController.Intefaces;

namespace GenericController.Services
{
    public class PersonService : IPersonService
    {
        public async Task<List<Person>> List()
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

            return people;
        }

        public async Task<Person> Item(Guid uid)
        {
            return new Person
            {
                UID = Guid.NewGuid(),
                Age = 1,
                Name = "Saeed Safaee",
            };
        }

        public async Task Add(Person model)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(Person model)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid uid)
        {
            throw new NotImplementedException();
        }
    }
}
