using FinalProject.three_tier_architecture.DAL.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Manager
{
    public class BAttendents
    {
        public DataSet getAttendents(string filterType)
        {
            DAttendents dAttendents = new DAttendents();
            return dAttendents.getAttendents(filterType);
        }
    }
}
