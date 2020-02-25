using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {

        public List<UserModel> GetAll()
        {
            return GenerateList();
        }
        public UserModel Get(int id)
        {
            return GenerateList().Where(u => u.Id == id).FirstOrDefault();
        }

        public UserModel Insert(UserModel model)
        {
            if (model == null)
            {
                return null;
            }
            if (model.Id > 0)
            {
                return null;
            }

            var list = GenerateList();
            list.Add(model);

            return model;
        }

        public UserModel Edit(UserModel model)
        {
            if (model == null)
            {
                return null;
            }

            var list = GenerateList();
            var existingModel = list.Where(u => u.Id == model.Id).FirstOrDefault();
            if (existingModel == null)
            {
                return null;
            }
            //Code to edit

            return model;
        }
        public void Delete(int id)
        {
            var list = GenerateList();
            var existingModel = list.Where(u => u.Id == id).FirstOrDefault();
            list.Remove(existingModel);
        }

        private List<UserModel> GenerateList()
        {
            var list = new List<UserModel>();
            list.Add(new UserModel()
            {
                Id = 1,
                FirstName = "Mircea",
                LastName = "Blendea",
                Email = "something@something.com",
                Age = 27
            });
            list.Add(new UserModel()
            {
                Id = 2,
                FirstName = "Mircea2",
                LastName = "Blendea2",
                Email = "something2@something.com",
                Age = 27
            });

            return list;
        }

    }
}
