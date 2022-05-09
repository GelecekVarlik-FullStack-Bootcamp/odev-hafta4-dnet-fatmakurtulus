using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface ISubjectRepository
    {

        List<Subject> ListAllSubject();
        void AddSubject(Subject subject);
        void DeleteSubject(Subject subject);
        void UpdateSubject(Subject subject);

        Subject GetByID(int id);
    }
}
