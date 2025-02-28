using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please Enter the Student Name")]
        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 15)]
        public string FName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 15)]
        public string? LName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(maximumLength:50)]
        public string? Address { get; set; }
        public int? Age { get; set; }
        //public int? DeptId { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        [InverseProperty("Students")]
        public Department Department { get; set; }



        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
