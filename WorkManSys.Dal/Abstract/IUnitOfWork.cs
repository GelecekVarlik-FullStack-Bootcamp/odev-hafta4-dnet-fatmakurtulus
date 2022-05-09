using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Base;

namespace WorkManSys.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        //bll de kullanılacak
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransaction();        //başlattık
        bool RollBackTransaction();//hata durumunda geri aldık

        int SaveChanges(); //Transaction onayladık

    }
}
