﻿
namespace Project
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemDescr,
            this.ItemAmt,
            this.ItemCat,
            this.SupID});
            this.dataGridView1.Location = new System.Drawing.Point(68, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            // 
            // ItemDescr
            // 
            this.ItemDescr.HeaderText = "Description";
            this.ItemDescr.Name = "ItemDescr";
            // 
            // ItemAmt
            // 
            this.ItemAmt.HeaderText = "Amount";
            this.ItemAmt.Name = "ItemAmt";
            // 
            // ItemCat
            // 
            this.ItemCat.HeaderText = "Category";
            this.ItemCat.Name = "ItemCat";
            // 
            // SupID
            // 
            this.SupID.HeaderText = "Supplier ID";
            this.SupID.Name = "SupID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
    }
}

