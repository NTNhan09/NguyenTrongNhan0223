using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Folder;
using Model.Folder;

namespace BUS.Folder
{
    public class CustomBUS
    {
        CustomDAL dal = new CustomDAL();
        public List<CustomBEL> ReadEmployee()
        {
            List<CustomBEL> IstCus = dal.ReadEmployee();
            return IstCus;
        }
        public void NewEmployee(CustomBEL cus)
        {
            dal.NewEmployee(cus);

        }
        public void DeleteEmployee(CustomBEL cus)
        {
            dal.DeleteEmployee(cus);
        }
        public void EditEmployee(CustomBEL cus)
        {
            dal.EditEmployee(cus);
        }
    }
}
