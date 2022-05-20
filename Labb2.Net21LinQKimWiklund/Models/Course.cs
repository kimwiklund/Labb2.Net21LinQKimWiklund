﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2.Net21LinQKimWiklund.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        
        //[ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        //public Teacher Teachers { get; set; }
        public ICollection<SchoolClassCourse> SchoolClassCourses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        
    }
}
