﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSC
{
    public partial class NSC : Form
    {
        public NSC()
        {
            InitializeComponent();

        }

        private int number;
        private int choose;
        private void input_TextChanged(object sender, EventArgs e)
        {
            this.error.Text = null;
            if (choose == 10)
            {                   
                try
                {
                    number = Convert.ToInt32(input.Text, 10);
                    binary.Text = Convert.ToString(number, 2);
                    octal.Text = Convert.ToString(number, 8);
                    hexadecimal.Text = Convert.ToString(number, 16);
                }
                catch (Exception)
                {                  
                    error.Visible = true;
                    error.Text = "Your input contains \ninapropriate symbols...";
                    binary.Text = "Error";
                    octal.Text = "Error";
                    hexadecimal.Text = "Error";
                }
            }
            else
            {
                try
                {                   
                    number = Convert.ToInt32(input.Text, 16);
                    binary.Text = Convert.ToString(number, 2);
                    octal.Text = Convert.ToString(number, 8);
                    hexadecimal.Text = Convert.ToString(number, 10);
                }
                catch (Exception)
                {

                    error.Visible = true;
                    error.Text = "Your input contains \ninapropriate symbols...";
                    binary.Text = "Error";
                    octal.Text = "Error";
                    hexadecimal.Text = "Error";
                }
            }
            
        }
        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SystemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SystemSelect.SelectedIndex;
            if(selectedIndex == 0)
            {
                this.inputAsking.Text = "Enter binary number";
                choose = 2;
                this.binLabel.Text = "Octal form:";
                this.octLabel.Text = "Decimal form:";
                this.hexadec.Text = "Hexadecimal form:";
            }
            else if (selectedIndex == 1)
            {
                this.inputAsking.Text = "Enter octal number";
                choose = 8;
                this.binLabel.Text = "Binary form:";
                this.octLabel.Text = "Decimal form:";
                this.hexadec.Text = "Hexadecimal form:";
            }
            else if (selectedIndex == 2)
            {
                this.inputAsking.Text = "Enter decimal number";
                choose = 10;
                this.binLabel.Text = "Binary form:";
                this.octLabel.Text = "Octal form:";
                this.hexadec.Text = "Hexadecimal form:";
            }
            else if (selectedIndex == 3)
            {
                this.inputAsking.Text = "Enter hexadecimal number";
                choose = 16;
                this.binLabel.Text = "Binary form:";
                this.octLabel.Text = "Octal form:";
                this.hexadec.Text = "Decimal form:";
            }
        }
        private void About_Click(object sender, EventArgs e)
        {
            Application.Run(new AboutUsForm());
        }
    }
}
