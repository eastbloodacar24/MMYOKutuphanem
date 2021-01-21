using System;
using MMYOKutuphanem.Entites.Concrete;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Abstract
{
    public interface IBranchService
    {
        Branch Add(Branch branch);
        Branch Modify(Branch branch);
        List<Branch> GetList(Func<Branch, bool> condition = null);
        string[] GetNames();
        Branch Get(Func<Branch, bool> condition = null);
        int RecordCount(Func<Branch, bool> condition = null);
        Branch GetMAX(Func<Branch, bool> condition = null);
        List<Branch> GetDataManagementList();
        void SaveChanges();

    }
}
