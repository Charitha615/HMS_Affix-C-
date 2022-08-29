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
    public partial class HMS_Add_Item_Qty_Types : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection();
        String sql;

        public HMS_Add_Item_Qty_Types()
        {
            InitializeComponent();

            Add_TO_Combo();
        }

        private void Add_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed) {

                connection.Open();
            }

            try
            {
                sql = $"Insert into ingredient_qty_types values ('{New_Qty_Type_combo.Text}') ";
               // sql = "";

                MySqlCommand command = new MySqlCommand(sql,connection);

                command.ExecuteNonQuery();

                Add_TO_Combo();

                connection.Close();
                command.Dispose();

                New_Qty_Type_combo.Text = "";

            } catch (Exception ex) {
                MessageBox.Show("Error..", ex.ToString());
            }
        }

        private void Delete_btn_Clicked_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            try
            {
                sql = $"Delete from ingredient_qty_types where Ingredient_Qty_Type = '{New_Qty_Type_combo.Text}'";
                //sql = "";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Add_TO_Combo();

                connection.Close();
                command.Dispose();

                New_Qty_Type_combo.Text = "";

                MessageBox.Show("Ingredient Qty Type Deleted Successfully");
            }
            catch (Exception ex) {
                MessageBox.Show("Error..", ex.ToString());
            }
        }

        private void Cancel_btn_Clicked_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        //Add_To_Combo method is implemented to read the table and view Qty Types in the combo box
        public void Add_TO_Combo() {

           
            New_Qty_Type_combo.Items.Clear();

            try
            {
                MySqlDataReader read;

                //check whether the connections are close before opening the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                sql = $" select Ingredient_Qty_Type from ingredient_qty_types";

                MySqlCommand command = new MySqlCommand(sql, connection);
                read = command.ExecuteReader();


                while (read.Read())
                {

                    New_Qty_Type_combo.Items.Add(read.GetString(0).ToString());
                }

                connection.Close();
                command.Dispose();
                read.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void HMS_Add_Ingredient_Qty_Types_Load(object sender, EventArgs e)
        {

        }
    }
}
