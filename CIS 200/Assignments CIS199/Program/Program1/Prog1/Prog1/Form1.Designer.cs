
namespace Prog1
{
    partial class costForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.maxWidth = new System.Windows.Forms.Label();
            this.iptWidth = new System.Windows.Forms.TextBox();
            this.iptLength = new System.Windows.Forms.TextBox();
            this.maxLength = new System.Windows.Forms.Label();
            this.iptSoilPrice = new System.Windows.Forms.TextBox();
            this.soilPrice = new System.Windows.Forms.Label();
            this.iptFertilizer = new System.Windows.Forms.TextBox();
            this.iptFirstGarden = new System.Windows.Forms.TextBox();
            this.firstGarden = new System.Windows.Forms.Label();
            this.fertilizer = new System.Windows.Forms.Label();
            this.gardenArea = new System.Windows.Forms.Label();
            this.optArea = new System.Windows.Forms.Label();
            this.optSoilCost = new System.Windows.Forms.Label();
            this.soilCost = new System.Windows.Forms.Label();
            this.optFCost = new System.Windows.Forms.Label();
            this.fCost = new System.Windows.Forms.Label();
            this.optLaborCost = new System.Windows.Forms.Label();
            this.laborCost = new System.Windows.Forms.Label();
            this.optTotalCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EZ-Garden and Lanscaping Costs Estimator";
            // 
            // maxWidth
            // 
            this.maxWidth.AutoSize = true;
            this.maxWidth.Location = new System.Drawing.Point(36, 76);
            this.maxWidth.Name = "maxWidth";
            this.maxWidth.Size = new System.Drawing.Size(167, 17);
            this.maxWidth.TabIndex = 1;
            this.maxWidth.Text = "Max Width of Garden (ft):";
            // 
            // iptWidth
            // 
            this.iptWidth.Location = new System.Drawing.Point(232, 71);
            this.iptWidth.Name = "iptWidth";
            this.iptWidth.Size = new System.Drawing.Size(100, 22);
            this.iptWidth.TabIndex = 2;
            // 
            // iptLength
            // 
            this.iptLength.Location = new System.Drawing.Point(232, 109);
            this.iptLength.Name = "iptLength";
            this.iptLength.Size = new System.Drawing.Size(100, 22);
            this.iptLength.TabIndex = 4;
            // 
            // maxLength
            // 
            this.maxLength.AutoSize = true;
            this.maxLength.Location = new System.Drawing.Point(28, 114);
            this.maxLength.Name = "maxLength";
            this.maxLength.Size = new System.Drawing.Size(175, 17);
            this.maxLength.TabIndex = 3;
            this.maxLength.Text = "Max Length of Garden (ft):";
            // 
            // iptSoilPrice
            // 
            this.iptSoilPrice.Location = new System.Drawing.Point(232, 146);
            this.iptSoilPrice.Name = "iptSoilPrice";
            this.iptSoilPrice.Size = new System.Drawing.Size(100, 22);
            this.iptSoilPrice.TabIndex = 6;
            // 
            // soilPrice
            // 
            this.soilPrice.AutoSize = true;
            this.soilPrice.Location = new System.Drawing.Point(80, 151);
            this.soilPrice.Name = "soilPrice";
            this.soilPrice.Size = new System.Drawing.Size(123, 17);
            this.soilPrice.TabIndex = 5;
            this.soilPrice.Text = "Soil Price (sq. yd):";
            // 
            // iptFertilizer
            // 
            this.iptFertilizer.Location = new System.Drawing.Point(232, 187);
            this.iptFertilizer.Name = "iptFertilizer";
            this.iptFertilizer.Size = new System.Drawing.Size(100, 22);
            this.iptFertilizer.TabIndex = 8;
            // 
            // iptFirstGarden
            // 
            this.iptFirstGarden.Location = new System.Drawing.Point(232, 249);
            this.iptFirstGarden.Name = "iptFirstGarden";
            this.iptFirstGarden.Size = new System.Drawing.Size(100, 22);
            this.iptFirstGarden.TabIndex = 10;
            // 
            // firstGarden
            // 
            this.firstGarden.Location = new System.Drawing.Point(56, 249);
            this.firstGarden.Name = "firstGarden";
            this.firstGarden.Size = new System.Drawing.Size(147, 38);
            this.firstGarden.TabIndex = 9;
            this.firstGarden.Text = "            First Garden: (1= YES, 0=NO)";
            this.firstGarden.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fertilizer
            // 
            this.fertilizer.Location = new System.Drawing.Point(48, 187);
            this.fertilizer.Name = "fertilizer";
            this.fertilizer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fertilizer.Size = new System.Drawing.Size(155, 39);
            this.fertilizer.TabIndex = 11;
            this.fertilizer.Text = "                      Fertilizer: (1 = YES, 0 = NO)";
            this.fertilizer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gardenArea
            // 
            this.gardenArea.AutoSize = true;
            this.gardenArea.Location = new System.Drawing.Point(129, 309);
            this.gardenArea.Name = "gardenArea";
            this.gardenArea.Size = new System.Drawing.Size(74, 17);
            this.gardenArea.TabIndex = 12;
            this.gardenArea.Text = "Sq. Yards:";
            // 
            // optArea
            // 
            this.optArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optArea.Location = new System.Drawing.Point(232, 309);
            this.optArea.Name = "optArea";
            this.optArea.Size = new System.Drawing.Size(100, 23);
            this.optArea.TabIndex = 13;
            // 
            // optSoilCost
            // 
            this.optSoilCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optSoilCost.Location = new System.Drawing.Point(232, 336);
            this.optSoilCost.Name = "optSoilCost";
            this.optSoilCost.Size = new System.Drawing.Size(100, 23);
            this.optSoilCost.TabIndex = 15;
            // 
            // soilCost
            // 
            this.soilCost.AutoSize = true;
            this.soilCost.Location = new System.Drawing.Point(136, 343);
            this.soilCost.Name = "soilCost";
            this.soilCost.Size = new System.Drawing.Size(67, 17);
            this.soilCost.TabIndex = 14;
            this.soilCost.Text = "Soil Cost:";
            // 
            // optFCost
            // 
            this.optFCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optFCost.Location = new System.Drawing.Point(232, 371);
            this.optFCost.Name = "optFCost";
            this.optFCost.Size = new System.Drawing.Size(100, 23);
            this.optFCost.TabIndex = 17;
            // 
            // fCost
            // 
            this.fCost.AutoSize = true;
            this.fCost.Location = new System.Drawing.Point(105, 377);
            this.fCost.Name = "fCost";
            this.fCost.Size = new System.Drawing.Size(98, 17);
            this.fCost.TabIndex = 16;
            this.fCost.Text = "Fertilizer Cost:";
            // 
            // optLaborCost
            // 
            this.optLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optLaborCost.Location = new System.Drawing.Point(232, 407);
            this.optLaborCost.Name = "optLaborCost";
            this.optLaborCost.Size = new System.Drawing.Size(100, 23);
            this.optLaborCost.TabIndex = 19;
            // 
            // laborCost
            // 
            this.laborCost.AutoSize = true;
            this.laborCost.Location = new System.Drawing.Point(122, 411);
            this.laborCost.Name = "laborCost";
            this.laborCost.Size = new System.Drawing.Size(81, 17);
            this.laborCost.TabIndex = 18;
            this.laborCost.Text = "Labor Cost:";
            // 
            // optTotalCost
            // 
            this.optTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optTotalCost.Location = new System.Drawing.Point(232, 447);
            this.optTotalCost.Name = "optTotalCost";
            this.optTotalCost.Size = new System.Drawing.Size(100, 23);
            this.optTotalCost.TabIndex = 21;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(127, 445);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(76, 17);
            this.totalCost.TabIndex = 20;
            this.totalCost.Text = "Total Cost:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(108, 496);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(161, 33);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calculate Estimate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // costForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 575);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.optTotalCost);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.optLaborCost);
            this.Controls.Add(this.laborCost);
            this.Controls.Add(this.optFCost);
            this.Controls.Add(this.fCost);
            this.Controls.Add(this.optSoilCost);
            this.Controls.Add(this.soilCost);
            this.Controls.Add(this.optArea);
            this.Controls.Add(this.gardenArea);
            this.Controls.Add(this.fertilizer);
            this.Controls.Add(this.iptFirstGarden);
            this.Controls.Add(this.firstGarden);
            this.Controls.Add(this.iptFertilizer);
            this.Controls.Add(this.iptSoilPrice);
            this.Controls.Add(this.soilPrice);
            this.Controls.Add(this.iptLength);
            this.Controls.Add(this.maxLength);
            this.Controls.Add(this.iptWidth);
            this.Controls.Add(this.maxWidth);
            this.Controls.Add(this.label1);
            this.Name = "costForm";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxWidth;
        private System.Windows.Forms.TextBox iptWidth;
        private System.Windows.Forms.TextBox iptLength;
        private System.Windows.Forms.Label maxLength;
        private System.Windows.Forms.TextBox iptSoilPrice;
        private System.Windows.Forms.Label soilPrice;
        private System.Windows.Forms.TextBox iptFertilizer;
        private System.Windows.Forms.TextBox iptFirstGarden;
        private System.Windows.Forms.Label firstGarden;
        private System.Windows.Forms.Label fertilizer;
        private System.Windows.Forms.Label gardenArea;
        private System.Windows.Forms.Label optArea;
        private System.Windows.Forms.Label optSoilCost;
        private System.Windows.Forms.Label soilCost;
        private System.Windows.Forms.Label optFCost;
        private System.Windows.Forms.Label fCost;
        private System.Windows.Forms.Label optLaborCost;
        private System.Windows.Forms.Label laborCost;
        private System.Windows.Forms.Label optTotalCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Button btnCalc;
    }
}

