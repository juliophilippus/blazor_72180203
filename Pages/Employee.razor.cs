using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set;}

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId = 1,
                FirstName = "Julio",
                LastName = "Philippus",
                Email = "julio@gmail.com",
                DateOfBirth = new DateTime(2000,7,25),
                Gender = Gender.Male,
                Department= new Department{DepartmentId = 1, DepartmentName = "IT"},
                PhotoPath = "images/julio.jpg"
            };

            Employee e2 = new Employee{
                EmployeeId = 2,
                FirstName = "Dania",
                LastName = "Yosepha",
                Email = "dania@gmail.com",
                DateOfBirth = new DateTime(1996,10,28),
                Gender = Gender.Female,
                Department= new Department{DepartmentId = 2, DepartmentName = "HR"},
                PhotoPath = "images/dania.jpg"
            };

            Employee e3 = new Employee{
                EmployeeId = 3,
                FirstName = "Guntur",
                LastName = "Bayu",
                Email = "bayu@gmail.com",
                DateOfBirth = new DateTime(2001,7,28),
                Gender = Gender.Male,
                Department= new Department{DepartmentId = 1, DepartmentName = "IT"},
                PhotoPath = "images/bayu.jpg"
            };

            Employee e4 = new Employee{
                EmployeeId = 4,
                FirstName = "Gebian",
                LastName = "Star",
                Email = "yeyen@gmail.com",
                DateOfBirth = new DateTime(2000,4,10),
                Gender = Gender.Female,
                Department= new Department{DepartmentId = 3, DepartmentName = "Business"},
                PhotoPath = "images/gebian.jpg"
            };

            Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }
}