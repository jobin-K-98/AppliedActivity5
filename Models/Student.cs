using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppliedActivity5.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        [ForeignKey(typeof(Course))]
        public int CourseId { get; set; }
    }
}

