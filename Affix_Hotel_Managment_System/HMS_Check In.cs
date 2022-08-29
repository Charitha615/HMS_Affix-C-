using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_In
{
    public partial class HMS_CheckIn : Form
    {
        public HMS_CheckIn()
        {
            InitializeComponent();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void Number_of_rooms_textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Walk_in_radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Room_no_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Room_type_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HMS_CheckIn_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / (ourScreenWidth);
            float scaleFactorHeigth = (float)ourScreenHeight / (ourScreenHeight);

            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);

            Scale(scaleFactor);
            // If you want to center the resized screen.
            CenterToScreen();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Reservation__ref_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
