using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
   public interface IStudentservice
    {
        List<StudentModel> GetAllStudenst();
        StudentModel GetStudentById(int Id);
        void AddStudent(StudentModel model);
        void DeleteStudent(int Id);
        void UpdateStudent(StudentModel model);
    }
}
