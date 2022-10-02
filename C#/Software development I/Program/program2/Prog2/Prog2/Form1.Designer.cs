
namespace Prog2
{
    partial class FoodDeliveryCostForm
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
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.optResult = new System.Windows.Forms.Label();
            this.optCCost = new System.Windows.Forms.Label();
            this.optBCost = new System.Windows.Forms.Label();
            this.optACost = new System.Windows.Forms.Label();
            this.lblCCost = new System.Windows.Forms.Label();
            this.lblBCost = new System.Windows.Forms.Label();
            this.lblACost = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDeliverDays = new System.Windows.Forms.Label();
            this.iptPeople = new System.Windows.Forms.TextBox();
            this.iptDistance = new System.Windows.Forms.TextBox();
            this.iptDyas = new System.Windows.Forms.TextBox();
            this.btnCalCost = new System.Windows.Forms.Button();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.optResult);
            this.resultGroupBox.Controls.Add(this.optCCost);
            this.resultGroupBox.Controls.Add(this.optBCost);
            this.resultGroupBox.Controls.Add(this.optACost);
            this.resultGroupBox.Controls.Add(this.lblCCost);
            this.resultGroupBox.Controls.Add(this.lblBCost);
            this.resultGroupBox.Controls.Add(this.lblACost);
            this.resultGroupBox.Location = new System.Drawing.Point(310, 56);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(353, 269);
            this.resultGroupBox.TabIndex = 0;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Results";
            // 
            // optResult
            // 
            this.optResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optResult.Location = new System.Drawing.Point(24, 208);
            this.optResult.Name = "optResult";
            this.optResult.Size = new System.Drawing.Size(300, 26);
            this.optResult.TabIndex = 6;
            this.optResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optCCost
            // 
            this.optCCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optCCost.Location = new System.Drawing.Point(176, 130);
            this.optCCost.Name = "optCCost";
            this.optCCost.Size = new System.Drawing.Size(100, 23);
            this.optCCost.TabIndex = 5;
            this.optCCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optBCost
            // 
            this.optBCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optBCost.Location = new System.Drawing.Point(176, 87);
            this.optBCost.Name = "optBCost";
            this.optBCost.Size = new System.Drawing.Size(100, 23);
            this.optBCost.TabIndex = 4;
            this.optBCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optACost
            // 
            this.optACost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optACost.Location = new System.Drawing.Point(176, 43);
            this.optACost.Name = "optACost";
            this.optACost.Size = new System.Drawing.Size(100, 23);
            this.optACost.TabIndex = 3;
            this.optACost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCCost
            // 
            this.lblCCost.AutoSize = true;
            this.lblCCost.Location = new System.Drawing.Point(42, 133);
            this.lblCCost.Name = "lblCCost";
            this.lblCCost.Size = new System.Drawing.Size(112, 17);
            this.lblCCost.TabIndex = 2;
            this.lblCCost.Text = "Company C Cost";
            this.lblCCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBCost
            // 
            this.lblBCost.AutoSize = true;
            this.lblBCost.Location = new System.Drawing.Point(42, 90);
            this.lblBCost.Name = "lblBCost";
            this.lblBCost.Size = new System.Drawing.Size(112, 17);
            this.lblBCost.TabIndex = 1;
            this.lblBCost.Text = "Company B Cost";
            this.lblBCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblACost
            // 
            this.lblACost.AutoSize = true;
            this.lblACost.Location = new System.Drawing.Point(42, 46);
            this.lblACost.Name = "lblACost";
            this.lblACost.Size = new System.Drawing.Size(112, 17);
            this.lblACost.TabIndex = 0;
            this.lblACost.Text = "Company A Cost";
            this.lblACost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(74, 72);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(52, 17);
            this.lblPeople.TabIndex = 1;
            this.lblPeople.Text = "People";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(21, 134);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(105, 17);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distance(Miles)";
            // 
            // lblDeliverDays
            // 
            this.lblDeliverDays.AutoSize = true;
            this.lblDeliverDays.Location = new System.Drawing.Point(38, 192);
            this.lblDeliverDays.Name = "lblDeliverDays";
            this.lblDeliverDays.Size = new System.Drawing.Size(88, 17);
            this.lblDeliverDays.TabIndex = 3;
            this.lblDeliverDays.Text = "Deliver Days";
            // 
            // iptPeople
            // 
            this.iptPeople.Location = new System.Drawing.Point(153, 72);
            this.iptPeople.Name = "iptPeople";
            this.iptPeople.Size = new System.Drawing.Size(100, 22);
            this.iptPeople.TabIndex = 4;
            // 
            // iptDistance
            // 
            this.iptDistance.Location = new System.Drawing.Point(153, 134);
            this.iptDistance.Name = "iptDistance";
            this.iptDistance.Size = new System.Drawing.Size(100, 22);
            this.iptDistance.TabIndex = 5;
            // 
            // iptDyas
            // 
            this.iptDyas.Location = new System.Drawing.Point(153, 195);
            this.iptDyas.Name = "iptDyas";
            this.iptDyas.Size = new System.Drawing.Size(100, 22);
            this.iptDyas.TabIndex = 6;
            // 
            // btnCalCost
            // 
            this.btnCalCost.Location = new System.Drawing.Point(41, 300);
            this.btnCalCost.Name = "btnCalCost";
            this.btnCalCost.Size = new System.Drawing.Size(126, 35);
            this.btnCalCost.TabIndex = 7;
            this.btnCalCost.Text = "Calculate Cost";
            this.btnCalCost.UseVisualStyleBackColor = true;
            this.btnCalCost.Click += new System.EventHandler(this.btnCalCost_Click);
            // 
            // FoodDeliveryCostForm
            // 
            this.AcceptButton = this.btnCalCost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 397);
            this.Controls.Add(this.btnCalCost);
            this.Controls.Add(this.iptDyas);
            this.Controls.Add(this.iptDistance);
            this.Controls.Add(this.iptPeople);
            this.Controls.Add(this.lblDeliverDays);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.resultGroupBox);
            this.Name = "FoodDeliveryCostForm";
            this.Text = "Food Delivery Cost Calculation";
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label optResult;
        private System.Windows.Forms.Label optCCost;
        private System.Windows.Forms.Label optBCost;
        private System.Windows.Forms.Label optACost;
        private System.Windows.Forms.Label lblCCost;
        private System.Windows.Forms.Label lblBCost;
        private System.Windows.Forms.Label lblACost;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDeliverDays;
        private System.Windows.Forms.TextBox iptPeople;
        private System.Windows.Forms.TextBox iptDistance;
        private System.Windows.Forms.TextBox iptDyas;
        private System.Windows.Forms.Button btnCalCost;
    }
}

