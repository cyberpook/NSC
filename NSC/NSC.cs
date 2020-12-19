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

        private int dec;

        private void input_EnterClicked(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.error.Text = null;
                try
                {
                    dec = Convert.ToInt32(input.Text);
                    binary.Text = Convert.ToString(dec, 2);
                    octal.Text = Convert.ToString(dec, 8);
                    hexadecimal.Text = Convert.ToString(dec, 16);
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
    }
}
