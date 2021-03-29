using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsWebapiTrial.Data;
using StudentsWebapiTrial.Models;
using AutoMapper;
using StudentsWebapiTrial.DTOS;
using System.Net.Http;

namespace StudentsWebapiTrial.Controllers
{
    [Route("api/StudentDetail")]
    [ApiController]
    public class StudentDetailController:Controller
    {
        private readonly IStudentDetails _istudentDetails;
        //private readonly IMapper _mapper;

        public StudentDetailController(IStudentDetails istudentDetails )
        {
            _istudentDetails = istudentDetails;

            //_mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<StudentDetails>> GetAllStudent()
        {
            var students = _istudentDetails.GetAllStudents();
            return Ok(students);

        }

        //[HttpGet("{id}")]
        //[Route("api/StudentDetail/id")]
        //[Route("api/StudentDetail/{id?}")]
        //[HttpGet("{id}", Name = "GetStudentbyID")]
        //public ActionResult <StudentReadDTOS> GetStudentbyID(int SID)
        //{
        //    StudentDetails student = _istudentDetails.GetStudentByID(SID);
        //    return Ok(_mapper.Map<StudentReadDTOS>(student));
        //}

        [HttpGet("{id}", Name = "GetStudentbyID")]
        public ActionResult<StudentDetails> GetStudentbyID(int SID)
        {
            StudentDetails student = _istudentDetails.GetStudentByID(SID);
            return Ok(student);
        }

       

    }
}
