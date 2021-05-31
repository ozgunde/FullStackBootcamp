using ApiOverView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ApiOverView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //1. Tüm Öğrencileri Döndürür.

        
            List<Student> students = new List<Student>
            {
                new Student { Id=1, Name="Özgün", LastName="Demirel", Address = "Kartal" },
                new Student { Id=2, Name="Aydın", LastName="As", Address = "Nilüfer" },
                new Student { Id=3, Name="Olcay", LastName="Arpaç", Address = "Merkezefendi" }
            };

        [HttpGet]
        public IActionResult GetStudents() //Controllerın actionı GetStudents()
        {
            return Ok(students);
        }
        
        [HttpGet("{ogrID:int}")]

        public IActionResult GetStudent(int ogrID)
        {
            var student = students.FirstOrDefault(stu => stu.Id == ogrID);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}
