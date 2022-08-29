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
    public partial class HMS_Add_Room_Charges : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;

        public HMS_Add_Room_Charges()
        {
            InitializeComponent();
        }

        private void HMS_Add_Room_Charges_Load(object sender, EventArgs e)
        {

            //Load the Other facility combobox
            ComponentClass.add_To_Combo(connection, Other_facility_comboBox2, "Facility_Name", "chargeable_facility");
        }
    }
}
