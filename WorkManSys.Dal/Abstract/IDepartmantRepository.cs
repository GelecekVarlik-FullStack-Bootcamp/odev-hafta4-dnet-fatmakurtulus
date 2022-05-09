using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface IDepartmantRepository
    {

        List<Departmant> ListAllDepartmant();
        void AddDepartmant(Departmant departmant);
        void DeleteDepartmant(Departmant departmant);
        void UpdateDepartmant(Departmant departmant);

        Departmant GetByID(int id);

    }
}
