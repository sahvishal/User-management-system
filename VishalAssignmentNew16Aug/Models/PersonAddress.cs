using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class PersonAddress
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        public Person Persons { get; set; }
        [Required]
        public int AddressId { get; set; }
        public Address Addresses { get; set; }
        public bool IsDeleted { get; set; }
    }
}
