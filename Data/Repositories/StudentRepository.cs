using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        APITestDbContext dbcontext = new APITestDbContext();
        public void AddStudent(Student model)
        {
            dbcontext.Student.Add(model);
            dbcontext.SaveChanges();          
        }

        public void DeleteStudent(int Id)
        {
            var model = GetStudentById(Id);
            dbcontext.Student.Remove(model);
            dbcontext.SaveChanges();
        }

        public List<Student> GetAllStudenst()
        {            
            var StudentList = dbcontext.Student.ToList();          
            return StudentList;
        }

        public Student GetStudentById(int Id)
        {
            var student = dbcontext.Student.Where(x => x.Id == Id).FirstOrDefault();
            return student;
        }

        public void UpdateStudent(Student model)
        {
            var data = dbcontext.Student.Where(x => x.Id == model.Id).FirstOrDefault();
            data.Name = model.Name;
            data.EmailAdd = model.EmailAdd;
            data.Age = model.Age;
            data.Gender = model.Gender;
            data.ContactNumber = model.ContactNumber;
            dbcontext.SaveChanges();           
        }
    }
}
