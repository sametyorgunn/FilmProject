﻿using FilmProject.Application.Repositories;
using FilmProject.Presistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Presistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public List<T> GetList()
        {
            using (var c = new Context())
            {
                return c.Set<T>().ToList();
            }
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Set<T>().Where(filter).ToList();
            }
        }

        public void TAdd(T t)
        {
            using (var c = new Context())
            {
                c.Add(t);
                c.SaveChanges();
            }
        }

        public void TDelete(T t)
        {
            using (var c = new Context())
            {
                c.Remove(t);
                c.SaveChanges();
            }
        }

        public T TGetById(int id)
        {
            using (var c = new Context())
            {
                return c.Set<T>().Find(id);
            }
        }

        public void TUpdate(T t)
        {
            using (var c = new Context())
            {
                c.Update(t);
                c.SaveChanges();
            }
        }
    }
}
