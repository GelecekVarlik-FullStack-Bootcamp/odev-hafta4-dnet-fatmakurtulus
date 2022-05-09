using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface IRoleRepository
    {

        List<Role> ListAllRole();
        void AddRole(Role role);
        void DeleteRole(Role role);
        void UpdateRole(Role role);

        Role GetByID(int id);
    }
}
