using FinalProject.three_tier_architecture.DAL.Cashier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Cashier
{
    public class BComplaints
    {
        public DataSet getAllComplaints()
        {
            DComplaints comp = new DComplaints();
            return comp.getAllComplaints();
        }
    }
}
