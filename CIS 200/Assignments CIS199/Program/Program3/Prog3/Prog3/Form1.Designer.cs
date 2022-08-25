
namespace Prog3
{
    partial class uPickItGroceryCostForm
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
            this.lblFarm = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblInitialCost = new System.Windows.Forms.Label();
            this.lblDiscountedCost = new System.Windows.Forms.Label();
            this.lblShipmentCost = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.selectFarm = new System.Windows.Forms.ComboBox();
            this.iptItem = new System.Windows.Forms.TextBox();
            this.iptQuantity = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.optInitialCost = new System.Windows.Forms.Label();
            this.optDiscountedCost = new System.Windows.Forms.Label();
            this.optShipmentCost = new System.Windows.Forms.Label();
            this.optTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFarm
            // 
            this.lblFarm.AutoSize = true;
            this.lblFarm.Location = new System.Drawing.Point(131, 49);
            this.lblFarm.Name = "lblFarm";
            this.lblFarm.Size = new System.Drawing.Size(44, 17);
            this.lblFarm.TabIndex = 0;
            this.lblFarm.Text = "Farm:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(136, 94);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 17);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(77, 140);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 17);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity (lbs):";
            // 
            // lblInitialCost
            // 
            this.lblInitialCost.AutoSize = true;
            this.lblInitialCost.Location = new System.Drawing.Point(81, 231);
            this.lblInitialCost.Name = "lblInitialCost";
            this.lblInitialCost.Size = new System.Drawing.Size(76, 17);
            this.lblInitialCost.TabIndex = 3;
            this.lblInitialCost.Text = "Initial Cost:";
            // 
            // lblDiscountedCost
            // 
            this.lblDiscountedCost.AutoSize = true;
            this.lblDiscountedCost.Location = new System.Drawing.Point(43, 268);
            this.lblDiscountedCost.Name = "lblDiscountedCost";
            this.lblDiscountedCost.Size = new System.Drawing.Size(115, 17);
            this.lblDiscountedCost.TabIndex = 4;
            this.lblDiscountedCost.Text = "Discounted Cost:";
            // 
            // lblShipmentCost
            // 
            this.lblShipmentCost.AutoSize = true;
            this.lblShipmentCost.Location = new System.Drawing.Point(53, 306);
            this.lblShipmentCost.Name = "lblShipmentCost";
            this.lblShipmentCost.Size = new System.Drawing.Size(103, 17);
            this.lblShipmentCost.TabIndex = 5;
            this.lblShipmentCost.Text = "Shipment Cost:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(77, 351);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // selectFarm
            // 
            this.selectFarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFarm.FormattingEnabled = true;
            this.selectFarm.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.selectFarm.Location = new System.Drawing.Point(211, 49);
            this.selectFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFarm.Name = "selectFarm";
            this.selectFarm.Size = new System.Drawing.Size(121, 24);
            this.selectFarm.TabIndex = 7;
            // 
            // iptItem
            // 
            this.iptItem.Location = new System.Drawing.Point(211, 94);
            this.iptItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptItem.Name = "iptItem";
            this.iptItem.Size = new System.Drawing.Size(121, 22);
            this.iptItem.TabIndex = 8;
            // 
            // iptQuantity
            // 
            this.iptQuantity.Location = new System.Drawing.Point(211, 134);
            this.iptQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptQuantity.Name = "iptQuantity";
            this.iptQuantity.Size = new System.Drawing.Size(121, 22);
            this.iptQuantity.TabIndex = 9;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(229, 176);
            this.btnCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 30);
            this.btnCal.TabIndex = 10;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // optInitialCost
            // 
            this.optInitialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optInitialCost.Location = new System.Drawing.Point(208, 228);
            this.optInitialCost.Name = "optInitialCost";
            this.optInitialCost.Size = new System.Drawing.Size(121, 22);
            this.optInitialCost.TabIndex = 11;
            // 
            // optDiscountedCost
            // 
            this.optDiscountedCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optDiscountedCost.Location = new System.Drawing.Point(208, 265);
            this.optDiscountedCost.Name = "optDiscountedCost";
            this.optDiscountedCost.Size = new System.Drawing.Size(121, 22);
            this.optDiscountedCost.TabIndex = 12;
            // 
            // optShipmentCost
            // 
            this.optShipmentCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optShipmentCost.Location = new System.Drawing.Point(208, 304);
            this.optShipmentCost.Name = "optShipmentCost";
            this.optShipmentCost.Size = new System.Drawing.Size(121, 22);
            this.optShipmentCost.TabIndex = 13;
            // 
            // optTotalPrice
            // 
            this.optTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optTotalPrice.Location = new System.Drawing.Point(208, 348);
            this.optTotalPrice.Name = "optTotalPrice";
            this.optTotalPrice.Size = new System.Drawing.Size(121, 22);
            this.optTotalPrice.TabIndex = 14;
            // 
            // uPickItGroceryCostForm
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 421);
            this.Controls.Add(this.optTotalPrice);
            this.Controls.Add(this.optShipmentCost);
            this.Controls.Add(this.optDiscountedCost);
            this.Controls.Add(this.optInitialCost);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.iptQuantity);
            this.Controls.Add(this.iptItem);
            this.Controls.Add(this.selectFarm);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblShipmentCost);
            this.Controls.Add(this.lblDiscountedCost);
            this.Controls.Add(this.lblInitialCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblFarm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uPickItGroceryCostForm";
            this.Text = "uPickItGrocery Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarm;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblInitialCost;
        private System.Windows.Forms.Label lblDiscountedCost;
        private System.Windows.Forms.Label lblShipmentCost;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox selectFarm;
        private System.Windows.Forms.TextBox iptItem;
        private System.Windows.Forms.TextBox iptQuantity;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label optInitialCost;
        private System.Windows.Forms.Label optDiscountedCost;
        private System.Windows.Forms.Label optShipmentCost;
        private System.Windows.Forms.Label optTotalPrice;
    }
}

