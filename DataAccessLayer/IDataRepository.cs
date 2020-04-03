﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace DataLayer
{
    public class IDataRepository
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
        void CallStoredProc(string name, params Tuple<string, string>[] parameters);
        IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
    }
}
