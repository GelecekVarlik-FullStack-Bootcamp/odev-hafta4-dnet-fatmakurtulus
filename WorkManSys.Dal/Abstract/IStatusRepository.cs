using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface IStatusRepository
    {
        List<Status> ListAllStatus();
        void AddStatus(Status status);
        void DeleteStatus(Status status);
        void UpdateStatus(Status status);

        Status GetByID(int id);
    }
}
