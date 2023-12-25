using GenericController.Entities;
using GenericController.Intefaces;
using GenericControllerProject.Enums;

namespace GenericController.Services
{
    public class CourseService : ICourseService
    {
        public async Task<(SharedVariables.ApiResultStatusCode, List<Course>)> List()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course
            {
                UID = Guid.NewGuid(),
                Title = "Programing 1",
                Author = "Saeed Safaee",
                Description = "Description",
            });
            courses.Add(new Course
            {
                UID = Guid.NewGuid(),
                Title = "Programing 2",
                Author = "Saeed Safaee",
                Description = "Description",
            });

            return (SharedVariables.ApiResultStatusCode.Success, courses);
        }

        public async Task<(SharedVariables.ApiResultStatusCode, Course)> Item(Guid uid)
        {
            Course course = new Course();

            course.UID = Guid.NewGuid();
            course.Title = "Programing 1";
            course.Author = "Saeed Safaee";
            course.Description = "Description";

            return (SharedVariables.ApiResultStatusCode.Success, course);
        }

        public async Task<SharedVariables.ApiResultStatusCode> Add(Course model)
        {
            throw new NotImplementedException();
        }

        public async Task<SharedVariables.ApiResultStatusCode> Edit(Course model)
        {
            throw new NotImplementedException();
        }

        public async Task<SharedVariables.ApiResultStatusCode> Delete(Guid uid)
        {
            throw new NotImplementedException();
        }
    }
}
