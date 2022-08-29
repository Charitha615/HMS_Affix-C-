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
    public partial class HMS_Add_Ingredient_Qty_Types : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection();
        String sql;

        public HMS_Add_Ingredient_Qty_Types()
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

            //try
            //{
                String id = AutoGenarated_Ids.Generate_Id("QT");

                sql = $"Insert into qty_type values ('{id}','{Qty_Type_combo.Text}','300')";
                // sql = "";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.ExecuteNonQuery();

                Add_TO_Combo();

                connection.Close();
                command.Dispose();

                Qty_Type_combo.Text = "";

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error..", ex.ToString());
            //}
        }


        private void Delete_btn_Clicked_Click(object sender, EventArgs e)
        {

            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            try
            {
                sql = $"Delete from qty_type where Qty_Type_Name = '{Qty_Type_combo.Text}'";
                //sql = "";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Add_TO_Combo();

                connection.Close();
                command.Dispose();

                Qty_Type_combo.Text = "";

                MessageBox.Show("Ingredient Qty Type Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..", ex.ToString());
            }
        }

        private void Cancel_btn_Clicked_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Add_To_Combo method is implemented to read the table and view Qty Types in the combo box
        public void Add_TO_Combo()
        {


            Qty_Type_combo.Items.Clear();

            try
            {
                MySqlDataReader read;

                //check whether the connections are close before opening the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                sql = $" select Qty_Type_Name from qty_type";

                MySqlCommand command = new MySqlCommand(sql, connection);
                read = command.ExecuteReader();


                while (read.Read())
                {

                    Qty_Type_combo.Items.Add(read.GetString(0).ToString());
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
    }
}
