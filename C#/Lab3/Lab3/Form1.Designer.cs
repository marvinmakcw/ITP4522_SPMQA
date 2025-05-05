namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCast = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(107, 67);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(183, 15);
            this.lblCast.TabIndex = 0;
            this.lblCast.Text = "My Choice of Best Movie Series";
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(107, 108);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(139, 23);
            this.cboMovie.TabIndex = 1;
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(107, 221);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(107, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.lblCast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCast;
        private ComboBox cboMovie;
        private Button btnCast;
    }
}