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
    public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
    {

        #region  Variables
        protected DbContext context;
       // protected DbSet<T> dbset;

        #endregion
        public PersonalRepository(DbContext context) : base(context)
        {
           
        }

        public void AddPersonal(Personal personal)
        {
            throw new NotImplementedException();

        }

        public void DeletePersonal(Personal personal)
        {
            throw new NotImplementedException();

        }

        public Personal GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Personal> GetTotalReport()
        {
            return dbset.AsQueryable();
        }

        public List<Personal> ListAllPersonal()
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonal(Personal personal)
        {
            throw new NotImplementedException();
        }
    }
}
