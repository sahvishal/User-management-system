using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public ICollection<OrganizationAddress> OrganizationAddress { get; set; }
        public ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
