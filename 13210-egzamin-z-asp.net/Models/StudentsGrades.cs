using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13210_egzamin_z_asp.net.Models
{
    public class StudentsGrades
    {
        [Required]
        public int StudentsIndex { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Grade musi byc miedzy 1 a 5")]
        public decimal Grade { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
