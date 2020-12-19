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
        private void input_TextChanged(object sender, EventArgs e)
        {
            //KeyPressEventArgs 
            try
            {
                dec = Convert.ToInt32(input.Text);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
            binary.Text = Convert.ToString(dec, 2);
            octal.Text = Convert.ToString(dec, 8);
            hexadecimal.Text = Convert.ToString(dec, 16);
        }

        
        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
