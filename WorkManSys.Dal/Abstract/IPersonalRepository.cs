using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Models;

namespace WorkManSys.Dal.Abstract
{
    public interface IPersonalRepository
    {
       

        List<Personal> ListAllPersonal();
        void AddPersonal(Personal personal);
        void DeletePersonal(Personal personal);
        void UpdatePersonal(Personal personal);

        Personal GetByID(int id);


    }
}
