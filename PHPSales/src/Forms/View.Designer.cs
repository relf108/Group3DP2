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
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Viewlabel4 = new System.Windows.Forms.Label();
            this.Viewlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.DisplayMember = "Text";
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.ItemHeight = 20;
            this.OrdersListBox.Location = new System.Drawing.Point(12, 57);
            this.OrdersListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(534, 464);
            this.OrdersListBox.TabIndex = 0;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DisplayMember = "Text";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(565, 55);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(325, 384);
            this.ItemsListBox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(569, 483);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(103, 48);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Viewbutton1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(679, 483);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 48);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(789, 483);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(103, 48);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveClick);
            // 
            // Viewlabel4
            // 
            this.Viewlabel4.AutoSize = true;
            this.Viewlabel4.Location = new System.Drawing.Point(12, 25);
            this.Viewlabel4.Name = "Viewlabel4";
            this.Viewlabel4.Size = new System.Drawing.Size(53, 20);
            this.Viewlabel4.TabIndex = 6;
            this.Viewlabel4.Text = "Orders";
            // 
            // Viewlabel5
            // 
            this.Viewlabel5.AutoSize = true;
            this.Viewlabel5.Location = new System.Drawing.Point(565, 25);
            this.Viewlabel5.Name = "Viewlabel5";
            this.Viewlabel5.Size = new System.Drawing.Size(45, 20);
            this.Viewlabel5.TabIndex = 7;
            this.Viewlabel5.Text = "Items";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.Viewlabel5);
            this.Controls.Add(this.Viewlabel4);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.OrdersListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Viewlabel4;
        private System.Windows.Forms.Label Viewlabel5;
        
    }
}