using System;
using System.Collections;
using System.Windows.Forms;
using SqliteAPI;

namespace PHPSales.Forms
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
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.CoolCustomerLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Viewlabel4 = new System.Windows.Forms.Label();
            this.Viewlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.ItemHeight = 16;
            this.OrdersListBox.Location = new System.Drawing.Point(74, 46);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(379, 372);
            this.OrdersListBox.TabIndex = 0;

            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(566, 45);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(325, 196);
            this.ItemsListBox.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(566, 277);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(37, 16);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(566, 313);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(86, 16);
            this.EmployeeIDLabel.TabIndex = 3;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // CoolCustomerLabel
            // 
            this.CoolCustomerLabel.AutoSize = true;
            this.CoolCustomerLabel.Location = new System.Drawing.Point(566, 350);
            this.CoolCustomerLabel.Name = "CoolCustomerLabel";
            this.CoolCustomerLabel.Size = new System.Drawing.Size(103, 16);
            this.CoolCustomerLabel.TabIndex = 4;
            this.CoolCustomerLabel.Text = "Cool Customer?";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(569, 386);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(103, 37);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Viewbutton1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(679, 386);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 37);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(789, 386);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(103, 37);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.Viewbutton3_Click);
            // 
            // Viewlabel4
            // 
            this.Viewlabel4.AutoSize = true;
            this.Viewlabel4.Location = new System.Drawing.Point(78, 19);
            this.Viewlabel4.Name = "Viewlabel4";
            this.Viewlabel4.Size = new System.Drawing.Size(49, 16);
            this.Viewlabel4.TabIndex = 6;
            this.Viewlabel4.Text = "Orders";
            this.Viewlabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Viewlabel5
            // 
            this.Viewlabel5.AutoSize = true;
            this.Viewlabel5.Location = new System.Drawing.Point(566, 19);
            this.Viewlabel5.Name = "Viewlabel5";
            this.Viewlabel5.Size = new System.Drawing.Size(40, 16);
            this.Viewlabel5.TabIndex = 7;
            this.Viewlabel5.Text = "Items";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.Viewlabel5);
            this.Controls.Add(this.Viewlabel4);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CoolCustomerLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.OrdersListBox);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CoolCustomerLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Viewlabel4;
        private System.Windows.Forms.Label Viewlabel5;
    }
}