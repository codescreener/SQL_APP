﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Applications.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string DeptName { get; set; }

        public virtual List<Emp_Dept> Emp_Depts { get; set; } = new List<Emp_Dept>();

    }
}
