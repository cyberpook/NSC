using System;
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
        private void input_EnterClicked(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.error.Text = null;
                try
                {
                    number = Convert.ToInt32(input.Text);
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
        }
        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SystemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SystemSelect.SelectedIndex;
            if(selectedIndex == 0)
            {
                this.inputAsking.Text = "Enter binary number";
                choose = 2;
            }
            if (selectedIndex == 1)
            {
                this.inputAsking.Text = "Enter octal number";
                choose = 8;
            }
            if (selectedIndex == 2)
            {
                this.inputAsking.Text = "Enter decimal number";
                choose = 10;
            }
            if (selectedIndex == 3)
            {
                this.inputAsking.Text = "Enter hexadecimal number";
                choose = 16;
            }
        }
    }
}
