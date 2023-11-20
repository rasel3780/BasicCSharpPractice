using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    internal class Employee
    {
        public string employeeName;
        public double basicAmount;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double GetHouseRentPercentage()
        {
            return (basicAmount / 100) * houseRentPercentage;
        }

        public double GetMedicalAllowancePercentage() 
        {
            return (basicAmount / 100) * medicalAllowancePercentage;
        }

        public double GetTotalSallary()
        {
            return basicAmount + GetHouseRentPercentage() + GetMedicalAllowancePercentage();
        }
    }
}
