using Microsoft.AspNetCore.Mvc;
using Applications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Applications.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Applications.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly CandidateDbContext _context;
        public ApplicationController(CandidateDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {       
            List<Employee> Employees;
            Employees = _context.Employees.ToList();
            return View(Employees);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            Employee employee = new Employee();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            _context.Add(Employee);
            _context.SaveChanges();
            var empID = Employee.EmpID;
            Emp_Dept emp_dept = new Emp_Dept();
            emp_dept.EmpID = empID;
            emp_dept.DeptID = int.Parse(Request.Form["drpdept"]);
            _context.Add(emp_dept);
            _context.SaveChanges();
            return RedirectToAction("Create");

        }
    }
}
