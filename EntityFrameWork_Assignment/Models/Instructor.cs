using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 15)]
        public string? Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Bonus { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? HourRate { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 50)]
        public string? Address { get;  set; }

        [ForeignKey("Department")]
        public int? DepartmentId {  get; set; }

        [InverseProperty("Instructors")]
        public Department? Department { get; set; }



        [InverseProperty("InstructorManage")]
        public Department? DepartmentManage { get; set; }

        public ICollection<Course_Inst> Instructors_Courses { get; set; } = new HashSet<Course_Inst>();
    }
}
