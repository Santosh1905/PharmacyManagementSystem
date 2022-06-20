using PharmacyManagementSystem.Models;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Repository
{
    public interface IUserRepository
    {
        UserDetail Create(UserDetail user);
        IEnumerable<UserDetail> GetAll();
        UserDetail GetByEmail(string email);
        UserDetail GetById(int id);
    }
}