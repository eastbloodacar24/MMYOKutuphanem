using System;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Contrete.Managers
{
    public class BranchManager : IBranchService
    {
        private IBranchDal _branchdal;
        public BranchManager(IBranchDal branchdal) => _branchdal = branchdal;

        public Branch Add(Branch branch)
        {
            return _branchdal.Add(branch);
        }

        public Branch Get(Func<Branch, bool> condition = null)
        {
            return _branchdal.Get(condition);
        }

        public List<Branch> GetList(Func<Branch, bool> condition = null)
        {
            return _branchdal.GetList(condition);
        }

        public Branch GetMAX(Func<Branch, bool> condition = null)
        {
            return _branchdal.GetMAX(condition);
        }

        public Branch Modify(Branch branch)
        {
            return _branchdal.Modify(branch);
        }

        public int RecordCount(Func<Branch, bool> condition = null)
        {
            return _branchdal.RecordCount(condition);
        }

        public string[] GetNames()
        {
            return _branchdal.GetNames();
        }

        public List<Branch> GetDataManagementList()
        {
            return _branchdal.GetDataManagementList();
        }

        public void SaveChanges()
        {
            _branchdal.SaveChanges();
        }
    }
}
