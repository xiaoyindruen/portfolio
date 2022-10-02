
namespace Lab2
{
    partial class Lab2Form
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
            this.mealPrice = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.calPercent1 = new System.Windows.Forms.Label();
            this.calPercent2 = new System.Windows.Forms.Label();
            this.calPercent3 = new System.Windows.Forms.Label();
            this.outPut1 = new System.Windows.Forms.Label();
            this.outPut2 = new System.Windows.Forms.Label();
            this.outPut3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPrice
            // 
            this.mealPrice.AutoSize = true;
            this.mealPrice.Location = new System.Drawing.Point(52, 32);
            this.mealPrice.Name = "mealPrice";
            this.mealPrice.Size = new System.Drawing.Size(131, 17);
            this.mealPrice.TabIndex = 0;
            this.mealPrice.Text = "Enter price of meal:";
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(201, 32);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(100, 22);
            this.inputPrice.TabIndex = 1;
            // 
            // calPercent1
            // 
            this.calPercent1.AutoSize = true;
            this.calPercent1.Location = new System.Drawing.Point(135, 66);
            this.calPercent1.Name = "calPercent1";
            this.calPercent1.Size = new System.Drawing.Size(40, 17);
            this.calPercent1.TabIndex = 2;
            this.calPercent1.Text = "15 %";
            // 
            // calPercent2
            // 
            this.calPercent2.AutoSize = true;
            this.calPercent2.Location = new System.Drawing.Point(135, 111);
            this.calPercent2.Name = "calPercent2";
            this.calPercent2.Size = new System.Drawing.Size(40, 17);
            this.calPercent2.TabIndex = 3;
            this.calPercent2.Text = "18 %";
            // 
            // calPercent3
            // 
            this.calPercent3.AutoSize = true;
            this.calPercent3.Location = new System.Drawing.Point(135, 148);
            this.calPercent3.Name = "calPercent3";
            this.calPercent3.Size = new System.Drawing.Size(40, 17);
            this.calPercent3.TabIndex = 4;
            this.calPercent3.Text = "20 %";
            // 
            // outPut1
            // 
            this.outPut1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPut1.Location = new System.Drawing.Point(201, 65);
            this.outPut1.Name = "outPut1";
            this.outPut1.Size = new System.Drawing.Size(100, 23);
            this.outPut1.TabIndex = 5;
            // 
            // outPut2
            // 
            this.outPut2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPut2.Location = new System.Drawing.Point(201, 105);
            this.outPut2.Name = "outPut2";
            this.outPut2.Size = new System.Drawing.Size(100, 23);
            this.outPut2.TabIndex = 6;
            // 
            // outPut3
            // 
            this.outPut3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPut3.Location = new System.Drawing.Point(201, 147);
            this.outPut3.Name = "outPut3";
            this.outPut3.Size = new System.Drawing.Size(100, 23);
            this.outPut3.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(119, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 31);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Tip";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Lab2Form
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 389);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.outPut3);
            this.Controls.Add(this.outPut2);
            this.Controls.Add(this.outPut1);
            this.Controls.Add(this.calPercent3);
            this.Controls.Add(this.calPercent2);
            this.Controls.Add(this.calPercent1);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.mealPrice);
            this.Name = "Lab2Form";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPrice;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label calPercent1;
        private System.Windows.Forms.Label calPercent2;
        private System.Windows.Forms.Label calPercent3;
        private System.Windows.Forms.Label outPut1;
        private System.Windows.Forms.Label outPut2;
        private System.Windows.Forms.Label outPut3;
        private System.Windows.Forms.Button btnCalculate;
    }
}

