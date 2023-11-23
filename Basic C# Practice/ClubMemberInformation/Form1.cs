using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMemberInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        List<ClubMember> clubMemberList = new List<ClubMember>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            string paymentInfo = "Not paid";
            if(paymentCheckBox.Checked ) 
            {
                paymentInfo = "Paid";
            }
            string membershipType = "";
            if (monthlyFeeRadioButton.Checked) 
            {
                membershipType = "Monthly"; 
            }
            else if (yearlyFeeRadioButton.Checked) 
            {
                membershipType = "Yearly";
            }
            else if (lifetimeFeeRadioButton.Checked) 
            {
                membershipType = "Lifetime";
            }

            ClubMember aClubMember = new ClubMember(nameTextBox.Text, contactTextBox.Text, paymentInfo, membershipType);

            clubMemberList.Add(aClubMember);
            MessageBox.Show("Member added successfully");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string allInformation = "";
            
            foreach(ClubMember aClubMember in clubMemberList)
            {
                allInformation += aClubMember.Name+"\t" + aClubMember.ContactNo + "\t" + aClubMember.MembershipType + "\t" + aClubMember.PaymentInfo + "\n";
            }
            MessageBox.Show(allInformation);
        }
    }
}
