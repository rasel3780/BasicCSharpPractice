using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryListComboBox
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

        private void Form1_Load(object sender, EventArgs e)
        {
            countryListComboBox.Items.Add("Bangladesh");
            countryListComboBox.Items.Add("England");
            countryListComboBox.Items.Add("Russia");
        }

        private void countryListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = countryListComboBox.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }
    }
}
