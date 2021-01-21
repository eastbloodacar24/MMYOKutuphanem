using System;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Contrete.Managers
{
    public class AssigmentManager : IAssignmentService
    {
        private IAssigmentDal _assignmentdal;
        public AssigmentManager(IAssigmentDal assigmentdal)
        {
            _assignmentdal = assigmentdal;
        }
        public Assignment Add(Assignment assignment)
        {
            return _assignmentdal.Add(assignment);
        }
        public Assignment Modify(Assignment assignment)
        {
            return _assignmentdal.Modify(assignment);
        }
        public Assignment Get(Func<Assignment, bool> condition = null)
        {
            return _assignmentdal.Get(condition);
        }

        public List<Assignment> GetList(Func<Assignment, bool> condition = null)
        {
            return _assignmentdal.GetList(condition);
        }

        public Assignment GetMAX(Func<Assignment, bool> condition = null)
        {
            return _assignmentdal.GetMAX(condition);
        }

        public int RecordCount(Func<Assignment, bool> condition = null)
        {
            return _assignmentdal.RecordCount(condition);
        }

        public List<Assignment> GetDataManagementList()
        {
            return _assignmentdal.GetDataManagementList();
        }

        public void SaveChanges()
        {
            _assignmentdal.SaveChanges();
        }
    }
}
