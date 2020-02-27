using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<UserModel> GetAll();
        UserModel Get(int id);
        UserModel Insert(UserModel model);
        UserModel Edit(UserModel model);
        void Delete(int id);
    }
}
