using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebApi.Models
{
    public class EmployeesListResponseDTO
    {
        public int NationalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public float Salary_Increase { get; set; }
    }
}
