using StudentFinder.Business.Abstract;
using StudentFinder.DataAccess.Abstract;
using StudentFinder.DataAccess.Concrete;
using StudentFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinder.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentManager()
        {
            _studentRepository = new StudentRepository();
        }
        public Student CreateStudent(Student student)
        {
            return _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetStudentById(int id)
        {
            if (id > 0)
            {
                return _studentRepository.GetStudentById(id);
            }
            throw new Exception("id sıfırdan küçük olamaz");
        }

        public Student UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }
    }
}
