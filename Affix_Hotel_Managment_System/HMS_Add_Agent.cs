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
    public partial class HMS_Add_Agent : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection();

        String sql;


        public HMS_Add_Agent()
        {
            InitializeComponent();
        }

        private void Save_btn_Click_Click(object sender, EventArgs e)
        {
            //check whether the connections are closed before  open the connection
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
               // String Id = AutoGenarated_Ids.Generate_Id("ag");
                sql = $" ";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Staff Insert Sucessfulluy");
                connection.Close();
                command.Dispose();

                //clear check boxes after one is Inserted
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void Delete_btn_Click_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                sql = $" ";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");

                connection.Close();
                command.Dispose();

                //clear check boxes after one is Deleted
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                     
                }


            }
            catch (Exception ex) {  

           
                MessageBox.Show("Error");
            }
        }

        private void Update_btn_Click_Click(object sender, EventArgs e)
        {
            //check whether the connection is closed  before open connection
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            sql = $"";


            MySqlCommand com = new MySqlCommand(sql, connection);

            com.ExecuteNonQuery();
            MessageBox.Show("Succsefully Updated");
            connection.Close();
            com.Dispose();
            //clear check boxes after one is updated
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
