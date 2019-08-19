using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class OrganizationType
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string AliasName { get; set; }
        public ICollection<Organization> Organizations { get; set; }
    }
}
