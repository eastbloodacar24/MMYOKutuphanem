using MMYOKutuphanem.Entites.Concrete;
using System;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Abstract
{
    public interface IUserService
    {
        User Add(User user);
        User Modify(User user);
        List<User> GetList(Func<User, bool> condition = null);
        User Get(Func<User, bool> condition = null);
        string[] GetNames(Func<User, bool> condition = null);
        int RecordCount(Func<User, bool> condition = null);
        User GetMAX(Func<User, bool> condition = null);
        List<User> GetDataManagementList();
        void SaveChanges();

    }
}
