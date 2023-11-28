using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example1
{
    internal class ProfessonalParticipant: Participant
    {
        public string CompanyName { get; set; }
        public string CompanyContactNumber { get; set; }

        public override double GetTotalPayable()
        {
            double totalPayable = base.GetTotalPayable();
            double extraPayable = (totalPayable * 0.1) / 100;
            return totalPayable + extraPayable;
        }
    }
}
