using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodbaseEvaluation.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmpDept { get; set; }
        [Required]
        public string EmpName { get; set; }
        public string Gender { get; set; }
 
        public string Location { get; set; }
    }
}
