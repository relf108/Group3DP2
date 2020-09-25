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
            this.Removebutton = new System.Windows.Forms.Button();
            this.Increasebutton = new System.Windows.Forms.Button();
            this.Decreasebutton = new System.Windows.Forms.Button();
            this.AddOrdercomboBox1 = new System.Windows.Forms.ComboBox();
            this.AddItembutton = new System.Windows.Forms.Button();
            this.AddOrdertextBox1 = new System.Windows.Forms.TextBox();
            this.NewOrderbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.AddOrderlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddOrderlistBox1
            // 
            this.AddOrderlistBox1.FormattingEnabled = true;
            this.AddOrderlistBox1.ItemHeight = 15;
            this.AddOrderlistBox1.Location = new System.Drawing.Point(54, 42);
            this.AddOrderlistBox1.Name = "AddOrderlistBox1";
            this.AddOrderlistBox1.Size = new System.Drawing.Size(348, 289);
            this.AddOrderlistBox1.TabIndex = 0;
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(54, 351);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(75, 23);
            this.Removebutton.TabIndex = 1;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Increasebutton
            // 
            this.Increasebutton.Location = new System.Drawing.Point(184, 351);
            this.Increasebutton.Name = "Increasebutton";
            this.Increasebutton.Size = new System.Drawing.Size(75, 23);
            this.Increasebutton.TabIndex = 1;
            this.Increasebutton.Text = "Increase";
            this.Increasebutton.UseVisualStyleBackColor = true;
            this.Increasebutton.Click += new System.EventHandler(this.incrementOrderValue);
            // 
            // Decreasebutton
            // 
            this.Decreasebutton.Location = new System.Drawing.Point(327, 351);
            this.Decreasebutton.Name = "Decreasebutton";
            this.Decreasebutton.Size = new System.Drawing.Size(75, 23);
            this.Decreasebutton.TabIndex = 1;
            this.Decreasebutton.Text = "Decrease";
            this.Decreasebutton.UseVisualStyleBackColor = true;
            this.Decreasebutton.Click += new System.EventHandler(this.decrementOrderValue);

            // 
            // AddOrdercomboBox1
            // 
            this.AddOrdercomboBox1.FormattingEnabled = true;
            this.AddOrdercomboBox1.Location = new System.Drawing.Point(424, 111);
            this.AddOrdercomboBox1.Name = "AddOrdercomboBox1";
            this.AddOrdercomboBox1.Size = new System.Drawing.Size(223, 23);
            this.AddOrdercomboBox1.TabIndex = 2;
            // 
            // AddItembutton
            // 
            this.AddItembutton.Location = new System.Drawing.Point(716, 111);
            this.AddItembutton.Name = "AddItembutton";
            this.AddItembutton.Size = new System.Drawing.Size(75, 23);
            this.AddItembutton.TabIndex = 1;
            this.AddItembutton.Text = "Add";
            this.AddItembutton.UseVisualStyleBackColor = true;
            this.AddItembutton.Click += new System.EventHandler(this.Button6_Click);

            // 
            // AddOrdertextBox1
            // 
            this.AddOrdertextBox1.Location = new System.Drawing.Point(660, 110);
            this.AddOrdertextBox1.Name = "AddOrdertextBox1";
            this.AddOrdertextBox1.Size = new System.Drawing.Size(42, 23);
            this.AddOrdertextBox1.TabIndex = 3;
            // 
            // NewOrderbutton
            // 
            this.NewOrderbutton.Location = new System.Drawing.Point(424, 224);
            this.NewOrderbutton.Name = "NewOrderbutton";
            this.NewOrderbutton.Size = new System.Drawing.Size(353, 52);
            this.NewOrderbutton.TabIndex = 4;
            this.NewOrderbutton.Text = "New Order";
            this.NewOrderbutton.UseVisualStyleBackColor = true;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(424, 282);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(93, 49);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(685, 282);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(93, 49);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // AddOrderlabel1
            // 
            this.AddOrderlabel1.AutoSize = true;
            this.AddOrderlabel1.Location = new System.Drawing.Point(426, 66);
            this.AddOrderlabel1.Name = "AddOrderlabel1";
            this.AddOrderlabel1.Size = new System.Drawing.Size(76, 15);
            this.AddOrderlabel1.TabIndex = 5;
            this.AddOrderlabel1.Text = "Logged In As";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddOrderlabel1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.NewOrderbutton);
            this.Controls.Add(this.AddOrdertextBox1);
            this.Controls.Add(this.AddItembutton);
            this.Controls.Add(this.AddOrdercomboBox1);
            this.Controls.Add(this.Decreasebutton);
            this.Controls.Add(this.Increasebutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.AddOrderlistBox1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AddOrderlistBox1;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Increasebutton;
        private System.Windows.Forms.Button Decreasebutton;
        private System.Windows.Forms.ComboBox AddOrdercomboBox1;
        private System.Windows.Forms.Button AddItembutton;
        private System.Windows.Forms.TextBox AddOrdertextBox1;
        private System.Windows.Forms.Button NewOrderbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label AddOrderlabel1;
    }
}