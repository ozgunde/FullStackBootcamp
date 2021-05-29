using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroWebApi.Business;
using IntroWebApi.Models;

namespace IntroWebApi.Business
{
    public class EmployeeService
    {
        //Bir yerlerden (mesela db) veriyi alacak olan sınıf
        public List<EmployeesListResponseDTO> GetListResponseDTOs()
        {
            EmployeesRepository repo = new EmployeesRepository();
            var employees = repo.GetStaffs();



            List<EmployeesListResponseDTO> dtolists = new List<EmployeesListResponseDTO>();
            foreach (var employee in employees)
            {
                var dto = new EmployeesListResponseDTO
                {
                    Age = employee.Age,
                    Name = employee.Name,
                    NationalId = employee.id,
                    Salary = employee.Salary,
                    Salary_Increase = employee.Salary_Increase,
                    Surname = employee.Surname
                };
                dtolists.Add(dto);
            }
            return dtolists;
        }
        public Staff GetStaffResponseIDTO(int id)
        {
            EmployeesRepository repo = new EmployeesRepository();
            var employees = repo.GetStaffs();
            return employees.FirstOrDefault(e => e.id == id);
        }
    }
}

