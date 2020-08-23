using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using Service.Models;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentservice _istudentservice;
        private readonly IMapper _mapper;
        public StudentController(IStudentservice Studentservice, IMapper mapper)
        {
            _istudentservice = Studentservice;
            _mapper = mapper;
        }

        // GET: api/Student
        [HttpGet]
        [Route("GetAllStudents")]
        public ActionResult GetAllStudent()
        {

            try
            {
                var studentList = _istudentservice.GetAllStudenst();
                return Ok(studentList);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // GET: api/Student/5
        [HttpGet]
        [Route("GetStudent/{id}")]
        public ActionResult GetStudent(int id)
        {
            if (id > 0)
            {
                var data = _istudentservice.GetStudentById(id);
                if (data != null)
                    return Ok(data);
                else
                    return NotFound();
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("AddStudent")]
        public ActionResult AddStudent([FromBody] AddStudentModel studentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map<AddStudentModel, StudentModel>(studentModel);
            _istudentservice.AddStudent(model);
            return Ok("Success");
        }

        [HttpPatch]
        [Route("UpdateStudent")]
        public ActionResult UpdateStudent([FromBody] AddStudentModel studentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(studentModel.Id >0)
            {
                var model = _mapper.Map<AddStudentModel, StudentModel>(studentModel);
                _istudentservice.UpdateStudent(model);
                return Ok("Success");
            }
            return BadRequest();


        }


        [HttpDelete]
        //[Route("accounts")]
        [Route("DeleteStudent/{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            if (studentId > 0)
            {
                _istudentservice.DeleteStudent(studentId);
                return Ok("Success");
            }
            return BadRequest();
        }
    }
}