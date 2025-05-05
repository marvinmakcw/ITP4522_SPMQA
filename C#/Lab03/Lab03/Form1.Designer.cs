namespace Lab03
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
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(49, 123);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(224, 20);
            this.cboMovie.TabIndex = 0;
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(47, 95);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(156, 12);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choice of Best Movie Series\r\n";
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(49, 187);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(101, 25);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cost Your Vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.cboMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Button btnCast;
    }
}

