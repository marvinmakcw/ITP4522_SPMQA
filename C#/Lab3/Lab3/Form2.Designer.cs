namespace Lab3
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(110, 66);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(110, 120);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(77, 30);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate\r\n(Annual)";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(110, 264);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(85, 30);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value after 10\r\nyears";
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(110, 343);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(86, 30);
            this.lblMillion.TabIndex = 3;
            this.lblMillion.Text = "Years to reach\r\n$1M";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(110, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(373, 43);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(218, 63);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(265, 23);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(218, 117);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(265, 23);
            this.txtRate.TabIndex = 6;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValue2
            // 
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Location = new System.Drawing.Point(218, 264);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(265, 30);
            this.lblValue2.TabIndex = 7;
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(218, 343);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(265, 30);
            this.lblMillion2.TabIndex = 8;
            this.lblMillion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form2";
            this.Text = "Compound Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAmount;
        private Label lblRate;
        private Label lblValue;
        private Label lblMillion;
        private Button btnCalculate;
        private TextBox txtAmount;
        private TextBox txtRate;
        private Label lblValue2;
        private Label lblMillion2;
    }
}