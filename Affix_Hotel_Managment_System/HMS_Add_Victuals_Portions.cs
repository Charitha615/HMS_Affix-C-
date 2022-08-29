using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Affix_Hotel_Managment_System
{
    public partial class HMS_Add_Victuals_Portions : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection();
        String sql;

        public HMS_Add_Victuals_Portions()
        {
            InitializeComponent();
        }

        private void Close_btn_Clicked_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }

        private void Update_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }

        private void Delete_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }

        private void Add_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }

        }
    }
}
