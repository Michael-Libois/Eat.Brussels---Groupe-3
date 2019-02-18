using Common;
using ContextWithEntityFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class CookTypeRepo : ICrudable<CookType>
    {
        private DatabaseContext dbContext;
        public CookTypeRepo(DatabaseContext db)
        {
            dbContext = db;
        }

        public CookType Create(CookType obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CookType Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public CookType Retrieve(string id)
        {
            throw new NotImplementedException();
        }
        public List<CookType> RetrieveByTitle(string title)
        {
            return dbContext.CookTypes.Where(c=>c.Title == title).ToList();
        }

        public List<CookType> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CookType obj)
        {
            throw new NotImplementedException();
        }
    }
}
