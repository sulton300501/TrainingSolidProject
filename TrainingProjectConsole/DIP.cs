using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
   

   

    public interface IEMPDataAccessLayer
    {
        public void SaveEmployee();
    }

    public class EMPDataAccessLayer : IEMPDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Code for save employee
        }
    }

    public class Employee
    {
        private readonly IEMPDataAccessLayer _EMPDataAccessLayer;
        public Employee(IEMPDataAccessLayer EMPDataAccessLayer)
        {
            _EMPDataAccessLayer = EMPDataAccessLayer;
        }
        public void SaveEmployee()
        {
            _EMPDataAccessLayer.SaveEmployee();
        }
    }
}
