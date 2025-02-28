using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Course_Inst
    {
        [ForeignKey("Course")]
        public int CourseId { get; set; } 

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; } 

        [MaxLength(1)]
        public char Evaluate { get; set; }

        public Course Course { get; set; }

        public Instructor Instructor { get; set; }
    }

}
