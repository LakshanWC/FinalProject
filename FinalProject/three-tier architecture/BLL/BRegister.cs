using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BRegister
    {
        DRegister reg = new DRegister();

        public string genarateCustomerId()
        {
            return reg.genarateCustomerId();
        }

        public int addCustomer(string id, string name, string nic, string address, DateTime dob,
                string email, string telNo, string userName, string pass)
        {
            return reg.addCustomer(id, name, nic, address, dob, email, telNo, userName, pass);
        }

        public int addEmployee(string id, string name, string nic, string address, DateTime dob,
                string telNo, string userName, string pass, int empType)
        {
            return reg.addEmployee(id,name,nic,address,dob,telNo,userName,pass, empType);
        }
    }
}
