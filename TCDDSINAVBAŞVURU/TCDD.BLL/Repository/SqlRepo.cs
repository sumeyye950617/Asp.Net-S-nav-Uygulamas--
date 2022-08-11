using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TCDD.DLL.Context;

namespace TCDD.BLL.Repository
{
    public class SqlRepo<T> where T : class
    {
        SqlContext db;
        public SqlRepo(SqlContext _db)
        {
            db = _db;
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, Boolean>> expr)
        {
            return db.Set<T>().Where(expr);
        }

        public void Add(T model)
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
        }

        public void Update(T model)
        {
            db.Set<T>().Update(model);
            db.SaveChanges();
        }

        public void Delete(T model)
        {
            db.Set<T>().Remove(model);
            db.SaveChanges();
        }

        public int ExecuteProc(string sql)
        {
            return db.Database.ExecuteSqlRaw(sql);
        }
    }
}



