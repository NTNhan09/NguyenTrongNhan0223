using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Folder;
using Model.Folder;

namespace BUS.Folder
{
    public class EmploBUS
    {
        EmploDAL dal = new EmploDAL();
        public List<EmploBEL> ReadEmployeeList()
        {
            List<EmploBEL> IstDepar = dal.ReadEmployeeList();
            return IstDepar;
        }
    }
}
