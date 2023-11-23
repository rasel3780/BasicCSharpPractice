using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemberInformation
{
    internal class ClubMember
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string PaymentInfo { get; set; }
        public string MembershipType { get; set; }

        public ClubMember()
        {
            Name = "Unknown";
            ContactNo = "Unknown";
            PaymentInfo = "Unknown";
            MembershipType = "Unknown";
        }

        public ClubMember(string name, string contactNo, string paymentInfo, string membershipType)
        {
            Name = name;
            ContactNo = contactNo;
            PaymentInfo = paymentInfo;
            MembershipType = membershipType;
        }
    }
}
