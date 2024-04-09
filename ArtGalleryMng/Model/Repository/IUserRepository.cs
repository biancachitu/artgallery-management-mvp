using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryMng.Model.Repository
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);

        DataTable UserTable();

        bool InsertUser(User user);

        bool DeleteUser(int id);

        bool UpdateUser(User user);

        User GetUserById(int id);

        bool IsValidEmail(string email);
    }
}
