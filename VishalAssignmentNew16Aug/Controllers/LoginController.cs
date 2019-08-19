using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentVishalNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly AppDbContext _appDbContext;
        public LoginController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }




        [HttpPost("[action]")]
        public UserLogin DoLogin([FromBody] UserLogin userLogin)
        {
            try
            {

                var user = _appDbContext.UserLogins.FirstOrDefault(l => l.UserName == userLogin.UserName && l.Password == userLogin.Password && l.IsDeleted == false);
                if (user != null)
                {
                    //var roleId = _appDbContext.OrganizationRoleUser.FirstOrDefault(o => o.UserId == user.Id).RoleId;
                    //var roleName = _appDbContext.Roles.FirstOrDefault(r => r.Id == roleId).Name;
                    //return Ok(roleName);
                    return user;
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
}