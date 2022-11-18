using Microsoft.AspNetCore.Mvc;
using LmsWebAPI.Services;
using LmsWebAPI.Models;

namespace LmsWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LmsController : ControllerBase
    {
        private LmsServie lmsService;

        public LmsController(LmsServie service)
        {
            lmsService = service;
        }

        [HttpGet]
        [Route("GetAllCategories")]
        public IEnumerable<Category> GetAllCategories()
        {
            return lmsService.GetAllCategories();
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return lmsService.GetAllStudents();
        }

        [HttpGet]
        [Route("Courses")]
        public IEnumerable<Course> GetAllCourses()
        {
            return lmsService.GetAllCourses();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return lmsService.GetStudentById(id);
        }

        [HttpGet("Students/{studentId}")]
        public List<Exam> GetGrades(int studentId)
        {
            return lmsService.GetGradesOfStudent(studentId);
        }


        [HttpPut]
        public void AddStudent(Student student)
        {
            lmsService.AddStudent(student);
        }

        [HttpDelete]
        public void DeleteStudentById(int id)
        {
            lmsService.DeleteStudentById(id);
        }
        
    }
}
