﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            GradeCalculator gradeCalculator = new GradeCalculator();
       
            double mathScore = Convert.ToDouble(mathTextBox.Text);
            double physicScore = Convert.ToDouble(physicsTextBox.Text);
            double chemistryScore = Convert.ToDouble(chemistryTextBox.Text);

            gradeCalculator.mathScore = mathScore;
            gradeCalculator.physicsScore = physicScore;
            gradeCalculator.chemistryScore = chemistryScore;

            mathGradeTextBox.Text = gradeCalculator.GetMathGrade();
            chemistryGradeTextBox.Text = gradeCalculator.GetChemistryGrade();
            physicsGradeTextBox.Text = gradeCalculator.GetPhysicsGrade();

            averageScoreTextBox.Text = gradeCalculator.GetAvgScore().ToString();
            overallGradeTextBox.Text = gradeCalculator.GetOverallGrade();
        }
    }
}
