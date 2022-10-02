
namespace Prog2
{
    partial class AddressInputBox
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblline1 = new System.Windows.Forms.Label();
            this.lblline2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLine1 = new System.Windows.Forms.TextBox();
            this.textBoxLine2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblline1
            // 
            this.lblline1.AutoSize = true;
            this.lblline1.Location = new System.Drawing.Point(62, 100);
            this.lblline1.Name = "lblline1";
            this.lblline1.Size = new System.Drawing.Size(51, 17);
            this.lblline1.TabIndex = 1;
            this.lblline1.Text = "Line 1:";
            // 
            // lblline2
            // 
            this.lblline2.AutoSize = true;
            this.lblline2.Location = new System.Drawing.Point(62, 157);
            this.lblline2.Name = "lblline2";
            this.lblline2.Size = new System.Drawing.Size(51, 17);
            this.lblline2.TabIndex = 2;
            this.lblline2.Text = "Line 2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(78, 207);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(68, 264);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 17);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State:";
            // 
            // textBoxName
            // 
            this.textBoxName.AllowDrop = true;
            this.textBoxName.Location = new System.Drawing.Point(145, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // textBoxLine1
            // 
            this.textBoxLine1.AllowDrop = true;
            this.textBoxLine1.Location = new System.Drawing.Point(145, 94);
            this.textBoxLine1.Name = "textBoxLine1";
            this.textBoxLine1.Size = new System.Drawing.Size(200, 22);
            this.textBoxLine1.TabIndex = 6;
            this.textBoxLine1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLine1_Validating);
            this.textBoxLine1.Validated += new System.EventHandler(this.textBoxLine1_Validated);
            // 
            // textBoxLine2
            // 
            this.textBoxLine2.AllowDrop = true;
            this.textBoxLine2.Location = new System.Drawing.Point(145, 151);
            this.textBoxLine2.Name = "textBoxLine2";
            this.textBoxLine2.Size = new System.Drawing.Size(200, 22);
            this.textBoxLine2.TabIndex = 7;
            this.textBoxLine2.TextChanged += new System.EventHandler(this.textBoxLine2_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.AllowDrop = true;
            this.textBoxCity.Location = new System.Drawing.Point(145, 204);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 22);
            this.textBoxCity.TabIndex = 8;
            this.textBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCity_Validating);
            this.textBoxCity.Validated += new System.EventHandler(this.textBoxCity_Validated);
            // 
            // textBoxZip
            // 
            this.textBoxZip.AllowDrop = true;
            this.textBoxZip.Location = new System.Drawing.Point(145, 318);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 22);
            this.textBoxZip.TabIndex = 9;
            this.textBoxZip.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxZip_Validating);
            this.textBoxZip.Validated += new System.EventHandler(this.textBoxZip_Validated);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(44, 318);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(69, 17);
            this.lblZip.TabIndex = 10;
            this.lblZip.Text = "Zip Code:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.AllowDrop = true;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "KY",
            "CA",
            "NY",
            "WA",
            "FL",
            "OH"});
            this.comboBoxState.Location = new System.Drawing.Point(145, 261);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxState.TabIndex = 11;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            this.comboBoxState.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxState_Validating);
            this.comboBoxState.Validated += new System.EventHandler(this.comboBoxState_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // AddressInputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 427);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxLine2);
            this.Controls.Add(this.textBoxLine1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblline2);
            this.Controls.Add(this.lblline1);
            this.Controls.Add(this.lblName);
            this.Name = "AddressInputBox";
            this.Text = "AddressInputBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblline1;
        private System.Windows.Forms.Label lblline2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLine1;
        private System.Windows.Forms.TextBox textBoxLine2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
    }
}