using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EFCoreCodeFirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public string City { get; set; }

        public int Age { get; set; }
    }
}
