using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroWebApi.Models;


namespace IntroWebApi.Business
{
    public class EmployeesRepository
    {
        public List<Staff> GetStaffs()
        {
            List<Staff> employees = new List<Staff>()
            {
                new Staff
                {
                    id = 2,
                    Name = "Büşra",
                    Surname = "Altun",
                    Age = 24,
                    Salary = 10000,
                    Salary_Increase = 0.20f,
                    Entrance_Date = new DateTime(2020,4,1)
                },
                new Staff
                {
                    id = 3,
                    Name = "Turhan",
                    Surname = "Sel",
                    Age = 23,
                    Salary = 12000,
                    Salary_Increase = 0.24f,
                    Entrance_Date = new DateTime(2021,1,3)
                }
            };
            employees.Add(new Staff
            {
                id = 1,
                Name = "Özgün",
                Surname = "Demirel",
                Age = 25,
                Salary = 8000.50M,
                Salary_Increase = 0.15f,
                Entrance_Date = new DateTime(2020, 8, 11)
            });

            return (employees);
        }
    }
}
