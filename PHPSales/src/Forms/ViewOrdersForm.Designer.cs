using System;
using System.Collections;
using System.Windows.Forms;
using SqliteAPI;

namespace PHPSales.Forms
{
    partial class ViewOrdersForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Viewlabel4 = new System.Windows.Forms.Label();
            this.Viewlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.DisplayMember = "Text";
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.ItemHeight = 15;
            this.OrdersListBox.Location = new System.Drawing.Point(12, 88);
            this.OrdersListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(394, 349);
            this.OrdersListBox.TabIndex = 0;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DisplayMember = "Text";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(446, 47);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(285, 289);
            this.ItemsListBox.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(503, 368);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(599, 368);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 36);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Viewlabel4
            // 
            this.Viewlabel4.AutoSize = true;
            this.Viewlabel4.Location = new System.Drawing.Point(12, 69);
            this.Viewlabel4.Name = "Viewlabel4";
            this.Viewlabel4.Size = new System.Drawing.Size(42, 15);
            this.Viewlabel4.TabIndex = 6;
            this.Viewlabel4.Text = "Orders";
            // 
            // Viewlabel5
            // 
            this.Viewlabel5.AutoSize = true;
            this.Viewlabel5.Location = new System.Drawing.Point(446, 25);
            this.Viewlabel5.Name = "Viewlabel5";
            this.Viewlabel5.Size = new System.Drawing.Size(36, 15);
            this.Viewlabel5.TabIndex = 7;
            this.Viewlabel5.Text = "Items";
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.Viewlabel5);
            this.Controls.Add(this.Viewlabel4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.OrdersListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP - View Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label Viewlabel4;
        private System.Windows.Forms.Label Viewlabel5;
        
    }
}