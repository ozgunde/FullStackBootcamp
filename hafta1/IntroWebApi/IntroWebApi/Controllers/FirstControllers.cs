using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroWebApi.Models;
using IntroWebApi.Business;

namespace IntroWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase //İnternet sitesine girdiğinde api/ozgun yani api/controller yazmalısın
    {
        //Buraya requestler gelecek.
        // GET - POST - DELETE - PUT
        [HttpGet] // Attribute : Fonksiyon katıyor, yönlendirme işlemi
        public IActionResult AllEmployees() // Method'un adı önemli değil, istediğimizi verebiliriz.String yerine List methodunu kullandık.
        {
            EmployeeService dataservice = new EmployeeService();
            var list = dataservice.GetListResponseDTOs();
            return Ok(list);
        }
        [HttpGet("{NationalId}")]
        public IActionResult GetStaffResponseByID(int NationalId)
        {
            EmployeeService dataservice = new EmployeeService();
            var employeelist = dataservice.GetStaffResponseIDTO(NationalId);
            if (employeelist == null)
            {
                return NotFound();
            }
            return Ok(employeelist);
        }

        [HttpPost]
        public IActionResult AddEmployee(Staff staff)
        {
            // varsayın ki db'ye ekledik
            return CreatedAtAction(nameof(GetStaffResponseByID), new { id = 3 }, null);
        }
    }
}

//"İşlem Başarılı";// İstemciye dönen mesaj
// object initializer
// CTRL + K + D Alt alta almak için
// Bunu çalıştırdığımızda ISS üzerinden veriler JSon olarak geldi. 
// Framerwork ne işe yarar sorusunun cevabı çünkü .Net Core karar verdi. Json'a "serialize" etti.
// Ortak dile çeviriyor Json, eskiden XML. (Angular, React, IOS) API'nın ne ile yazıldığı önemli değil, ortak bir dilde konuşuyorlar. 
// Restful bir servis yani global api yazıyorsak HTTP response'larına dikkat edilmeli.
// Controller içerisinde response dönen her mesaj action.
// Ürünlerin tipi aynı ama çıktısını değiştirdik OK ( Iactionresult)
