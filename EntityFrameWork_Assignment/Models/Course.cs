using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Course
    {

        public int CourseId { get; set; }  //PK & Identity

        //[Column(TypeName = "time")]
        public TimeSpan? Duration { get; set; }


        [Required(ErrorMessage = "Please Enter the Course Name")]
        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 15)]
        public string Name { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(maximumLength : 50)]
        public string? Description { get; set; }


        [ForeignKey("Topic")]
        public int? TopicId { get; set; }
        [InverseProperty("Courses")]
        public Topic Topic { get; set; }



        public ICollection<Stud_Course> Course_Students { get; set; } = new HashSet<Stud_Course>();


        public ICollection<Course_Inst> Courses_Inst { get; set; } = new HashSet<Course_Inst>();

    }
}
