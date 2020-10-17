using System.ComponentModel;

namespace PHPSales.Forms
{
    partial class ExportSalesForm
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
            this.btnExportMonthly = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExportWeekly = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnExportPredicted = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExportMonthly
            // 
            this.btnExportMonthly.Location = new System.Drawing.Point(26, 252);
            this.btnExportMonthly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportMonthly.Name = "btnExportMonthly";
            this.btnExportMonthly.Size = new System.Drawing.Size(183, 104);
            this.btnExportMonthly.TabIndex = 0;
            this.btnExportMonthly.Text = "Export Monthly Records";
            this.btnExportMonthly.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(435, 84);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 364);
            this.listBox1.TabIndex = 1;
            // 
            // btnExportWeekly
            // 
            this.btnExportWeekly.Location = new System.Drawing.Point(217, 142);
            this.btnExportWeekly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportWeekly.Name = "btnExportWeekly";
            this.btnExportWeekly.Size = new System.Drawing.Size(183, 104);
            this.btnExportWeekly.TabIndex = 2;
            this.btnExportWeekly.Text = "Export Weekly Records";
            this.btnExportWeekly.UseVisualStyleBackColor = true;
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(26, 142);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportAll.Size = new System.Drawing.Size(183, 104);
            this.btnExportAll.TabIndex = 3;
            this.btnExportAll.Text = "Export All Records";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnExportPredicted
            // 
            this.btnExportPredicted.Location = new System.Drawing.Point(217, 252);
            this.btnExportPredicted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportPredicted.Name = "btnExportPredicted";
            this.btnExportPredicted.Size = new System.Drawing.Size(183, 104);
            this.btnExportPredicted.TabIndex = 4;
            this.btnExportPredicted.Text = "Export Predicted Sales";
            this.btnExportPredicted.UseVisualStyleBackColor = true;
            this.btnExportPredicted.Click += new System.EventHandler(this.btnExportPredicted_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(435, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a date for exports";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ExportSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExportPredicted);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.btnExportWeekly);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExportMonthly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExportSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExportPredicted;

        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button btnExportMonthly;
        private System.Windows.Forms.Button btnExportWeekly;

        private System.Windows.Forms.ListBox listBox1;

        #endregion

        private System.Windows.Forms.Button btnBack;
    }
}