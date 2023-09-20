﻿using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string? Department { get; set; }

        public int IsActive { get; set; }
    }
}
