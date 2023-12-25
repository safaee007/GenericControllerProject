using GenericController.Entities;
using GenericController.Intefaces;

namespace GenericController.Services
{
    public class CourseService : ICourseService
    {
        public async Task<List<Course>> List()
        {
            List<Course> people = new List<Course>();
            people.Add(new Course
            {
                UID = Guid.NewGuid(),
                Title = "Programing 1",
                Author = "Saeed Safaee",
                Description = "Description",
            });
            people.Add(new Course
            {
                UID = Guid.NewGuid(),
                Title = "Programing 2",
                Author = "Saeed Safaee",
                Description = "Description",
            });

            return people;
        }

        public async Task<Course> Item(Guid uid)
        {
            return new Course
            {
                UID = Guid.NewGuid(),
                Title = "Programing 1",
                Author = "Saeed Safaee",
                Description = "Description"
            };
        }

        public async Task Add(Course model)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(Course model)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid uid)
        {
            throw new NotImplementedException();
        }
    }
}
