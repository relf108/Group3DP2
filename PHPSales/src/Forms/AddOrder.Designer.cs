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
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.AddItembutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentOrderListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.DisplayMember = "Text";
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(61, 55);
            this.ItemListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(397, 504);
            this.ItemListBox.TabIndex = 0;
            // 
            // AddItembutton
            // 
            this.AddItembutton.Location = new System.Drawing.Point(483, 467);
            this.AddItembutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddItembutton.Name = "AddItembutton";
            this.AddItembutton.Size = new System.Drawing.Size(407, 92);
            this.AddItembutton.TabIndex = 1;
            this.AddItembutton.Text = "Create Order";
            this.AddItembutton.UseVisualStyleBackColor = true;
            this.AddItembutton.Click += new System.EventHandler(this.AddCurOrder);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(483, 395);
            this.Clearbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(86, 65);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(804, 395);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(86, 65);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item List";
            // 
            // CurrentOrderListBox
            // 
            this.CurrentOrderListBox.DisplayMember = "Text";
            this.CurrentOrderListBox.FormattingEnabled = true;
            this.CurrentOrderListBox.ItemHeight = 20;
            this.CurrentOrderListBox.Location = new System.Drawing.Point(483, 55);
            this.CurrentOrderListBox.Name = "CurrentOrderListBox";
            this.CurrentOrderListBox.Size = new System.Drawing.Size(407, 324);
            this.CurrentOrderListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current order";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(588, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 65);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(698, 394);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(86, 65);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentOrderListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.AddItembutton);
            this.Controls.Add(this.ItemListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Button AddItembutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CurrentOrderListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}