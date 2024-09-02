using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BReservation
    {
        DReservation reserve = new DReservation();

        public DataSet getAvailableTables(int noOfSeats)
        {
            return reserve.getAvailableTables(noOfSeats);
        }

        public bool updateTblStat(string Tid, DateTime reservDate, DateTime reservTime)
        {
            return reserve.updateTblStat(Tid, reservDate, reservTime);
        }
    }
}
