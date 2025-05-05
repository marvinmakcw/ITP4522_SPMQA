namespace Lab3
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
            this.lbxShop = new System.Windows.Forms.ListBox();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxShop
            // 
            this.lbxShop.FormattingEnabled = true;
            this.lbxShop.ItemHeight = 15;
            this.lbxShop.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Grape",
            "Orange",
            "Peach",
            "Pear",
            "Pineapple"});
            this.lbxShop.Location = new System.Drawing.Point(100, 58);
            this.lbxShop.Name = "lbxShop";
            this.lbxShop.Size = new System.Drawing.Size(124, 154);
            this.lbxShop.TabIndex = 0;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 15;
            this.lbxCart.Location = new System.Drawing.Point(548, 58);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(124, 154);
            this.lbxCart.TabIndex = 1;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(159, 273);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(126, 23);
            this.txtAdd.TabIndex = 2;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(95, 276);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(58, 15);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Add Fruit";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Fruit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(347, 96);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "-->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(347, 155);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "<--";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.Location = new System.Drawing.Point(404, 331);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(122, 46);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count Shop + Cart";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(548, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "ClearCart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.lbxShop);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxShop;
        private ListBox lbxCart;
        private TextBox txtAdd;
        private Label lblAdd;
        private Button btnAdd;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCount;
        private Button btnClear;
    }
}