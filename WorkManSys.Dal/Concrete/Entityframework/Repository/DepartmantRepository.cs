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
    public class DepartmantRepository :GenericRepository<Departmant>,IDepartmantRepository
    {
        public DepartmantRepository(DbContext context) : base(context)
        {

        }

        public void AddDepartmant(Departmant departmant)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartmant(Departmant departmant)
        {
            throw new NotImplementedException();
        }

        public Departmant GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Departmant> ListAllDepartmant()
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartmant(Departmant departmant)
        {
            throw new NotImplementedException();
        }
    }
    
}
