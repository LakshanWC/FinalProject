using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BRemoveEmployee
    {
        public int removeEmployee(string eno, int deleteType)
        {
            DRemoveEmployee removeEmp = new DRemoveEmployee();
            return removeEmp.removeEmployee(eno, deleteType);
        }
        public DataSet getEmployeeDetails(string eid) { 
            DRemoveEmployee empDetails = new DRemoveEmployee();
            return empDetails.getEmployeeDetails(eid);
        }
    }
}
