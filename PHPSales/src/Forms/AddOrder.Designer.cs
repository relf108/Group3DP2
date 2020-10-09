namespace PHPSales.Forms
{
    partial class AddOrder
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
            this.AddOrderlistBox1 = new System.Windows.Forms.ListBox();
            this.AddItembutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOrderlistBox1
            // 
            this.AddOrderlistBox1.DisplayMember = "Text";
            this.AddOrderlistBox1.FormattingEnabled = true;
            this.AddOrderlistBox1.Location = new System.Drawing.Point(46, 36);
            this.AddOrderlistBox1.Name = "AddOrderlistBox1";
            this.AddOrderlistBox1.Size = new System.Drawing.Size(299, 329);
            this.AddOrderlistBox1.TabIndex = 0;
            // 
            // AddItembutton
            // 
            this.AddItembutton.Location = new System.Drawing.Point(363, 164);
            this.AddItembutton.Name = "AddItembutton";
            this.AddItembutton.Size = new System.Drawing.Size(304, 60);
            this.AddItembutton.TabIndex = 1;
            this.AddItembutton.Text = "Create Order";
            this.AddItembutton.UseVisualStyleBackColor = true;
            this.AddItembutton.Click += new System.EventHandler(this.AddItem);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(363, 244);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(80, 42);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(587, 244);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(80, 42);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.AddItembutton);
            this.Controls.Add(this.AddOrderlistBox1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox AddOrderlistBox1;
        private System.Windows.Forms.Button AddItembutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Backbutton;
    }
}