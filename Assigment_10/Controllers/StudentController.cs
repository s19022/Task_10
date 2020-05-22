using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assigment_10.DTOs.Request;
using Assigment_10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment_10.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public MyContext Context { get; set; }

        public StudentController()
        {
            Context = new MyContext();
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(Context.Student.ToList());
        }

        [HttpPut]
        public IActionResult AddStudent()
        {
            return BadRequest();
        }

        [HttpPost]
        public IActionResult ModifyStudent(AddStudentRequest request)
        {

        }


    }
}