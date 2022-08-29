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
   
    public partial class HMS_Add_Staff_Type : Form
    { 
        MySqlConnection connection = DBUtil.get_DBConnection();

        String sql;

        public HMS_Add_Staff_Type()
        {
            InitializeComponent();
        }

        private void Update_btn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Save_btn_Clicked(object sender, EventArgs e)
        {
            //check whether the connections are closed before opening the connection
            if (connection.State == ConnectionState.Closed)
            {   
                connection.Open();
            }

            try
            {
                String Id = AutoGenarated_Ids.Generate_Id("STY");

               // sql = $"Insert into Staff_Type value('ST001','{Staff_combo_box.Text}')";
                sql = $"";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Staff Type Added Succsessfully");
        }
             catch (Exception ex)
            {
             MessageBox.Show("Error.."+ex.ToString());
            }
           
        }

        private void Cancel_btn_Clicked(object sender, EventArgs e)
        {

        }

        private void HMS_Add_Staff_Load(object sender, EventArgs e)
        {

        }

        private void Staff_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
