namespace Lab6
{
    partial class Form3
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
            this.btnShowBook = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowBook
            // 
            this.btnShowBook.Location = new System.Drawing.Point(75, 71);
            this.btnShowBook.Name = "btnShowBook";
            this.btnShowBook.Size = new System.Drawing.Size(146, 37);
            this.btnShowBook.TabIndex = 0;
            this.btnShowBook.Text = "Show Books Table";
            this.btnShowBook.UseVisualStyleBackColor = true;
            this.btnShowBook.Click += new System.EventHandler(this.btnShowBook_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(340, 71);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(146, 37);
            this.btnSQL.TabIndex = 1;
            this.btnSQL.Text = "Show Table by SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(75, 142);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(411, 22);
            this.txtSQL.TabIndex = 2;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(75, 198);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(411, 224);
            this.dgvDisplay.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnShowBook);
            this.Name = "Form3";
            this.Text = "Viewing a database by a DataGridView";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBook;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.DataGridView dgvDisplay;
    }
}