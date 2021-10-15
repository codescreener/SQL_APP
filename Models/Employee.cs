using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Applications.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EmpName { get; set; }
        public virtual List<Emp_Dept> Emp_Depts { get; set; } = new List<Emp_Dept>();

    }
}
