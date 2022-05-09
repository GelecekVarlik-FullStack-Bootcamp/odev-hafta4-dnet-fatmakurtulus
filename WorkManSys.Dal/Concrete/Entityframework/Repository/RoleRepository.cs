using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Dal.Abstract;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Concrete.Entityframework.Repository
{
    public class RoleRepository :GenericRepository<Role>,IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
                
        }

        public void AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public void DeleteRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Role GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> ListAllRole()
        {
            throw new NotImplementedException();
        }

        public void UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
