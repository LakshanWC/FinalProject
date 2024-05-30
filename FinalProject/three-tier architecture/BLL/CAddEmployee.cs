using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class CAddEmployee
    {
        MAddEmployee mAddEmployee = new MAddEmployee();

        public string getNewEid()
        {          
            return mAddEmployee.getNewEid();
        }
        public bool addEmployee(string Eid, string Ename, string Enic, string Eaddress, DateTime Edob,
           string Etel, string Eusername, string Epassword, double OtHours, double salary, int Etype)
        {
           return mAddEmployee.addEmployee( Eid, Ename, Enic, Eaddress, Edob,
               Etel, Eusername, Epassword, OtHours, salary, Etype);
        }
        public string randomPasswordGen(string name)
        {
            return mAddEmployee.randomPasswordGenerator(name);
        }
    }
}
