using AutoMapper;
using GenericController.Controllers;
using GenericController.Entities;
using GenericController.Intefaces;
using GenericControllerProject.DTOs;

namespace GenericControllerProject.Controllers
{
    public class CourseController : GenericController<Course, ICourseService, PersonDTO>
    {
        public CourseController(ICourseService courseService, IMapper mapper) : base(courseService, mapper)
        {

        }
    }
}
