using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Employee")]
    public class Employee
    {
        public Employee()
        {
            Id = 0;
            Name = "";
            Code = "";
            Age = 0;
            JoiningDate = DateTime.MinValue;
            Salary = 0;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        public decimal Salary { get; set; }

    }
}
