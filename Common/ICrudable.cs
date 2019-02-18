using System;
using System.Collections.Generic;

namespace Common
{
    public interface ICrudable<T> : IDisposable
    {
        /*
    create
    readById
    readAll
    update
    delete
    
     */
        T Create(T obj);
        T Retrieve(int id);
        T Retrieve(string id);
        List<T> RetrieveAll();
        void Update(T obj);
        void Delete(int id);
        void Delete(string id);
    }
}
