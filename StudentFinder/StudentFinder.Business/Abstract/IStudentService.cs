using StudentFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinder.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAllStudent();
        Student GetStudentById(int id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
