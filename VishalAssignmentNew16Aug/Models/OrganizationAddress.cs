using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class OrganizationAddress
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int OrganizationId { get; set; }
        public Organization Organizations { get; set; }
        [Required]
        public int AddressId { get; set; }
        public Address Addresses { get; set; }

    }
}
