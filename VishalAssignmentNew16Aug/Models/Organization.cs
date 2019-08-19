using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class Organization
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        //[ForeignKey("OrganizationType")]
        public int OrganizationTypeId { get; set; }
        public OrganizationType OrganizationTypes { get; set; }
        public ICollection<OrganizationAddress> OrganizationAddresses { get; set; }
    }
}
