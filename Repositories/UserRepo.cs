using Common;
using ContextWithEntityFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UserRepo : ICrudable<User>
    {
        private DatabaseContext dbContext;
        public UserRepo(DatabaseContext db)
        {
            dbContext = db;
        }

        public User Create(User obj)
        {
            dbContext.Users.Add(obj);
            dbContext.SaveChanges();
            return obj;
        }

        public void Delete(int id)
        {
            User user = Retrieve(id);
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public User Retrieve(int id)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserID == id);
        }

        public User Retrieve(string idString)
        {
            int id;
            if (int.TryParse(idString, out id))
                return Retrieve(id);
            return null;
        }

        public List<User> RetrieveAll()
        {
            return dbContext.Users.ToList();
        }

        public void Update(User obj)
        {
            
            User user = Retrieve(obj.UserID);
            user = obj;
            dbContext.SaveChanges();
        }
    }
}
