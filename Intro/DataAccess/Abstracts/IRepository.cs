using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts
{
    public interface IRepository<T>
    {
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List();
        T GetById(int id);
        
    }
}
