using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebApi.Models
{
    public class Staff
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public float Salary_Increase { get; set; }

        // Aşağıdakiler daha fazla ayrıntı ya da kullanıcının görmesine gerek olmayan bilgiler olabilir
        public List<String> Division { get; set; }
        public List<String> Division_Unit { get; set; }
        public DateTime Entrance_Date { get; set; }
        public DateTime Updated_Time { get; set; }

    }
}
