namespace PHPSales.Forms
{
    partial class AddOrderForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentOrderListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.DisplayMember = "Text";
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 15;
            this.ItemListBox.Location = new System.Drawing.Point(12, 86);
            this.ItemListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(354, 289);
            this.ItemListBox.TabIndex = 0;
            // 
            // AddItembutton
            // 
            this.AddItembutton.Location = new System.Drawing.Point(398, 400);
            this.AddItembutton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItembutton.Name = "AddItembutton";
            this.AddItembutton.Size = new System.Drawing.Size(354, 50);
            this.AddItembutton.TabIndex = 1;
            this.AddItembutton.Text = "Create Order";
            this.AddItembutton.UseVisualStyleBackColor = true;
            this.AddItembutton.Click += new System.EventHandler(this.AddCurOrder);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item List";
            // 
            // CurrentOrderListBox
            // 
            this.CurrentOrderListBox.DisplayMember = "Text";
            this.CurrentOrderListBox.FormattingEnabled = true;
            this.CurrentOrderListBox.ItemHeight = 15;
            this.CurrentOrderListBox.Location = new System.Drawing.Point(398, 86);
            this.CurrentOrderListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentOrderListBox.Name = "CurrentOrderListBox";
            this.CurrentOrderListBox.Size = new System.Drawing.Size(354, 289);
            this.CurrentOrderListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current order";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 401);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(354, 49);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentOrderListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.AddItembutton);
            this.Controls.Add(this.ItemListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Button AddItembutton;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CurrentOrderListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
    }
}