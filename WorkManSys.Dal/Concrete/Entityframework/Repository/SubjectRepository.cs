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
    public class SubjectRepository :GenericRepository<Subject>,ISubjectRepository
    {
        public SubjectRepository(DbContext context) : base(context)
        {
                
        }

        public void AddSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public Subject GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Subject> ListAllSubject()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubject(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
