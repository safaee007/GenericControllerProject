using GenericController.Entities;
using GenericController.Intefaces;

namespace GenericController.Services
{
    public class PersonService : IPersonService
    {
        public Task Delete(Guid uid)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Person model)
        {
            throw new NotImplementedException();
        }

        public Task Add(Person model)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Item(Guid uid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> List()
        {
            throw new NotImplementedException();
        }
    }
}
