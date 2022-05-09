using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface IRequestRepository
    {

        List<Request> ListAllRequest();
        void AddRequest(Request request);
        void DeleteRequest(Request request);
        void UpdateRequest(Request request);

        Request GetByID(int id);
    }
}
