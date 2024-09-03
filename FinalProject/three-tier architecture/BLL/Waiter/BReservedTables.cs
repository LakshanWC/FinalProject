using FinalProject.three_tier_architecture.DAL.Waiter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Waiter
{
    public class BReservedTables
    {
        DReservedTables resTbl = new DReservedTables();

        public DataSet getTables()
        {
            return resTbl.getTables();
        }

        public int markTable(string tableName, string tblStat)
        {
            return resTbl.markTable(tableName, tblStat);
        }
    }
}
