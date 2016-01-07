using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IEmployee
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }

    public class Employee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
