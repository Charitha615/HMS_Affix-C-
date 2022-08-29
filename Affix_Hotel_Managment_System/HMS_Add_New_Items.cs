using MySql.Data.MySqlClient;
using System;
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
    public partial class HMS_Add_New_Items : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection();
        String sql;

        public HMS_Add_New_Items()
        {
            InitializeComponent();
        }

        private void Add_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check wether the connections are close before opening the connection
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }

            try
            {

                String K_Id = AutoGenarated_Ids.Generate_Id("KIN");
                String B_Id = AutoGenarated_Ids.Generate_Id("BIN");

                sql = $"insert into new_ingredients_kitchen.['Kitchen_radio'] values ('{K_Id}' , '{Ingredient_Name_combo.Text}' ) ";
                sql = $"insert into new_ingredients_bar values ('{B_Id}' , '{Ingredient_Name_combo.Text}' ) ";

                sql = "";

                MySqlCommand command = new MySqlCommand(sql , connection);
                command.ExecuteNonQuery();

               
            }
            catch (Exception ex) {
                MessageBox.Show("Error..", ex.ToString());
            }
        }

        private void Delete_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check wether the connections are close before opening the connection
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                sql = $"Delete from -------- where -------";
                // sql = "";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.ExecuteNonQuery();



                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..", ex.ToString());
            }
        }

        private void Cancel_btn_Clicked_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void HMS_Add_New_Items_Load(object sender, EventArgs e)
        {

        }
    }
}
