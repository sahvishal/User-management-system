using System.Collections.Generic;

namespace AssignmentProject.Models
{
    public interface IOrganizationTypeRepository
    {
        IEnumerable<OrganizationType> GetAllOrganizationTypes();
        OrganizationType GetOrganizationTypeById(int OrganizationTypeId);

    }
}