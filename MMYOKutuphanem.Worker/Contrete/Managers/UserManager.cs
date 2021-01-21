using System;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MMYOKutuphanem.Worker.Contrete.Managers
{
   public class UserManager : IUserService
    {
        private IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public User Add(User user)
        {
            return _userdal.Add(user);
        }

        public User Get(Func<User, bool> condition = null)
        {
            return _userdal.Get(condition);
        }

        public List<User> GetList(Func<User, bool> condition = null)
        {
            return _userdal.GetList(condition);
        }

        public User GetMAX(Func<User, bool> condition = null)
        {
            return _userdal.GetMAX(condition);
        }

        public User Modify(User user)
        {
            return _userdal.Modify(user);
        }

        public int RecordCount(Func<User, bool> condition = null)
        {
            return _userdal.RecordCount(condition);
        }
        
        public string[] GetNames(Func<User, bool> condition = null)
        {
            return _userdal.GetNames();
        }

        public List<User> GetDataManagementList()
        {
            return _userdal.GetDataManagementList();
        }

        public void SaveChanges()
        {
            _userdal.SaveChanges();
        }
    }
}
