using CQRS_Mediator.Library.Models;
using System.Collections.Generic;

namespace CQRS_Mediator.Library.DataAccess
{
    public interface IDataAccess
    {
        List<Student> GetStudents();
        Student AddStudent(string firstName, string lastName, double age);
        Student GetStudentById(int id);
    }
}