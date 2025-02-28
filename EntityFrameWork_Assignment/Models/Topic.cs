using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Models
{
    public class Topic
    {
        public int TopicId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(maximumLength: 15)]
        public string? Name { get; set; }


        [InverseProperty("Topic")]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
