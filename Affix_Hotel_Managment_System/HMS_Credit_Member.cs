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
    public partial class HMS_Credit_Member : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;

        public HMS_Credit_Member()
        {
            InitializeComponent();
        }

        private void HMS_Credit_Member_Load(object sender, EventArgs e)
        {
            
        }


        //Data Insert
        private void Save_btn_Click(object sender, EventArgs e)
        {
            //Open the Connection
            DBUtil.open_Connection(connection);

            //Auto Genararated Id 
            string id = AutoGenarated_Ids.Generate_Id("CM");

            //SQL Command
            sql = $"INSERT INTO `hms_affix`.`credit_member` " +
                $"(`Member_Id`, `Member_Name`, `Address`, `Contact_No`, `Credit_Limit`, `Credit_Member_Ref_No`, `Email`) " +
                $"VALUES ('{MemberId_textBox1.Text}', '{MemberName_textBox1.Text}', '{Address_richTextBox1.Text}', '{Contact_textBox1.Text}', '{CreditLimit_textBox1.Text}', '{id}', '{Email_textBox1.Text}')";


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
                else if (c is RichTextBox)
                {
                    c.Text = "";
                }
            }


        }


        //data view
        private void View_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the connection
                DBUtil.open_Connection(connection);


                sql = $"SELECT * FROM credit_member WHERE Member_Id='{MemberId_textBox1.Text}' or Member_Name='{MemberName_textBox1.Text}'";
                MySqlCommand my = new MySqlCommand(sql, connection);
                MySqlDataReader reader; //default
                reader = my.ExecuteReader();  //store the data

                while (reader.Read())
                {
                    MemberId_textBox1.Text = reader.GetString(0);
                    MemberName_textBox1.Text = reader.GetString(1);
                    Address_richTextBox1.Text = reader.GetString(2);
                    Contact_textBox1.Text = reader.GetString(3);
                    Email_textBox1.Text = reader.GetString(6);
                    CreditLimit_textBox1.Text = reader.GetString(4);
                    
                }
                connection.Close();
                my.Dispose();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);

            sql = $" DELETE FROM credit_member WHERE Member_Id='{MemberId_textBox1.Text}' or Member_Name='{MemberName_textBox1.Text}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Successfully Deleted ");

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
                else if (c is RichTextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //Open the connection
            DBUtil.open_Connection(connection);

            sql = $"UPDATE `hms_affix`.`credit_member` SET `Member_Id` = '{MemberId_textBox1.Text}', `Member_Name` = '{MemberName_textBox1.Text}'," +
                $" `Address` = '{Address_richTextBox1.Text}', `Contact_No` = '{Contact_textBox1.Text}', `Credit_Limit` = '{CreditLimit_textBox1.Text}'," +
                $" `Email` = '{Email_textBox1.Text}' WHERE Member_Id='{MemberId_textBox1.Text}' or Member_Name='{MemberName_textBox1.Text}'";

            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Successfully Updated ");

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
                else if (c is RichTextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
