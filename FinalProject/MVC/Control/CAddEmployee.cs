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
        public string getNewEid()
        {
            MAddEmployee mAddEmployee = new MAddEmployee();
            return mAddEmployee.getNewEid();
        }
    }
}
