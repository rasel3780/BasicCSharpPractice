using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOdd
{
    public partial class Form1 : Form
    {
        private bool evenBttnClicked = false;
        private bool oddBttnClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OddEvenFinder()
        {
            try
            {
                int num1 = Convert.ToInt32(num1TxtBox.Text);
                int num2 = Convert.ToInt32(num2TxtBox.Text);
                if (num1 > num2 || num1==num2)
                {
                    MessageBox.Show("Number 1 must be greater than Number 2");
                }
                else
                {
                    string evenString = "";
                    string oddString = "";
                    if (evenBttnClicked)
                    {
                        for (int i = num1; i < num2; i++)
                        {
                            if (i % 2 == 0)
                            {
                                evenString += i + " ";
                            }
                        }                 
                        MessageBox.Show(evenString);
                    }

                    else if (oddBttnClicked)
                    {
                        for (int i = num1; i < num2; i++)
                        {
                            if (i % 2 != 0)
                            {
                                oddString += i + " ";
                            }
                        }                      
                        MessageBox.Show(oddString);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Input Fild can't be empty and input must be numeric", ex.Message);   
            }
        }

        private void evenBtn_Click(object sender, EventArgs e)
        {
            evenBttnClicked=true;
            OddEvenFinder();
            evenBttnClicked = false;
        }

        private void oddBtn_Click(object sender, EventArgs e)
        {
            oddBttnClicked=true;
            OddEvenFinder();
            oddBttnClicked = false;
        }
    }
}
