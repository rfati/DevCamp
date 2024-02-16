using Intro.DataAccess.Abstracts;
using Intro.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class Repository<T>:IRepository<T> where T:class
    {
        Context c = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
           
        }


        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            
        }

        public List<T> List()
        {
            return _object.ToList();
        }

       

        public void Update(T p)
        {
            
        }
    }
}
