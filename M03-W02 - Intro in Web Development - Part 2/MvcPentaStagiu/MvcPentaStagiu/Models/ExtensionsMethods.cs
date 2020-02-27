using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPentaStagiu.Models
{
    public static class ExtensionsMethods
    {
        public static UserViewModel ToViewModel(this UserModel model)
        {
            return new UserViewModel()
            {
                Id = model.Id,
                Age = model.Age,
                Email = model.Email,
                LastName = model.LastName,
                FirstName = model.FirstName
            };
        }
    }
}