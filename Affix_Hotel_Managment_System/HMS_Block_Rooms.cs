﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affix_Hotel_Managment_System
{
    public partial class HMS_Block_Rooms : Form
    {
        public HMS_Block_Rooms()
        {
            InitializeComponent();
        }

        private void Generate_btn_click(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

        }

        private void Close_btn_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        private void To_lbl_Click(object sender, EventArgs e)
        {

        }

        private void HMS_Block_Rooms_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
