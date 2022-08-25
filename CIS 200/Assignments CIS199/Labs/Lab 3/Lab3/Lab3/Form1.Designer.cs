
namespace Lab3
{
    partial class sphereCalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sphereCalForm));
            this.upperLeftPic = new System.Windows.Forms.PictureBox();
            this.lowerRightPic = new System.Windows.Forms.PictureBox();
            this.radiusOfSphere = new System.Windows.Forms.Label();
            this.iptRadius = new System.Windows.Forms.TextBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolumn = new System.Windows.Forms.Label();
            this.lblOptDiameter = new System.Windows.Forms.Label();
            this.lblOptSurfaceArea = new System.Windows.Forms.Label();
            this.lblOptVolumn = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upperLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerRightPic)).BeginInit();
            this.SuspendLayout();
            // 
            // upperLeftPic
            // 
            this.upperLeftPic.Image = ((System.Drawing.Image)(resources.GetObject("upperLeftPic.Image")));
            this.upperLeftPic.Location = new System.Drawing.Point(12, 12);
            this.upperLeftPic.Name = "upperLeftPic";
            this.upperLeftPic.Size = new System.Drawing.Size(150, 150);
            this.upperLeftPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upperLeftPic.TabIndex = 0;
            this.upperLeftPic.TabStop = false;
            // 
            // lowerRightPic
            // 
            this.lowerRightPic.Image = ((System.Drawing.Image)(resources.GetObject("lowerRightPic.Image")));
            this.lowerRightPic.Location = new System.Drawing.Point(220, 183);
            this.lowerRightPic.Name = "lowerRightPic";
            this.lowerRightPic.Size = new System.Drawing.Size(150, 150);
            this.lowerRightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lowerRightPic.TabIndex = 1;
            this.lowerRightPic.TabStop = false;
            // 
            // radiusOfSphere
            // 
            this.radiusOfSphere.AutoSize = true;
            this.radiusOfSphere.Location = new System.Drawing.Point(168, 47);
            this.radiusOfSphere.Name = "radiusOfSphere";
            this.radiusOfSphere.Size = new System.Drawing.Size(103, 15);
            this.radiusOfSphere.TabIndex = 2;
            this.radiusOfSphere.Text = "Radius of sphere:";
            // 
            // iptRadius
            // 
            this.iptRadius.Location = new System.Drawing.Point(274, 47);
            this.iptRadius.Name = "iptRadius";
            this.iptRadius.Size = new System.Drawing.Size(90, 20);
            this.iptRadius.TabIndex = 3;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(36, 184);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(58, 15);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Diameter";
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.AutoSize = true;
            this.lblSurfaceArea.Location = new System.Drawing.Point(17, 232);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(77, 15);
            this.lblSurfaceArea.TabIndex = 5;
            this.lblSurfaceArea.Text = "Surface Area";
            // 
            // lblVolumn
            // 
            this.lblVolumn.AutoSize = true;
            this.lblVolumn.Location = new System.Drawing.Point(45, 279);
            this.lblVolumn.Name = "lblVolumn";
            this.lblVolumn.Size = new System.Drawing.Size(49, 15);
            this.lblVolumn.TabIndex = 6;
            this.lblVolumn.Text = "Volumn";
            // 
            // lblOptDiameter
            // 
            this.lblOptDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptDiameter.Location = new System.Drawing.Point(100, 183);
            this.lblOptDiameter.Name = "lblOptDiameter";
            this.lblOptDiameter.Size = new System.Drawing.Size(85, 20);
            this.lblOptDiameter.TabIndex = 7;
            this.lblOptDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOptSurfaceArea
            // 
            this.lblOptSurfaceArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptSurfaceArea.Location = new System.Drawing.Point(100, 231);
            this.lblOptSurfaceArea.Name = "lblOptSurfaceArea";
            this.lblOptSurfaceArea.Size = new System.Drawing.Size(85, 20);
            this.lblOptSurfaceArea.TabIndex = 8;
            this.lblOptSurfaceArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOptVolumn
            // 
            this.lblOptVolumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptVolumn.Location = new System.Drawing.Point(100, 276);
            this.lblOptVolumn.Name = "lblOptVolumn";
            this.lblOptVolumn.Size = new System.Drawing.Size(85, 20);
            this.lblOptVolumn.TabIndex = 9;
            this.lblOptVolumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(283, 82);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 25);
            this.btnCal.TabIndex = 10;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // sphereCalForm
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblOptVolumn);
            this.Controls.Add(this.lblOptSurfaceArea);
            this.Controls.Add(this.lblOptDiameter);
            this.Controls.Add(this.lblVolumn);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.iptRadius);
            this.Controls.Add(this.radiusOfSphere);
            this.Controls.Add(this.lowerRightPic);
            this.Controls.Add(this.upperLeftPic);
            this.Name = "sphereCalForm";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.upperLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerRightPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox upperLeftPic;
        private System.Windows.Forms.PictureBox lowerRightPic;
        private System.Windows.Forms.Label radiusOfSphere;
        private System.Windows.Forms.TextBox iptRadius;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolumn;
        private System.Windows.Forms.Label lblOptDiameter;
        private System.Windows.Forms.Label lblOptSurfaceArea;
        private System.Windows.Forms.Label lblOptVolumn;
        private System.Windows.Forms.Button btnCal;
    }
}

