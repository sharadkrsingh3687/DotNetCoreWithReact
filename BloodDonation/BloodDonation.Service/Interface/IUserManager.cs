using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BloodDonation.Models;

namespace BloodDonation.Service.Interface
{
    public interface IUserManager
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById();

        Task<bool> AddOrUpdateUser(User user);

        Task<bool> DeleteUser(int Id);
    }
}
