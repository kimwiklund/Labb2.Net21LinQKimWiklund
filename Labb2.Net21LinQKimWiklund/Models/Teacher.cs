using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2.Net21LinQKimWiklund.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }

        //public ICollection<Course> Courses { get; set; }

        [ForeignKey("Courses")]
        public int fkCourseId { get; set; }
        public Course Courses { get; set; }

    }
}
