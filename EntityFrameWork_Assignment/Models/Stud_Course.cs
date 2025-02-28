using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Stud_Course
    {
        [ForeignKey("Student")]

        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public char Grade { get; set; }

       
        public Student Student { get; set; }

        public Course Course { get; set; }  
    }
}
