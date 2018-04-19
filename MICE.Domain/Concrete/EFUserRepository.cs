using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MICE.Domain.Abstract;
using MICE.Domain.Entities;
using System.Data.Entity.Migrations;

namespace MICE.Domain.Concrete
{
    public class EFUserRepository:IUserRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<User> Users
        {
            get { return context.Users; }
        }
        public void SaveUser(User user)
        {
            if(user.ID == 0)
            {
                context.Users.AddOrUpdate(user);
            }
            context.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
