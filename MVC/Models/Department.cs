using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; // we need this to use the Table attributes

namespace MVC.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } // we need this so we can retrieve the employees linked to a Department
    }
}