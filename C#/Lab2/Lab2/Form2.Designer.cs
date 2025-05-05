namespace Lab2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSunny = new System.Windows.Forms.RadioButton();
            this.rdoSnowy = new System.Windows.Forms.RadioButton();
            this.rdoRainy = new System.Windows.Forms.RadioButton();
            this.rdoCloudy = new System.Windows.Forms.RadioButton();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here: ";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(91, 353);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(606, 48);
            this.lblMessage.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(442, 23);
            this.txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSunny);
            this.groupBox1.Controls.Add(this.rdoSnowy);
            this.groupBox1.Controls.Add(this.rdoRainy);
            this.groupBox1.Controls.Add(this.rdoCloudy);
            this.groupBox1.Location = new System.Drawing.Point(93, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdoSunny
            // 
            this.rdoSunny.AutoSize = true;
            this.rdoSunny.Location = new System.Drawing.Point(36, 113);
            this.rdoSunny.Name = "rdoSunny";
            this.rdoSunny.Size = new System.Drawing.Size(59, 19);
            this.rdoSunny.TabIndex = 4;
            this.rdoSunny.TabStop = true;
            this.rdoSunny.Text = "&Sunny";
            this.rdoSunny.UseVisualStyleBackColor = true;
            this.rdoSunny.CheckedChanged += new System.EventHandler(this.rdoSunny_CheckedChanged);
            // 
            // rdoSnowy
            // 
            this.rdoSnowy.AutoSize = true;
            this.rdoSnowy.Location = new System.Drawing.Point(36, 88);
            this.rdoSnowy.Name = "rdoSnowy";
            this.rdoSnowy.Size = new System.Drawing.Size(62, 19);
            this.rdoSnowy.TabIndex = 3;
            this.rdoSnowy.TabStop = true;
            this.rdoSnowy.Text = "S&nowy";
            this.rdoSnowy.UseVisualStyleBackColor = true;
            this.rdoSnowy.CheckedChanged += new System.EventHandler(this.rdoSnowy_CheckedChanged);
            // 
            // rdoRainy
            // 
            this.rdoRainy.AutoSize = true;
            this.rdoRainy.Location = new System.Drawing.Point(36, 63);
            this.rdoRainy.Name = "rdoRainy";
            this.rdoRainy.Size = new System.Drawing.Size(56, 19);
            this.rdoRainy.TabIndex = 2;
            this.rdoRainy.TabStop = true;
            this.rdoRainy.Text = "&Rainy";
            this.rdoRainy.UseVisualStyleBackColor = true;
            this.rdoRainy.CheckedChanged += new System.EventHandler(this.rdoRainy_CheckedChanged);
            // 
            // rdoCloudy
            // 
            this.rdoCloudy.AutoSize = true;
            this.rdoCloudy.Location = new System.Drawing.Point(36, 38);
            this.rdoCloudy.Name = "rdoCloudy";
            this.rdoCloudy.Size = new System.Drawing.Size(65, 19);
            this.rdoCloudy.TabIndex = 1;
            this.rdoCloudy.TabStop = true;
            this.rdoCloudy.Text = "&Cloudy";
            this.rdoCloudy.UseVisualStyleBackColor = true;
            this.rdoCloudy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // picCloudy
            // 
            this.picCloudy.Image = global::Lab2.Properties.Resources.cloudy_day;
            this.picCloudy.Location = new System.Drawing.Point(475, 164);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(50, 50);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloudy.TabIndex = 4;
            this.picCloudy.TabStop = false;
            // 
            // picRainy
            // 
            this.picRainy.Image = global::Lab2.Properties.Resources.rainy_day;
            this.picRainy.Location = new System.Drawing.Point(531, 164);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(50, 50);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRainy.TabIndex = 5;
            this.picRainy.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = global::Lab2.Properties.Resources.snowy;
            this.picSnowy.Location = new System.Drawing.Point(475, 220);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(50, 50);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnowy.TabIndex = 6;
            this.picSnowy.TabStop = false;
            // 
            // picSunny
            // 
            this.picSunny.Image = global::Lab2.Properties.Resources.sunny;
            this.picSunny.Location = new System.Drawing.Point(531, 220);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(50, 50);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSunny.TabIndex = 7;
            this.picSunny.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblMessage;
        private TextBox txtName;
        private GroupBox groupBox1;
        private RadioButton rdoSunny;
        private RadioButton rdoSnowy;
        private RadioButton rdoRainy;
        private RadioButton rdoCloudy;
        private PictureBox picCloudy;
        private PictureBox picRainy;
        private PictureBox picSnowy;
        private PictureBox picSunny;
    }
}