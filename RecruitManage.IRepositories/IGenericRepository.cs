using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace RecruitManage.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        void AddOrUpdate(T item);
        void Delete(T item);
        IEnumerable<T> List();
        T GetById(int id);        

    }
}
