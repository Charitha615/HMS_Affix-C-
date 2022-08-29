using Add_Delete_Currency;
using Check_In;
using Check_Out;
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
    public partial class HMS_Main_Menu : Form
    {
        public HMS_Main_Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Reservation_btn_Clicked(object sender, EventArgs e)
        {
            // Open Reservation Screeen
            blur_imagebox.Visible = true;
            HMS_Reservation hMS_Reservation = new HMS_Reservation();
            hMS_Reservation.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Check_In_btn_Clicked(object sender, EventArgs e)
        {
            // Open Check in Screeen
            blur_imagebox.Visible = true;
            HMS_CheckIn hMS_CheckIn = new HMS_CheckIn();
            hMS_CheckIn.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Room_Availability_btn_Clicked(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
           
            blur_imagebox.Visible = false;
        }

        private void Check_Out_btn_Clicked(object sender, EventArgs e)
        {
            // Open Check out Screeen
            blur_imagebox.Visible = true;
            HMS_CheckOut hMS_CheckOut = new HMS_CheckOut();
            hMS_CheckOut.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Block_Romms_btn_Clicked(object sender, EventArgs e)
        {
            // Open Room bloking Screeen
            blur_imagebox.Visible = true;
            HMS_Block_Rooms block_room_Screen = new HMS_Block_Rooms();
            block_room_Screen.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Unblock_Rooms_btn_Clicked(object sender, EventArgs e)
        {
            // Open Room unblocking Screeen
            blur_imagebox.Visible = true;
            HMS_Unblock_Rooms unblock_Rooms = new HMS_Unblock_Rooms();
            unblock_Rooms.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Restuarant_btn_Clicked(object sender, EventArgs e)
        {
            // Open Restaurant System Screeen
            HMS_Resurant hMS_Resurant = new HMS_Resurant();
            blur_imagebox.Visible = true;
            hMS_Resurant.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void POS_btn_Clicked(object sender, EventArgs e)
        {
            // Open Point of sale Screeen
            HMS_POS hMS_POS = new HMS_POS();
            blur_imagebox.Visible = true;
            hMS_POS.ShowDialog();
            blur_imagebox.Visible = false;
            
        }

        private void Room_Food_Managment_btn_Clicked(object sender, EventArgs e)
        {
            // Open Room Food Management Screeen
            blur_imagebox.Visible = true;
            HMS_Daily_Room_Overview hMS_Room_Food_Mangement = new HMS_Daily_Room_Overview();
            hMS_Room_Food_Mangement.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Credit_Settlement_btn_Clicked(object sender, EventArgs e)
        {
            //open credit settelment
            blur_imagebox.Visible = true;
           HMS_Credit_Settlement hMS_Credit_Settlement = new HMS_Credit_Settlement();
            hMS_Credit_Settlement.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Room_Charges_btn_Clicked(object sender, EventArgs e)
        {
            //// Open Room Charges Screeen
            blur_imagebox.Visible = true;
            HMS_Add_Room_Charges hMS_Add_Room_Charges = new HMS_Add_Room_Charges();
            hMS_Add_Room_Charges.ShowDialog();
            blur_imagebox.Visible = false; 
        }

        private void Desk_Clerk_btn_Clicked(object sender, EventArgs e)
        {
            // Open Desk clerk progress screen
            blur_imagebox.Visible = true;
            HMS_Desk_Clerk hMS_Desk_Clerk = new HMS_Desk_Clerk();
            hMS_Desk_Clerk.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void Exit_btn_Clicked(object sender, EventArgs e)
        {
            //Prompt a "are yu sure" message and if yes is preessed exit the program
            MessageBox.Show("Do you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            Close();
        }

        private void Lock_workStation_btn_Clicked(object sender, EventArgs e)
        {
            //Work station will locked until user credentials are entered again
            blur_imagebox.Visible = true;

            blur_imagebox.Visible = false;
        }

        private void roomClearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cleaning details of rooms
            blur_imagebox.Visible = true;
            HMS_Room_Cleaning room_Cleaning = new HMS_Room_Cleaning();
            room_Cleaning.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Open printer defining page Screeen
            blur_imagebox.Visible = true;
            HMS_Define_Printers define_Printers = new HMS_Define_Printers();
            define_Printers.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addIngrediantsItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open add ingrediants screen
            blur_imagebox.Visible = true;
            HMS_Add_New_Ingredients add_New_Ingredients = new HMS_Add_New_Ingredients();
            add_New_Ingredients.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addQtyTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Open Add quantity type  Screeen
            blur_imagebox.Visible = true;
            HMS_Add_Ingredient_Qty_Types hMS_Add_Ingredient_Qty_Types = new HMS_Add_Ingredient_Qty_Types();
            hMS_Add_Ingredient_Qty_Types.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addCuttleriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Add and edit cutlaries Screeen
            blur_imagebox.Visible = true;
            HMS_Add_Edit_Cutleries add_Edit_Cutleries = new HMS_Add_Edit_Cutleries();
            add_Edit_Cutleries.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void declareIngrediantsItemsCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Screeen to declare ingrediants cost 
            blur_imagebox.Visible = true;
            HMS_Declare_Item_Cost hMS_Declare_Item_Cost = new HMS_Declare_Item_Cost();
            hMS_Declare_Item_Cost.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addVictualsPortionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Screeen to make victuals using ingrediants
            blur_imagebox.Visible = true;
            HMS_Add_Victuals_Portions hMS_Add_Victuals_Portions = new HMS_Add_Victuals_Portions();
            hMS_Add_Victuals_Portions.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void setMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Screeen to make set menus using the victuals
            blur_imagebox.Visible = true;
            HMS_Set_Menus hMS_Set_Menus = new HMS_Set_Menus();
            hMS_Set_Menus.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void HMS_Main_Menu_Load(object sender, EventArgs e)
        {
            /*The blured image of the screen is at behind 
              when the Main form is loaded the image will come tro front and its visibility will set to false*/
            blur_imagebox.BringToFront(); 
            blur_imagebox.Visible = false;

            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / (ourScreenWidth);
            float scaleFactorHeigth = (float)ourScreenHeight / (ourScreenHeight);
            
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);

            Scale(scaleFactor);
            // center the resized screen.
            CenterToScreen();


        }

        private void addAminetiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open add amainityies page
            blur_imagebox.Visible = true;
            HMS_Add_Room_Amenities hMS_Add_Room_Amenities = new HMS_Add_Room_Amenities();
            hMS_Add_Room_Amenities.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //open add aminties page 
            blur_imagebox.Visible = true;
            HMS_Add_Room_Types hMS_Add_Room_Types = new HMS_Add_Room_Types();
            hMS_Add_Room_Types.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void rateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open screen to add rate type
            blur_imagebox.Visible = true;
            HMS_Rate_Type hMS_Rate_Type = new HMS_Rate_Type();
            hMS_Rate_Type.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addNewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open screen to add rooms
            blur_imagebox.Visible = true;
            HMS_Add_New_Room hMS_Add_New_Room = new HMS_Add_New_Room();
            hMS_Add_New_Room.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //blur_imagebox.Visible = true;
            //HMS_Add_Agent hMS_Add_Agent = new HMS_Add_Agent();
            //hMS_Add_Agent.ShowDialog();
            //blur_imagebox.Visible = false;
        }

        private void roomShiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open screen for room shifting
            blur_imagebox.Visible = true;
            HMS_Room_Shifting hMS_Room_Shifting = new HMS_Room_Shifting();
            hMS_Room_Shifting.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void newAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open screen add agent to the system
            blur_imagebox.Visible = true;
            HMS_Add_Agent hMS_Add_Agent = new HMS_Add_Agent();
            hMS_Add_Agent.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMS_Purchasing hMS_Purchasing = new HMS_Purchasing();
            blur_imagebox.Visible = true;
            hMS_Purchasing.ShowDialog();
            blur_imagebox.Visible = false;
            

        }

        private void goodIssueToKitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMS_Good_Issuing_to_Kitchen hMS_Good_Issuing_To_Kitchen = new HMS_Good_Issuing_to_Kitchen();
            blur_imagebox.Visible = true;
            hMS_Good_Issuing_To_Kitchen.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void goodIssueToBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Good__issue_To_Bar hMS_Good__Issue_To_Bar = new HMS_Good__issue_To_Bar();
            hMS_Good__Issue_To_Bar.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void goodIssueToHKDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Good_Issuing_To_HK_Department hMS_Good_Issuing_To_HK_Department = new HMS_Good_Issuing_To_HK_Department();
            hMS_Good_Issuing_To_HK_Department.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void dayProgressKitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Day_Progress_Of_Kitchen_Stock hMS_Day_Progress_Of_Kitchen_Stock = new HMS_Day_Progress_Of_Kitchen_Stock();
            hMS_Day_Progress_Of_Kitchen_Stock.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void dayProgressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Day_Progress_Of_Bar_Stock hMS_Day_Progress_Of_Bar_Stock = new HMS_Day_Progress_Of_Bar_Stock();
            hMS_Day_Progress_Of_Bar_Stock.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void dayProgressHKDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Day_Progress_Of_HK_Stock hMS_Day_Progress_Of_HK = new HMS_Day_Progress_Of_HK_Stock();
            hMS_Day_Progress_Of_HK.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void issueCutlaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Cutlery_Issuing hMS_Cutlery_Issuing = new HMS_Cutlery_Issuing();
            hMS_Cutlery_Issuing.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void settleCularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Settling_Cutleries hMS_Settling_Cutleries = new HMS_Settling_Cutleries();
            hMS_Settling_Cutleries.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void reportGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lockWorkStationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foodOfTheDayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foreignCurrencvyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Add_Delete_Currency hMS_Add_Delete_Currency = new HMS_Add_Delete_Currency();
            hMS_Add_Delete_Currency.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void taxserviceChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Tax_ServiceCharge hMS_Tax_ServiceCharge = new HMS_Tax_ServiceCharge();
            hMS_Tax_ServiceCharge.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void creditMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Credit_Member hMS_Credit_Member = new HMS_Credit_Member();
            hMS_Credit_Member.ShowDialog();
            blur_imagebox.Visible = false;
            
        }

        private void housekeepingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void declareHKItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMS_HouseKeeping_Items_To_Rooms hMS_HouseKeeping_Items_To_Rooms = new HMS_HouseKeeping_Items_To_Rooms();
            hMS_HouseKeeping_Items_To_Rooms.ShowDialog();
        }

        private void chargableFacilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Add_Chargable_Facilities hMS_Add_Chargable_Facilities = new HMS_Add_Chargable_Facilities();
            hMS_Add_Chargable_Facilities.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void pettyCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Cash_in_out hMS_Cash_In_Out = new HMS_Cash_in_out();
            hMS_Cash_In_Out.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void editReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Edit_Reservation hMS_Edit_Reservation = new HMS_Edit_Reservation();
            hMS_Edit_Reservation.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Add_Staff hMS_Add_Staff = new HMS_Add_Staff();
            hMS_Add_Staff.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addStaffTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Add_Staff_Type hMS_Add_Staff_Type = new HMS_Add_Staff_Type();
            hMS_Add_Staff_Type.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void addAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blur_imagebox.Visible = true;
            HMS_Add_Agent hMS_Add_Agent = new HMS_Add_Agent();
            hMS_Add_Agent.ShowDialog();
            blur_imagebox.Visible = false;
        }

        private void foodBevaragesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
