using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }
        public ICollection<PersonAddress> PersonAddresses { get; set; }

    }
}
