using GenericController.Controllers;
using GenericController.Entities;
using GenericController.Intefaces;

namespace GenericControllerProject.Controllers
{
    public class CourseController : GenericController<Course, ICourseService>
    {
        public CourseController(ICourseService courseService) : base(courseService)
        {

        }
    }
}
