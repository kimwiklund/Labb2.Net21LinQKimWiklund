using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2.Net21LinQKimWiklund.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [ForeignKey("SchoolClasses")]
        public int fkSchoolClassId { get; set; }
        public int fkStudentTeacherId { get; set; }
        public SchoolClass SchoolClasses { get; set; }
    }

}

