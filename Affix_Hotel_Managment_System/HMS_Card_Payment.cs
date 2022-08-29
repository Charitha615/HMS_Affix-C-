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
    public partial class HMS_Card_Payment : Form
    {

        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;
        public HMS_Card_Payment()
        {
            InitializeComponent();  
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PayNow_btn_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);

            string id = AutoGenarated_Ids.Generate_Id("Pay_set_c");
            string cardId = AutoGenarated_Ids.Generate_Id("CardId");

            sql = $"INSERT INTO `hms_affix`.`card` ( `Card_Id`,`Card_No`, `Card_ExpDate`, `Payement_Ref_Id`, `Card_Name`,`Card_CVV`) " +
                $"VALUES('{cardId}','{CardNumber_textBox.Text}', " +
                $"'{Expiration_textBox.Text}', '{id}', '{CardName_textBox.Text}','{Cvv_textBox.Text}')";

            
            MySqlCommand my = new MySqlCommand(sql,connection);
            my.ExecuteNonQuery();
            MessageBox.Show("Payment Success!");
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
            Close();
        }

        private void HMS_Card_Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
