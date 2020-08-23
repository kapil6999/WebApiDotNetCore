using AutoMapper;
using Data.Models;
using Data.Repositories;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public class Studentservice : IStudentservice
    {
        private readonly IStudentRepository _StudentRepository;
        private readonly IMapper _mapper;

        public Studentservice(IStudentRepository StudentRepository, IMapper Mapper)
        {
            _StudentRepository = StudentRepository;
            _mapper = Mapper;
        }
        public void AddStudent(StudentModel model)
        {
            var student = _mapper.Map<StudentModel, Student>(model);
            _StudentRepository.AddStudent(student);
        }

        public void DeleteStudent(int Id)
        {
            _StudentRepository.DeleteStudent(Id);
        }

        public List<StudentModel> GetAllStudenst()
        {
            var studentlist = _StudentRepository.GetAllStudenst();
            return _mapper.Map<List<Student>, List<StudentModel>>(studentlist);
        }

        public StudentModel GetStudentById(int Id)
        {
            var student = _StudentRepository.GetStudentById(Id);
            return _mapper.Map<Student, StudentModel>(student);
        }

        public void UpdateStudent(StudentModel model)
        {
            var student = _mapper.Map<StudentModel, Student>(model);
            _StudentRepository.UpdateStudent(student);
        }
    }
}
