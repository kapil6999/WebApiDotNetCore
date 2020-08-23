using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudenst();
        Student GetStudentById(int Id);
        void AddStudent(Student model);
        void DeleteStudent(int Id);
        void UpdateStudent(Student model);
    }
}
