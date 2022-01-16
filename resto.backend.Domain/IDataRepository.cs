using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.backend.Domain
{
    public interface IDataRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        
    }
}

