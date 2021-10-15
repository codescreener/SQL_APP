using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Applications.Models
{
    public class Emp_Dept
    {

        [Key]
        public int ID { get; set; }
        [ForeignKey("Employee")]
        public int EmpID { get; set; }
        public virtual Employee Employee { get; private set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public virtual Department Department { get; private set; }


        public Emp_Dept()
        {

        }
    }
}
