using MICE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MICE.Domain.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void SaveUser(User user);
        void DeleteUser(User user);
    }
}
