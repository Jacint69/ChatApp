﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository
{
    internal abstract class Repository<T> : IRepository<T> where T : class
    {
        MessageDbContext db;
        public Repository(MessageDbContext db)
        {

            this.db = db;

        }
        public void Create(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Set<T>().Remove(Read(id));
            db.SaveChanges();
        }

        public abstract T Read(int id);

        public IQueryable<T> ReadAll()
        {
            return db.Set<T>();
        }

        public abstract void Update(T item);
    }
}
