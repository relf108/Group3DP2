namespace PHPSales.src.Forms
{
    partial class View
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
            this.ViewlistBox1 = new System.Windows.Forms.ListBox();
            this.ViewlistBox2 = new System.Windows.Forms.ListBox();
            this.Viewlabel1 = new System.Windows.Forms.Label();
            this.Viewlabel2 = new System.Windows.Forms.Label();
            this.Viewlabel3 = new System.Windows.Forms.Label();
            this.Viewbutton1 = new System.Windows.Forms.Button();
            this.Viewbutton2 = new System.Windows.Forms.Button();
            this.Viewbutton3 = new System.Windows.Forms.Button();
            this.Viewlabel4 = new System.Windows.Forms.Label();
            this.Viewlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewlistBox1
            // 
            this.ViewlistBox1.FormattingEnabled = true;
            this.ViewlistBox1.ItemHeight = 15;
            this.ViewlistBox1.Location = new System.Drawing.Point(65, 43);
            this.ViewlistBox1.Name = "ViewlistBox1";
            this.ViewlistBox1.Size = new System.Drawing.Size(332, 349);
            this.ViewlistBox1.TabIndex = 0;
            // 
            // ViewlistBox2
            // 
            this.ViewlistBox2.FormattingEnabled = true;
            this.ViewlistBox2.ItemHeight = 15;
            this.ViewlistBox2.Location = new System.Drawing.Point(495, 42);
            this.ViewlistBox2.Name = "ViewlistBox2";
            this.ViewlistBox2.Size = new System.Drawing.Size(285, 184);
            this.ViewlistBox2.TabIndex = 1;
            // 
            // Viewlabel1
            // 
            this.Viewlabel1.AutoSize = true;
            this.Viewlabel1.Location = new System.Drawing.Point(495, 260);
            this.Viewlabel1.Name = "Viewlabel1";
            this.Viewlabel1.Size = new System.Drawing.Size(31, 15);
            this.Viewlabel1.TabIndex = 2;
            this.Viewlabel1.Text = "Date";
            this.Viewlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Viewlabel2
            // 
            this.Viewlabel2.AutoSize = true;
            this.Viewlabel2.Location = new System.Drawing.Point(495, 293);
            this.Viewlabel2.Name = "Viewlabel2";
            this.Viewlabel2.Size = new System.Drawing.Size(73, 15);
            this.Viewlabel2.TabIndex = 3;
            this.Viewlabel2.Text = "Employee ID";
            // 
            // Viewlabel3
            // 
            this.Viewlabel3.AutoSize = true;
            this.Viewlabel3.Location = new System.Drawing.Point(495, 328);
            this.Viewlabel3.Name = "Viewlabel3";
            this.Viewlabel3.Size = new System.Drawing.Size(92, 15);
            this.Viewlabel3.TabIndex = 4;
            this.Viewlabel3.Text = "Cool Customer?";
            // 
            // Viewbutton1
            // 
            this.Viewbutton1.Location = new System.Drawing.Point(498, 362);
            this.Viewbutton1.Name = "Viewbutton1";
            this.Viewbutton1.Size = new System.Drawing.Size(90, 35);
            this.Viewbutton1.TabIndex = 5;
            this.Viewbutton1.Text = "Back";
            this.Viewbutton1.UseVisualStyleBackColor = true;
            this.Viewbutton1.Click += new System.EventHandler(this.Viewbutton1_Click);
            // 
            // Viewbutton2
            // 
            this.Viewbutton2.Location = new System.Drawing.Point(594, 362);
            this.Viewbutton2.Name = "Viewbutton2";
            this.Viewbutton2.Size = new System.Drawing.Size(90, 35);
            this.Viewbutton2.TabIndex = 5;
            this.Viewbutton2.Text = "Edit";
            this.Viewbutton2.UseVisualStyleBackColor = true;
            // 
            // Viewbutton3
            // 
            this.Viewbutton3.Location = new System.Drawing.Point(690, 362);
            this.Viewbutton3.Name = "Viewbutton3";
            this.Viewbutton3.Size = new System.Drawing.Size(90, 35);
            this.Viewbutton3.TabIndex = 5;
            this.Viewbutton3.Text = "Remove";
            this.Viewbutton3.UseVisualStyleBackColor = true;
            // 
            // Viewlabel4
            // 
            this.Viewlabel4.AutoSize = true;
            this.Viewlabel4.Location = new System.Drawing.Point(68, 18);
            this.Viewlabel4.Name = "Viewlabel4";
            this.Viewlabel4.Size = new System.Drawing.Size(42, 15);
            this.Viewlabel4.TabIndex = 6;
            this.Viewlabel4.Text = "Orders";
            this.Viewlabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Viewlabel5
            // 
            this.Viewlabel5.AutoSize = true;
            this.Viewlabel5.Location = new System.Drawing.Point(495, 18);
            this.Viewlabel5.Name = "Viewlabel5";
            this.Viewlabel5.Size = new System.Drawing.Size(36, 15);
            this.Viewlabel5.TabIndex = 7;
            this.Viewlabel5.Text = "Items";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Viewlabel5);
            this.Controls.Add(this.Viewlabel4);
            this.Controls.Add(this.Viewbutton3);
            this.Controls.Add(this.Viewbutton2);
            this.Controls.Add(this.Viewbutton1);
            this.Controls.Add(this.Viewlabel3);
            this.Controls.Add(this.Viewlabel2);
            this.Controls.Add(this.Viewlabel1);
            this.Controls.Add(this.ViewlistBox2);
            this.Controls.Add(this.ViewlistBox1);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ViewlistBox1;
        private System.Windows.Forms.ListBox ViewlistBox2;
        private System.Windows.Forms.Label Viewlabel1;
        private System.Windows.Forms.Label Viewlabel2;
        private System.Windows.Forms.Label Viewlabel3;
        private System.Windows.Forms.Button Viewbutton1;
        private System.Windows.Forms.Button Viewbutton2;
        private System.Windows.Forms.Button Viewbutton3;
        private System.Windows.Forms.Label Viewlabel4;
        private System.Windows.Forms.Label Viewlabel5;
    }
}