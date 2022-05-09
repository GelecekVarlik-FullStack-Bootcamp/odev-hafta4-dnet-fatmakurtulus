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
    public class StatusRepository :GenericRepository<Status>,IStatusRepository
    {
        public StatusRepository(DbContext context) : base(context)
        {
                
        }

        public void AddStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public void DeleteStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public Status GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Status> ListAllStatus()
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
