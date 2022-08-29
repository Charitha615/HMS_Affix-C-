namespace Affix_Hotel_Managment_System
{
    partial class HMS_Purchasing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMS_Purchasing));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HouseKeeping_radio = new System.Windows.Forms.RadioButton();
            this.Bar_radio = new System.Windows.Forms.RadioButton();
            this.Kitchen_radio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Items_ingrediants_listbox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Price_txtbox = new System.Windows.Forms.TextBox();
            this.Qty_txtbox = new System.Windows.Forms.TextBox();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Qty_lbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Total_Amount_txtbox = new System.Windows.Forms.TextBox();
            this.No_Of_Items_txtbox = new System.Windows.Forms.TextBox();
            this.Total_Amount_lbl = new System.Windows.Forms.Label();
            this.Total_No_lbl = new System.Windows.Forms.Label();
            this.Purchasing_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ref_No_btn = new System.Windows.Forms.Button();
            this.Ref_No_txtbox = new System.Windows.Forms.TextBox();
            this.Invoice_No_txtbox = new System.Windows.Forms.TextBox();
            this.Invoice_Date_lbl = new System.Windows.Forms.Label();
            this.Invoice_No_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HouseKeeping_radio);
            this.groupBox1.Controls.Add(this.Bar_radio);
            this.groupBox1.Controls.Add(this.Kitchen_radio);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select The Category";
            // 
            // HouseKeeping_radio
            // 
            this.HouseKeeping_radio.AutoSize = true;
            this.HouseKeeping_radio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseKeeping_radio.Location = new System.Drawing.Point(206, 26);
            this.HouseKeeping_radio.Name = "HouseKeeping_radio";
            this.HouseKeeping_radio.Size = new System.Drawing.Size(122, 20);
            this.HouseKeeping_radio.TabIndex = 2;
            this.HouseKeeping_radio.TabStop = true;
            this.HouseKeeping_radio.Text = "House Keeping";
            this.HouseKeeping_radio.UseVisualStyleBackColor = true;
            // 
            // Bar_radio
            // 
            this.Bar_radio.AutoSize = true;
            this.Bar_radio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar_radio.Location = new System.Drawing.Point(123, 26);
            this.Bar_radio.Name = "Bar_radio";
            this.Bar_radio.Size = new System.Drawing.Size(48, 20);
            this.Bar_radio.TabIndex = 1;
            this.Bar_radio.TabStop = true;
            this.Bar_radio.Text = "Bar";
            this.Bar_radio.UseVisualStyleBackColor = true;
            // 
            // Kitchen_radio
            // 
            this.Kitchen_radio.AutoSize = true;
            this.Kitchen_radio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kitchen_radio.Location = new System.Drawing.Point(22, 26);
            this.Kitchen_radio.Name = "Kitchen_radio";
            this.Kitchen_radio.Size = new System.Drawing.Size(73, 20);
            this.Kitchen_radio.TabIndex = 0;
            this.Kitchen_radio.TabStop = true;
            this.Kitchen_radio.Text = "Kitchen";
            this.Kitchen_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Items_ingrediants_listbox);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(192, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrediants/Items";
            // 
            // Items_ingrediants_listbox
            // 
            this.Items_ingrediants_listbox.FormattingEnabled = true;
            this.Items_ingrediants_listbox.ItemHeight = 16;
            this.Items_ingrediants_listbox.Location = new System.Drawing.Point(6, 22);
            this.Items_ingrediants_listbox.Name = "Items_ingrediants_listbox";
            this.Items_ingrediants_listbox.Size = new System.Drawing.Size(335, 100);
            this.Items_ingrediants_listbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Remove_btn);
            this.groupBox3.Controls.Add(this.Add_btn);
            this.groupBox3.Controls.Add(this.Price_txtbox);
            this.groupBox3.Controls.Add(this.Qty_txtbox);
            this.groupBox3.Controls.Add(this.Price_lbl);
            this.groupBox3.Controls.Add(this.Qty_lbl);
            this.groupBox3.Location = new System.Drawing.Point(545, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 135);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.Location = new System.Drawing.Point(94, 87);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(79, 35);
            this.Remove_btn.TabIndex = 5;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(6, 87);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(79, 35);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // Price_txtbox
            // 
            this.Price_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_txtbox.Location = new System.Drawing.Point(54, 57);
            this.Price_txtbox.Name = "Price_txtbox";
            this.Price_txtbox.Size = new System.Drawing.Size(119, 23);
            this.Price_txtbox.TabIndex = 3;
            // 
            // Qty_txtbox
            // 
            this.Qty_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_txtbox.Location = new System.Drawing.Point(54, 22);
            this.Qty_txtbox.Name = "Qty_txtbox";
            this.Qty_txtbox.Size = new System.Drawing.Size(119, 23);
            this.Qty_txtbox.TabIndex = 2;
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(6, 57);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(40, 16);
            this.Price_lbl.TabIndex = 1;
            this.Price_lbl.Text = "Price";
            // 
            // Qty_lbl
            // 
            this.Qty_lbl.AutoSize = true;
            this.Qty_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_lbl.Location = new System.Drawing.Point(7, 25);
            this.Qty_lbl.Name = "Qty_lbl";
            this.Qty_lbl.Size = new System.Drawing.Size(30, 16);
            this.Qty_lbl.TabIndex = 0;
            this.Qty_lbl.Text = "Qty";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Total_Amount_txtbox);
            this.groupBox4.Controls.Add(this.No_Of_Items_txtbox);
            this.groupBox4.Controls.Add(this.Total_Amount_lbl);
            this.groupBox4.Controls.Add(this.Total_No_lbl);
            this.groupBox4.Controls.Add(this.Purchasing_listview);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(192, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 223);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // Total_Amount_txtbox
            // 
            this.Total_Amount_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Amount_txtbox.Location = new System.Drawing.Point(417, 188);
            this.Total_Amount_txtbox.Name = "Total_Amount_txtbox";
            this.Total_Amount_txtbox.Size = new System.Drawing.Size(109, 23);
            this.Total_Amount_txtbox.TabIndex = 17;
            // 
            // No_Of_Items_txtbox
            // 
            this.No_Of_Items_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Of_Items_txtbox.Location = new System.Drawing.Point(201, 188);
            this.No_Of_Items_txtbox.Name = "No_Of_Items_txtbox";
            this.No_Of_Items_txtbox.Size = new System.Drawing.Size(99, 23);
            this.No_Of_Items_txtbox.TabIndex = 16;
            // 
            // Total_Amount_lbl
            // 
            this.Total_Amount_lbl.AutoSize = true;
            this.Total_Amount_lbl.Location = new System.Drawing.Point(321, 188);
            this.Total_Amount_lbl.Name = "Total_Amount_lbl";
            this.Total_Amount_lbl.Size = new System.Drawing.Size(89, 16);
            this.Total_Amount_lbl.TabIndex = 15;
            this.Total_Amount_lbl.Text = "Total Amount";
            // 
            // Total_No_lbl
            // 
            this.Total_No_lbl.AutoSize = true;
            this.Total_No_lbl.Location = new System.Drawing.Point(6, 188);
            this.Total_No_lbl.Name = "Total_No_lbl";
            this.Total_No_lbl.Size = new System.Drawing.Size(189, 16);
            this.Total_No_lbl.TabIndex = 14;
            this.Total_No_lbl.Text = "Total No Of Ingrediants/Items";
            // 
            // Purchasing_listview
            // 
            this.Purchasing_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Purchasing_listview.HideSelection = false;
            this.Purchasing_listview.Location = new System.Drawing.Point(6, 15);
            this.Purchasing_listview.Name = "Purchasing_listview";
            this.Purchasing_listview.Size = new System.Drawing.Size(520, 162);
            this.Purchasing_listview.TabIndex = 13;
            this.Purchasing_listview.UseCompatibleStateImageBehavior = false;
            this.Purchasing_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ingrediant/Item Name";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty Type";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount Per Qty";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 257;
            // 
            // Ref_No_btn
            // 
            this.Ref_No_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_No_btn.Location = new System.Drawing.Point(191, 12);
            this.Ref_No_btn.Name = "Ref_No_btn";
            this.Ref_No_btn.Size = new System.Drawing.Size(168, 29);
            this.Ref_No_btn.TabIndex = 5;
            this.Ref_No_btn.Text = "Generate Ref. No";
            this.Ref_No_btn.UseVisualStyleBackColor = true;
            this.Ref_No_btn.Click += new System.EventHandler(this.Ref_No_btn_Click);
            // 
            // Ref_No_txtbox
            // 
            this.Ref_No_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_No_txtbox.Location = new System.Drawing.Point(366, 15);
            this.Ref_No_txtbox.Name = "Ref_No_txtbox";
            this.Ref_No_txtbox.Size = new System.Drawing.Size(173, 23);
            this.Ref_No_txtbox.TabIndex = 6;
            // 
            // Invoice_No_txtbox
            // 
            this.Invoice_No_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_No_txtbox.Location = new System.Drawing.Point(554, 85);
            this.Invoice_No_txtbox.Name = "Invoice_No_txtbox";
            this.Invoice_No_txtbox.Size = new System.Drawing.Size(169, 23);
            this.Invoice_No_txtbox.TabIndex = 8;
            // 
            // Invoice_Date_lbl
            // 
            this.Invoice_Date_lbl.AutoSize = true;
            this.Invoice_Date_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_Date_lbl.Location = new System.Drawing.Point(550, 14);
            this.Invoice_Date_lbl.Name = "Invoice_Date_lbl";
            this.Invoice_Date_lbl.Size = new System.Drawing.Size(86, 16);
            this.Invoice_Date_lbl.TabIndex = 9;
            this.Invoice_Date_lbl.Text = "Invoice Date";
            // 
            // Invoice_No_lbl
            // 
            this.Invoice_No_lbl.AutoSize = true;
            this.Invoice_No_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_No_lbl.Location = new System.Drawing.Point(551, 66);
            this.Invoice_No_lbl.Name = "Invoice_No_lbl";
            this.Invoice_No_lbl.Size = new System.Drawing.Size(73, 16);
            this.Invoice_No_lbl.TabIndex = 10;
            this.Invoice_No_lbl.Text = "Invoice No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(630, 481);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(79, 35);
            this.Close_btn.TabIndex = 15;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(516, 481);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(79, 35);
            this.Save_btn.TabIndex = 14;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            // 
            // HMS_Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 524);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Invoice_No_lbl);
            this.Controls.Add(this.Invoice_Date_lbl);
            this.Controls.Add(this.Invoice_No_txtbox);
            this.Controls.Add(this.Ref_No_txtbox);
            this.Controls.Add(this.Ref_No_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(727, 554);
            this.Name = "HMS_Purchasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HMS_Purchasing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton HouseKeeping_radio;
        private System.Windows.Forms.RadioButton Bar_radio;
        private System.Windows.Forms.RadioButton Kitchen_radio;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox Price_txtbox;
        private System.Windows.Forms.TextBox Qty_txtbox;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label Qty_lbl;
        private System.Windows.Forms.Button Ref_No_btn;
        private System.Windows.Forms.TextBox Ref_No_txtbox;
        private System.Windows.Forms.TextBox Invoice_No_txtbox;
        private System.Windows.Forms.Label Invoice_Date_lbl;
        private System.Windows.Forms.Label Invoice_No_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox Items_ingrediants_listbox;
        private System.Windows.Forms.Label Total_Amount_lbl;
        private System.Windows.Forms.Label Total_No_lbl;
        private System.Windows.Forms.ListView Purchasing_listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox Total_Amount_txtbox;
        private System.Windows.Forms.TextBox No_Of_Items_txtbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Save_btn;
    }
}