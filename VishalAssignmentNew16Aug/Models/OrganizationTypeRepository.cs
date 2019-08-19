using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class OrganizationTypeRepository : IOrganizationTypeRepository
    {

        private readonly AppDbContext _appDbContext;
        public OrganizationTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<OrganizationType> GetAllOrganizationTypes()
        {
            return _appDbContext.OrganizationTypes.Where(x => x.Id != 1);
        }

        public OrganizationType GetOrganizationTypeById(int OrganizationTypeId)
        {
            return _appDbContext.OrganizationTypes.FirstOrDefault(x => x.Id == OrganizationTypeId);

        }
    }
}
