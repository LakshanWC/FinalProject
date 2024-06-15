using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BGeneralReports
    {
        public DataSet getAttendentDetails()
        {
            DGeneralReports report = new DGeneralReports();
            DataSet ds = report.getAttendentDetails();
            return ds;
        }

    }
}
