using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Department
    {
        [ForeignKey("Instructor")]
        public int? InsructorId { get; set; }    
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }


        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; }=new HashSet<Instructor>();



        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();


        [ForeignKey("InstructorId")]
        public Instructor? InstructorManage { get; set; }

    }
}
