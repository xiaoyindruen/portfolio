
namespace Lab4
{
    partial class admissionForm
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
            this.lblGpa = new System.Windows.Forms.Label();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.iptGpa = new System.Windows.Forms.TextBox();
            this.iptTestScore = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.optResult = new System.Windows.Forms.Label();
            this.totalAccept = new System.Windows.Forms.Label();
            this.totalReject = new System.Windows.Forms.Label();
            this.optTotalAccept = new System.Windows.Forms.Label();
            this.optTotalReject = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Location = new System.Drawing.Point(128, 52);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(41, 17);
            this.lblGpa.TabIndex = 0;
            this.lblGpa.Text = "GPA:";
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Location = new System.Drawing.Point(88, 99);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(81, 17);
            this.lblTestScore.TabIndex = 1;
            this.lblTestScore.Text = "Test Score:";
            // 
            // iptGpa
            // 
            this.iptGpa.Location = new System.Drawing.Point(190, 49);
            this.iptGpa.Name = "iptGpa";
            this.iptGpa.Size = new System.Drawing.Size(100, 22);
            this.iptGpa.TabIndex = 2;
            // 
            // iptTestScore
            // 
            this.iptTestScore.Location = new System.Drawing.Point(190, 96);
            this.iptTestScore.Name = "iptTestScore";
            this.iptTestScore.Size = new System.Drawing.Size(100, 22);
            this.iptTestScore.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(109, 140);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(132, 31);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Check Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // optResult
            // 
            this.optResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optResult.Location = new System.Drawing.Point(190, 193);
            this.optResult.Name = "optResult";
            this.optResult.Size = new System.Drawing.Size(100, 23);
            this.optResult.TabIndex = 5;
            this.optResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAccept
            // 
            this.totalAccept.AutoSize = true;
            this.totalAccept.Location = new System.Drawing.Point(40, 268);
            this.totalAccept.Name = "totalAccept";
            this.totalAccept.Size = new System.Drawing.Size(129, 17);
            this.totalAccept.TabIndex = 6;
            this.totalAccept.Text = "Total Acceptances:";
            // 
            // totalReject
            // 
            this.totalReject.AutoSize = true;
            this.totalReject.Location = new System.Drawing.Point(55, 309);
            this.totalReject.Name = "totalReject";
            this.totalReject.Size = new System.Drawing.Size(114, 17);
            this.totalReject.TabIndex = 7;
            this.totalReject.Text = "Total Rejections:";
            // 
            // optTotalAccept
            // 
            this.optTotalAccept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optTotalAccept.Location = new System.Drawing.Point(190, 265);
            this.optTotalAccept.Name = "optTotalAccept";
            this.optTotalAccept.Size = new System.Drawing.Size(100, 23);
            this.optTotalAccept.TabIndex = 8;
            this.optTotalAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optTotalReject
            // 
            this.optTotalReject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optTotalReject.Location = new System.Drawing.Point(190, 306);
            this.optTotalReject.Name = "optTotalReject";
            this.optTotalReject.Size = new System.Drawing.Size(100, 23);
            this.optTotalReject.TabIndex = 9;
            this.optTotalReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(117, 196);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(52, 17);
            this.result.TabIndex = 10;
            this.result.Text = "Result:";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // admissionForm
            // 
            this.AcceptButton = this.btnResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 413);
            this.Controls.Add(this.result);
            this.Controls.Add(this.optTotalReject);
            this.Controls.Add(this.optTotalAccept);
            this.Controls.Add(this.totalReject);
            this.Controls.Add(this.totalAccept);
            this.Controls.Add(this.optResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.iptTestScore);
            this.Controls.Add(this.iptGpa);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.lblGpa);
            this.Name = "admissionForm";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.TextBox iptGpa;
        private System.Windows.Forms.TextBox iptTestScore;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label optResult;
        private System.Windows.Forms.Label totalAccept;
        private System.Windows.Forms.Label totalReject;
        private System.Windows.Forms.Label optTotalAccept;
        private System.Windows.Forms.Label optTotalReject;
        private System.Windows.Forms.Label result;
    }
}

