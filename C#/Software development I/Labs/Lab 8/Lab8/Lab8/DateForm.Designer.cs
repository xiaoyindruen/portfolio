
namespace Lab8
{
    partial class DateForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.optDate = new System.Windows.Forms.Label();
            this.iptMonth = new System.Windows.Forms.TextBox();
            this.iptDay = new System.Windows.Forms.TextBox();
            this.iptYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(124, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(253, 113);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(125, 33);
            this.btnMonth.TabIndex = 8;
            this.btnMonth.Text = "Update Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(253, 166);
            this.btnDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(125, 33);
            this.btnDay.TabIndex = 9;
            this.btnDay.Text = "Update Day";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(253, 213);
            this.btnYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(125, 33);
            this.btnYear.TabIndex = 10;
            this.btnYear.Text = "Update Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // optDate
            // 
            this.optDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optDate.Location = new System.Drawing.Point(191, 46);
            this.optDate.Name = "optDate";
            this.optDate.Size = new System.Drawing.Size(143, 23);
            this.optDate.TabIndex = 11;
            // 
            // iptMonth
            // 
            this.iptMonth.Location = new System.Drawing.Point(127, 117);
            this.iptMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptMonth.Name = "iptMonth";
            this.iptMonth.Size = new System.Drawing.Size(100, 22);
            this.iptMonth.TabIndex = 12;
            // 
            // iptDay
            // 
            this.iptDay.Location = new System.Drawing.Point(127, 170);
            this.iptDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptDay.Name = "iptDay";
            this.iptDay.Size = new System.Drawing.Size(100, 22);
            this.iptDay.TabIndex = 13;
            // 
            // iptYear
            // 
            this.iptYear.Location = new System.Drawing.Point(127, 217);
            this.iptYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptYear.Name = "iptYear";
            this.iptYear.Size = new System.Drawing.Size(100, 22);
            this.iptYear.TabIndex = 14;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 310);
            this.Controls.Add(this.iptYear);
            this.Controls.Add(this.iptDay);
            this.Controls.Add(this.iptMonth);
            this.Controls.Add(this.optDate);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DateForm";
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label optDate;
        private System.Windows.Forms.TextBox iptMonth;
        private System.Windows.Forms.TextBox iptDay;
        private System.Windows.Forms.TextBox iptYear;
    }
}

