using MMYOKutuphanem.Entites.Concrete;
using System;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Abstract
{
    public interface IAssignmentService
    {
        Assignment Add(Assignment assignment);
        Assignment Modify(Assignment assignment);
        List<Assignment> GetList(Func<Assignment, bool> condition = null);
        Assignment Get(Func<Assignment, bool> condition = null);
        int RecordCount(Func<Assignment, bool> condition = null);
        Assignment GetMAX(Func<Assignment, bool> condition = null);
        List<Assignment> GetDataManagementList();
        void SaveChanges();
    }
}
