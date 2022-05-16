using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentFinder.Business.Abstract;
using StudentFinder.Business.Concrete;
using StudentFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentManager();
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.GetAllStudent();
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {

            return _studentService.GetStudentById(id);

        }
        [HttpPost]
        public Student Post([FromBody] Student student)
        {
            return _studentService.CreateStudent(student);
        }
        [HttpPut]
        public Student Put([FromBody] Student student)
        {
            return _studentService.UpdateStudent(student);
        }

        public void Delete(int id)
        {
            _studentService.DeleteStudent(id);
        }

    }
}
