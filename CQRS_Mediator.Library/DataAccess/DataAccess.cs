using CQRS_Mediator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<Student> student = new List<Student>();

        public DataAccess()
        {
            student.Add(new Student { Id = 1, FirstName = "Jhon", LastName = "Doe", Age = 18});
            student.Add(new Student { Id = 2, FirstName = "Amelia", LastName = "Amy", Age = 16 });
        }

        public Student GetStudentById(int id)
        {
            var stu = student.Where(t => t.Id == id).FirstOrDefault();
            return stu;
        }

        public List<Student> GetStudents()
        {
            return student;
        }

        public Student AddStudent(string firstName, string lastName, double age)
        {
            Student s = new Student();
            s.FirstName = firstName;
            s.LastName = lastName;
            s.Age = age;
            s.Id = student.Count() + 1;
            student.Add(s);
            return s;
        }
    }
}
