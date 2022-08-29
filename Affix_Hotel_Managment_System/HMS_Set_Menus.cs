using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Affix_Hotel_Managment_System
{
    public partial class HMS_Set_Menus : Form
    {
        private readonly MySqlConnection connection = DBUtil.get_DBConnection();
        private readonly string sql;

        public HMS_Set_Menus()
        {
            InitializeComponent();
        }

        private void Add_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }

        private void Save_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }

        private void Close_btn_CLicked_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
