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
    public class RequestRepository :GenericRepository<Request>,IRequestRepository
    {
        public RequestRepository(DbContext context) : base(context)
        {
                
        }

        public void AddRequest(Request request)
        {
            throw new NotImplementedException();
        }

        public void DeleteRequest(Request request)
        {
            throw new NotImplementedException();
        }

        public Request GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Request> ListAllRequest()
        {
            throw new NotImplementedException();
        }

        public void UpdateRequest(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
