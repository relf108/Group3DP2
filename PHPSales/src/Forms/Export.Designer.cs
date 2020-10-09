using System.ComponentModel;

namespace PHPSales.Forms
{
    partial class Export
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.exportMonthly = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exportWeekly = new System.Windows.Forms.Button();
            this.exportAll = new System.Windows.Forms.Button();
            this.exportPredicted = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exportMonthly
            // 
            this.exportMonthly.Location = new System.Drawing.Point(31, 179);
            this.exportMonthly.Name = "exportMonthly";
            this.exportMonthly.Size = new System.Drawing.Size(157, 90);
            this.exportMonthly.TabIndex = 0;
            this.exportMonthly.Text = "Export Monthly Records";
            this.exportAll.Click += new System.EventHandler(this.exportMonthly_Click);
            this.exportMonthly.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(514, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 316);
            this.listBox1.TabIndex = 1;
            // 
            // exportWeekly
            // 
            this.exportWeekly.Location = new System.Drawing.Point(238, 59);
            this.exportWeekly.Name = "exportWeekly";
            this.exportWeekly.Size = new System.Drawing.Size(157, 90);
            this.exportWeekly.TabIndex = 2;
            this.exportWeekly.Text = "Export Weekly Records";
            this.exportAll.Click += new System.EventHandler(this.exportWeekly_Click);
            this.exportWeekly.UseVisualStyleBackColor = true;
            // 
            // exportAll
            // 
            this.exportAll.Location = new System.Drawing.Point(31, 59);
            this.exportAll.Name = "exportAll";
            this.exportAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exportAll.Size = new System.Drawing.Size(157, 90);
            this.exportAll.TabIndex = 3;
            this.exportAll.Text = "Export All Records";
            this.exportAll.UseVisualStyleBackColor = true;
            this.exportAll.Click += new System.EventHandler(this.exportAll_Click);
            // 
            // exportPredicted
            // 
            this.exportPredicted.Location = new System.Drawing.Point(238, 179);
            this.exportPredicted.Name = "exportPredicted";
            this.exportPredicted.Size = new System.Drawing.Size(157, 90);
            this.exportPredicted.TabIndex = 4;
            this.exportPredicted.Text = "Export Predicted Sales";
            this.exportPredicted.UseVisualStyleBackColor = true;
            this.exportPredicted.Click += new System.EventHandler(this.exportPredicted_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a date for exports";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.exportPredicted);
            this.Controls.Add(this.exportAll);
            this.Controls.Add(this.exportWeekly);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exportMonthly);
            this.Name = "Export";
            this.Text = "Export";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button exportPredicted;

        private System.Windows.Forms.Button exportAll;
        private System.Windows.Forms.Button exportMonthly;
        private System.Windows.Forms.Button exportWeekly;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}