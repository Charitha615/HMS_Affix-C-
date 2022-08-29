namespace Affix_Hotel_Managment_System
{
    partial class HMS_Add_Edit_Cutleries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMS_Add_Edit_Cutleries));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cutlery_listview = new System.Windows.Forms.ListView();
            this.Item_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock_In_Hand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category_combo = new System.Windows.Forms.ComboBox();
            this.Category_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.StockInHand_txtbox = new System.Windows.Forms.TextBox();
            this.ItemName_txtbox = new System.Windows.Forms.TextBox();
            this.StockInHand_lbl = new System.Windows.Forms.Label();
            this.ItemName_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cutlery_listview);
            this.groupBox1.Controls.Add(this.Category_combo);
            this.groupBox1.Controls.Add(this.Category_lbl);
            this.groupBox1.Location = new System.Drawing.Point(179, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cutlery_listview
            // 
            this.cutlery_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item_Name,
            this.Stock_In_Hand});
            this.cutlery_listview.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutlery_listview.HideSelection = false;
            this.cutlery_listview.Location = new System.Drawing.Point(11, 41);
            this.cutlery_listview.Name = "cutlery_listview";
            this.cutlery_listview.Size = new System.Drawing.Size(299, 159);
            this.cutlery_listview.TabIndex = 5;
            this.cutlery_listview.UseCompatibleStateImageBehavior = false;
            this.cutlery_listview.View = System.Windows.Forms.View.Details;
            // 
            // Item_Name
            // 
            this.Item_Name.Text = "Item Name";
            this.Item_Name.Width = 196;
            // 
            // Stock_In_Hand
            // 
            this.Stock_In_Hand.Text = "Stock in Hand";
            this.Stock_In_Hand.Width = 101;
            // 
            // Category_combo
            // 
            this.Category_combo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_combo.FormattingEnabled = true;
            this.Category_combo.Location = new System.Drawing.Point(109, 14);
            this.Category_combo.Name = "Category_combo";
            this.Category_combo.Size = new System.Drawing.Size(201, 24);
            this.Category_combo.TabIndex = 4;
            // 
            // Category_lbl
            // 
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_lbl.Location = new System.Drawing.Point(8, 14);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(66, 16);
            this.Category_lbl.TabIndex = 3;
            this.Category_lbl.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Close_btn);
            this.groupBox2.Controls.Add(this.Delete_btn);
            this.groupBox2.Controls.Add(this.Save_btn);
            this.groupBox2.Controls.Add(this.StockInHand_txtbox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.ItemName_txtbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.StockInHand_lbl);
            this.groupBox2.Controls.Add(this.ItemName_lbl);
            this.groupBox2.Location = new System.Drawing.Point(179, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 148);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(231, 108);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(79, 35);
            this.Close_btn.TabIndex = 13;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(146, 107);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(79, 35);
            this.Delete_btn.TabIndex = 12;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(61, 108);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(79, 35);
            this.Save_btn.TabIndex = 11;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            // 
            // StockInHand_txtbox
            // 
            this.StockInHand_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInHand_txtbox.Location = new System.Drawing.Point(109, 79);
            this.StockInHand_txtbox.Name = "StockInHand_txtbox";
            this.StockInHand_txtbox.Size = new System.Drawing.Size(201, 23);
            this.StockInHand_txtbox.TabIndex = 10;
            // 
            // ItemName_txtbox
            // 
            this.ItemName_txtbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_txtbox.Location = new System.Drawing.Point(109, 48);
            this.ItemName_txtbox.Name = "ItemName_txtbox";
            this.ItemName_txtbox.Size = new System.Drawing.Size(201, 23);
            this.ItemName_txtbox.TabIndex = 9;
            // 
            // StockInHand_lbl
            // 
            this.StockInHand_lbl.AutoSize = true;
            this.StockInHand_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInHand_lbl.Location = new System.Drawing.Point(8, 79);
            this.StockInHand_lbl.Name = "StockInHand_lbl";
            this.StockInHand_lbl.Size = new System.Drawing.Size(95, 16);
            this.StockInHand_lbl.TabIndex = 8;
            this.StockInHand_lbl.Text = "Stock In Hand";
            // 
            // ItemName_lbl
            // 
            this.ItemName_lbl.AutoSize = true;
            this.ItemName_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_lbl.Location = new System.Drawing.Point(8, 51);
            this.ItemName_lbl.Name = "ItemName_lbl";
            this.ItemName_lbl.Size = new System.Drawing.Size(74, 16);
            this.ItemName_lbl.TabIndex = 7;
            this.ItemName_lbl.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item No";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 23);
            this.textBox1.TabIndex = 9;
            // 
            // HMS_Add_Edit_Cutleries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HMS_Add_Edit_Cutleries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Cutleries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView cutlery_listview;
        private System.Windows.Forms.ColumnHeader Item_Name;
        private System.Windows.Forms.ColumnHeader Stock_In_Hand;
        private System.Windows.Forms.ComboBox Category_combo;
        private System.Windows.Forms.Label Category_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox StockInHand_txtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ItemName_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StockInHand_lbl;
        private System.Windows.Forms.Label ItemName_lbl;
    }
}