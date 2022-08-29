namespace Affix_Hotel_Managment_System
{
    partial class HMS_Day_Progress_Of_Bar_Stock
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
            this.Wasting_listview = new System.Windows.Forms.ListView();
            this.Wasting_Item_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wasting_Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Progress_listview = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From_main_Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Forwarded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wasted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transfered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Progress_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Bar_Tender_combo = new System.Windows.Forms.ComboBox();
            this.Transfering_Qty_txtbox = new System.Windows.Forms.TextBox();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Forward_btn = new System.Windows.Forms.Button();
            this.Bar_Tender_lbl = new System.Windows.Forms.Label();
            this.Transfering_Qty_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Forward_listview = new System.Windows.Forms.ListView();
            this.Bar_Tender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.Ref_No_txtbox = new System.Windows.Forms.TextBox();
            this.Ref_No_btn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Bring_fwd_lbl = new System.Windows.Forms.Label();
            this.Wasted_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wasting_listview
            // 
            this.Wasting_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Wasting_Item_Name,
            this.Wasting_Qty,
            this.Remarks});
            this.Wasting_listview.HideSelection = false;
            this.Wasting_listview.Location = new System.Drawing.Point(324, 142);
            this.Wasting_listview.Name = "Wasting_listview";
            this.Wasting_listview.Size = new System.Drawing.Size(402, 113);
            this.Wasting_listview.TabIndex = 14;
            this.Wasting_listview.UseCompatibleStateImageBehavior = false;
            this.Wasting_listview.View = System.Windows.Forms.View.Details;
            // 
            // Wasting_Item_Name
            // 
            this.Wasting_Item_Name.Text = "Wasting_Item_Name";
            this.Wasting_Item_Name.Width = 176;
            // 
            // Wasting_Qty
            // 
            this.Wasting_Qty.Text = "Wasting_Qty";
            this.Wasting_Qty.Width = 93;
            // 
            // Remarks
            // 
            this.Remarks.Text = "Remarks";
            this.Remarks.Width = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Progress_listview);
            this.groupBox1.Controls.Add(this.Progress_btn);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Date_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // Progress_listview
            // 
            this.Progress_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Qty_Type,
            this.From_main_Stock,
            this.Forwarded,
            this.Total,
            this.Wasted,
            this.Balance,
            this.Transfered});
            this.Progress_listview.HideSelection = false;
            this.Progress_listview.Location = new System.Drawing.Point(10, 55);
            this.Progress_listview.Name = "Progress_listview";
            this.Progress_listview.Size = new System.Drawing.Size(716, 134);
            this.Progress_listview.TabIndex = 4;
            this.Progress_listview.UseCompatibleStateImageBehavior = false;
            this.Progress_listview.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 145;
            // 
            // Qty_Type
            // 
            this.Qty_Type.Text = "Qty Type";
            this.Qty_Type.Width = 68;
            // 
            // From_main_Stock
            // 
            this.From_main_Stock.Text = "From main Stock";
            this.From_main_Stock.Width = 117;
            // 
            // Forwarded
            // 
            this.Forwarded.Text = "Forwarded";
            this.Forwarded.Width = 72;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 76;
            // 
            // Wasted
            // 
            this.Wasted.Text = "Wasted";
            this.Wasted.Width = 78;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.Width = 84;
            // 
            // Transfered
            // 
            this.Transfered.Text = "Transfered";
            this.Transfered.Width = 77;
            // 
            // Progress_btn
            // 
            this.Progress_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_btn.Location = new System.Drawing.Point(358, 15);
            this.Progress_btn.Name = "Progress_btn";
            this.Progress_btn.Size = new System.Drawing.Size(176, 35);
            this.Progress_btn.TabIndex = 2;
            this.Progress_btn.Text = "Generate The Progress";
            this.Progress_btn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(156, 26);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(38, 16);
            this.Date_lbl.TabIndex = 0;
            this.Date_lbl.Text = "Date";
            // 
            // Bar_Tender_combo
            // 
            this.Bar_Tender_combo.FormattingEnabled = true;
            this.Bar_Tender_combo.Location = new System.Drawing.Point(128, 55);
            this.Bar_Tender_combo.Name = "Bar_Tender_combo";
            this.Bar_Tender_combo.Size = new System.Drawing.Size(190, 24);
            this.Bar_Tender_combo.TabIndex = 7;
            // 
            // Transfering_Qty_txtbox
            // 
            this.Transfering_Qty_txtbox.Location = new System.Drawing.Point(128, 29);
            this.Transfering_Qty_txtbox.Name = "Transfering_Qty_txtbox";
            this.Transfering_Qty_txtbox.Size = new System.Drawing.Size(190, 23);
            this.Transfering_Qty_txtbox.TabIndex = 6;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.Location = new System.Drawing.Point(239, 85);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(79, 35);
            this.Remove_btn.TabIndex = 4;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            // 
            // Forward_btn
            // 
            this.Forward_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_btn.Location = new System.Drawing.Point(10, 85);
            this.Forward_btn.Name = "Forward_btn";
            this.Forward_btn.Size = new System.Drawing.Size(79, 35);
            this.Forward_btn.TabIndex = 3;
            this.Forward_btn.Text = "Forward";
            this.Forward_btn.UseVisualStyleBackColor = true;
            // 
            // Bar_Tender_lbl
            // 
            this.Bar_Tender_lbl.AutoSize = true;
            this.Bar_Tender_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar_Tender_lbl.Location = new System.Drawing.Point(10, 60);
            this.Bar_Tender_lbl.Name = "Bar_Tender_lbl";
            this.Bar_Tender_lbl.Size = new System.Drawing.Size(78, 16);
            this.Bar_Tender_lbl.TabIndex = 2;
            this.Bar_Tender_lbl.Text = "Bar Tender";
            // 
            // Transfering_Qty_lbl
            // 
            this.Transfering_Qty_lbl.AutoSize = true;
            this.Transfering_Qty_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfering_Qty_lbl.Location = new System.Drawing.Point(10, 29);
            this.Transfering_Qty_lbl.Name = "Transfering_Qty_lbl";
            this.Transfering_Qty_lbl.Size = new System.Drawing.Size(106, 16);
            this.Transfering_Qty_lbl.TabIndex = 1;
            this.Transfering_Qty_lbl.Text = "Transfering Qty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Wasted_btn);
            this.groupBox2.Controls.Add(this.Forward_listview);
            this.groupBox2.Controls.Add(this.Bar_Tender_combo);
            this.groupBox2.Controls.Add(this.Wasting_listview);
            this.groupBox2.Controls.Add(this.Transfering_Qty_txtbox);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.Remove_btn);
            this.groupBox2.Controls.Add(this.Forward_btn);
            this.groupBox2.Controls.Add(this.Bar_Tender_lbl);
            this.groupBox2.Controls.Add(this.Transfering_Qty_lbl);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 263);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forward The Balance Stock";
            // 
            // Forward_listview
            // 
            this.Forward_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bar_Tender,
            this.Item_Name,
            this.Qty});
            this.Forward_listview.HideSelection = false;
            this.Forward_listview.Location = new System.Drawing.Point(324, 17);
            this.Forward_listview.Name = "Forward_listview";
            this.Forward_listview.Size = new System.Drawing.Size(402, 119);
            this.Forward_listview.TabIndex = 8;
            this.Forward_listview.UseCompatibleStateImageBehavior = false;
            this.Forward_listview.View = System.Windows.Forms.View.Details;
            // 
            // Bar_Tender
            // 
            this.Bar_Tender.Text = "Bar_Tender";
            this.Bar_Tender.Width = 160;
            // 
            // Item_Name
            // 
            this.Item_Name.Text = "Item_Name";
            this.Item_Name.Width = 177;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Close_btn);
            this.groupBox4.Controls.Add(this.Transfer_btn);
            this.groupBox4.Controls.Add(this.Ref_No_txtbox);
            this.groupBox4.Controls.Add(this.Ref_No_btn);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.Bring_fwd_lbl);
            this.groupBox4.Location = new System.Drawing.Point(13, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 134);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(220, 89);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(79, 35);
            this.Close_btn.TabIndex = 5;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer_btn.Location = new System.Drawing.Point(11, 89);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(200, 35);
            this.Transfer_btn.TabIndex = 4;
            this.Transfer_btn.Text = "Transfer The Balance Stock";
            this.Transfer_btn.UseVisualStyleBackColor = true;
            // 
            // Ref_No_txtbox
            // 
            this.Ref_No_txtbox.Location = new System.Drawing.Point(149, 56);
            this.Ref_No_txtbox.Name = "Ref_No_txtbox";
            this.Ref_No_txtbox.Size = new System.Drawing.Size(150, 23);
            this.Ref_No_txtbox.TabIndex = 3;
            // 
            // Ref_No_btn
            // 
            this.Ref_No_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_No_btn.Location = new System.Drawing.Point(11, 48);
            this.Ref_No_btn.Name = "Ref_No_btn";
            this.Ref_No_btn.Size = new System.Drawing.Size(132, 35);
            this.Ref_No_btn.TabIndex = 2;
            this.Ref_No_btn.Text = "Generate Ref No";
            this.Ref_No_btn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // Bring_fwd_lbl
            // 
            this.Bring_fwd_lbl.AutoSize = true;
            this.Bring_fwd_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bring_fwd_lbl.Location = new System.Drawing.Point(7, 20);
            this.Bring_fwd_lbl.Name = "Bring_fwd_lbl";
            this.Bring_fwd_lbl.Size = new System.Drawing.Size(135, 16);
            this.Bring_fwd_lbl.TabIndex = 0;
            this.Bring_fwd_lbl.Text = "Bringing Forward To";
            // 
            // Wasted_btn
            // 
            this.Wasted_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wasted_btn.Location = new System.Drawing.Point(128, 85);
            this.Wasted_btn.Name = "Wasted_btn";
            this.Wasted_btn.Size = new System.Drawing.Size(79, 35);
            this.Wasted_btn.TabIndex = 15;
            this.Wasted_btn.Text = "Wasted";
            this.Wasted_btn.UseVisualStyleBackColor = true;
            // 
            // HMS_Day_Progress_Of_Bar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HMS_Day_Progress_Of_Bar_Stock";
            this.Text = "HMS_Day_Progress_Of_Bar_Stock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Progress_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.ComboBox Bar_Tender_combo;
        private System.Windows.Forms.TextBox Transfering_Qty_txtbox;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Forward_btn;
        private System.Windows.Forms.Label Bar_Tender_lbl;
        private System.Windows.Forms.Label Transfering_Qty_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Transfer_btn;
        private System.Windows.Forms.TextBox Ref_No_txtbox;
        private System.Windows.Forms.Button Ref_No_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Bring_fwd_lbl;
        private System.Windows.Forms.ListView Progress_listview;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Qty_Type;
        private System.Windows.Forms.ColumnHeader From_main_Stock;
        private System.Windows.Forms.ColumnHeader Forwarded;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Wasted;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader Transfered;
        private System.Windows.Forms.ListView Forward_listview;
        private System.Windows.Forms.ColumnHeader Bar_Tender;
        private System.Windows.Forms.ColumnHeader Item_Name;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ListView Wasting_listview;
        private System.Windows.Forms.ColumnHeader Wasting_Item_Name;
        private System.Windows.Forms.ColumnHeader Wasting_Qty;
        private System.Windows.Forms.ColumnHeader Remarks;
        private System.Windows.Forms.Button Wasted_btn;
    }
}