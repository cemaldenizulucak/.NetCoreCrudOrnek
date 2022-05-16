using StudentFinder.DataAccess.Abstract;
using StudentFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinder.DataAccess.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        public Student CreateStudent(Student student)
        {
            using(var studentDbContext = new StudentDbContext())
            {
                studentDbContext.students.Add(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }

        public void DeleteStudent(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                var deleteStudent = GetStudentById(id);
                studentDbContext.students.Remove(deleteStudent);
                studentDbContext.SaveChanges();
               
            }
        }

        public List<Student> GetAllStudent()
        {
            using (var studentDbContext = new StudentDbContext())
            {
                return studentDbContext.students.ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                return studentDbContext.students.Find(id);
            }
        }

        public Student UpdateStudent(Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                studentDbContext.students.Update(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }
    }
}
