using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        double input;
        Temperature temperatureConverter = new Temperature();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
   
        private void FahrenheitToCelsiusButton_Click(object sender, EventArgs e)
        {
            input = Convert.ToDouble(inputTextBox.Text);
            double temperatureInCelcius = temperatureConverter.ConvertFahrenheitToCelsius(input);
            string feeling = temperatureConverter.GetFeeling(temperatureInCelcius);

            MessageBox.Show(input + "F to " + temperatureInCelcius+"C \n " + feeling );
        }

        private void CelsiusToFahrenheitButton_Click(object sender, EventArgs e)
        {
            input = Convert.ToDouble(inputTextBox.Text);
            double temperatureInFahrenheit = temperatureConverter.ConvertCelsiusToFahrenheit(input);
            string feeling = temperatureConverter.GetFeeling(input);

            MessageBox.Show(input + "C to " + temperatureInFahrenheit + "F \n " + feeling);
        }
    }
}
