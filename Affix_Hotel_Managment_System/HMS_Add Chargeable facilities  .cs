using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Affix_Hotel_Managment_System
{
    public partial class HMS_Add_Chargable_Facilities : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;

        public HMS_Add_Chargable_Facilities()
        {
            InitializeComponent();
        }


        //Insert
        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the connection
                DBUtil.open_Connection(connection);


                //Auto Genararated Id 
                //string id = AutoGenarated_Ids.Generate_Id("CF");
                string id = "01";

               //SQL Command
                sql = $"INSERT INTO `hms_affix`.`chargeable_facility` (`Facility_Id`, `Facility_Name`, `Facility_Ref_No`, `Facility_Price`) VALUES('{id}', '{Facilitie_Name_comboBox1.Text}', '{Facility_No_textBox1.Text}', '{Facility_Price_textBox2.Text}')";

                MySqlCommand my = new MySqlCommand(sql, connection);
                my.ExecuteNonQuery();
                MessageBox.Show("Success Your Submission!");
                connection.Close();
                my.Dispose();

                foreach (Control c in groupBox1.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                    else if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }

                    ComponentClass.add_To_Combo(connection, Facilitie_Name_comboBox1, "Facility_Name", "chargeable_facility");
               //Combo Box Load



            }
            catch (Exception ex)
            {
                MessageBox.Show("HMS_ADD_CHARGABLE_FACILITIES ERROR " + ex.ToString());
            }

        }

        private void HMS_Add_Chargable_Facilities_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection,Facilitie_Name_comboBox1, "Facility_Name", "chargeable_facility");
            //add_to_combo(); // COMBOBOX LOAD
        }

        

        //Retrive
        //when select a value from combobox, its values retrives
        private void Facilitie_Name_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                DBUtil.open_Connection(connection);

                //Sql Commands
                sql = $"SELECT * FROM chargeable_facility WHERE Facility_Name='{Facilitie_Name_comboBox1.SelectedItem}'";
                MySqlCommand my = new MySqlCommand(sql, connection);
                MySqlDataReader reader; //default
                reader = my.ExecuteReader();  //store the data

                
                //Get the values using loop
                while (reader.Read())
                {
                    Facility_No_textBox1.Text = reader.GetString(2);
                    Facilitie_Name_comboBox1.Text = reader.GetString(1);
                    Facility_Price_textBox2.Text = reader.GetString(3);
                   
                }


                connection.Close();
                my.Dispose();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrive Combox Values Error" + ex.ToString());
            }
        }

        //Delete
        private void Delete_btn_Click(object sender, EventArgs e)
        {

            //Open connection
            DBUtil.open_Connection(connection);

            //SQL
            sql = $" DELETE FROM chargeable_facility WHERE Facility_Name='{Facilitie_Name_comboBox1.SelectedItem}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Successfully Deleted ");

            connection.Close();
            my.Dispose();

            ComponentClass.add_To_Combo(connection, Facilitie_Name_comboBox1, "Facility_Name", "chargeable_facility");
            
            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                else if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Update
        private void Update_btn_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);


            sql = $"UPDATE chargeable_facility SET Facility_Price= '{Facility_Price_textBox2.Text}' WHERE Facility_Name= '{Facilitie_Name_comboBox1.SelectedItem}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Price Updated");

            connection.Close();
            my.Dispose(); // clear the data stored in the object "my"


            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                else if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            //Add to combobox
            ComponentClass.add_To_Combo(connection, Facilitie_Name_comboBox1, "Facility_Name", "chargeable_facility");
            
        }
    }
}
