using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formssss
{
    public partial class Form1 : Form
    {
        private string constantRegex = @"^[+-]?[0-9]+(\.[0-9]+)?([eE][+-]?[0-9]+)?$";

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txt.Text.Trim();

            // Validate the input length and display appropriate message
            if (string.IsNullOrEmpty(input))
            {
                label1.Text = "Input is empty!";
            }
            else if (input.Length < 3)
            {
                label1.Text = "Too short!";
            }
            else if (input.Length > 6)
            {
                label1.Text = "Too long!";
            }
            else
            {
                label1.Text = "Input is valid!";
            }
        }



    }
}