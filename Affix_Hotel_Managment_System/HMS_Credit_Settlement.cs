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
    public partial class HMS_Credit_Settlement : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;

        public HMS_Credit_Settlement()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            HMS_Card_Payment hMS_Card_Payment = new HMS_Card_Payment();
            hMS_Card_Payment.ShowDialog();
        }

        private void HMS_Credit_Settlement_Load(object sender, EventArgs e)
        {
           ComponentClass.add_To_Combo(connection, Member_comboBox, "Member_Name", "credit_member");
            //Genarate the Settlement_Ref_ID and show the id in ref TextBox
            


        }


        // Member Id save this value
        string memId;

        //Retrive Part to ListBox
        private void Member_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try {
                //Get member Id and Retrive there deatils
                
                get_memberID();
                ListView();

              
                

                //ListView Clear
                foreach (var i in listView1.Items)
                {
                    listView1.Items.Remove((ListViewItem)i);
                }
           
                ListView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        //List View Using Member ID
        public void ListView()
        {

            DBUtil.open_Connection(connection);


            ListViewItem item = new ListViewItem();
            MySqlDataReader read;


            sql = $"SELECT Check_Out_Id, Date, Final_Amount  FROM check_out WHERE User_Id ='{memId}'";
            MySqlCommand my = new MySqlCommand(sql, connection);

            read = my.ExecuteReader();

            while (read.Read())
            {
                item = listView1.Items.Add(read.GetString(0));
                item.SubItems.Add(read.GetString(1));
                item.SubItems.Add(read.GetString(2));
                

            }

            connection.Close();
            my.Dispose();
            read.Dispose();
        }

        //Get Member ID
        public void get_memberID()
        {
            //Open the connection
            DBUtil.open_Connection(connection);

            //SQL Command
            sql = $"SELECT Member_Id FROM credit_member WHERE Member_Name='{Member_comboBox.SelectedItem}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            MySqlDataReader reader; //default
            reader = my.ExecuteReader();  //store the data




            while (reader.Read())
            {

                memId = reader.GetString(0);

            }


            connection.Close();
            my.Dispose();
            reader.Dispose();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Settle_btn_Click(object sender, EventArgs e)
        {

            get_memberID();

            DBUtil.open_Connection(connection);
           
            string CreditId = AutoGenarated_Ids.Generate_Id("CreID_");

            sql = $"INSERT INTO `hms_affix`.`credit_settlement` (`credit_id`, `paid_amount`, `settlement_date`, `user_id`, `Settlement_Ref_No`)" +
                $" VALUES ('{CreditId}', '{Amount_textBox.Text}', '{dateTimePicker1.Value.Date}', '{memId}', '{Ref_No_textBox.Text}')";



            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();
            MessageBox.Show("Credit Settle Success!");
            connection.Close();
            my.Dispose();

            clearItems();

            

        }

        public void clearItems()
        {
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
            foreach (Control c in groupBox2.Controls)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Genarate_ID_btn_Click(object sender, EventArgs e)
        {
            string id = AutoGenarated_Ids.Generate_Id("S_Ref_");
            Ref_No_textBox.Text = id;
        }
    }
}
