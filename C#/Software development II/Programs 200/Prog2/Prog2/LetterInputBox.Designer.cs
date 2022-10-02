
namespace Prog2
{
    partial class LetterInputBox
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
            this.lblOrignAddress = new System.Windows.Forms.Label();
            this.lblDesAddress = new System.Windows.Forms.Label();
            this.lblFixedCost = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderLetter = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrignAddress
            // 
            this.lblOrignAddress.AutoSize = true;
            this.lblOrignAddress.Location = new System.Drawing.Point(49, 39);
            this.lblOrignAddress.Name = "lblOrignAddress";
            this.lblOrignAddress.Size = new System.Drawing.Size(106, 17);
            this.lblOrignAddress.TabIndex = 0;
            this.lblOrignAddress.Text = "Origin Address:";
            // 
            // lblDesAddress
            // 
            this.lblDesAddress.AutoSize = true;
            this.lblDesAddress.Location = new System.Drawing.Point(8, 76);
            this.lblDesAddress.Name = "lblDesAddress";
            this.lblDesAddress.Size = new System.Drawing.Size(147, 17);
            this.lblDesAddress.TabIndex = 1;
            this.lblDesAddress.Text = "Denstination Address:";
            // 
            // lblFixedCost
            // 
            this.lblFixedCost.AutoSize = true;
            this.lblFixedCost.Location = new System.Drawing.Point(78, 116);
            this.lblFixedCost.Name = "lblFixedCost";
            this.lblFixedCost.Size = new System.Drawing.Size(77, 17);
            this.lblFixedCost.TabIndex = 2;
            this.lblFixedCost.Text = "Fixed Cost:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2_Validating);
            this.comboBox2.Validated += new System.EventHandler(this.comboBox2_Validated);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(176, 116);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxCost.TabIndex = 5;
            this.textBoxCost.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBoxCost.Validated += new System.EventHandler(this.textBoxCost_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(52, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 31);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProviderLetter
            // 
            this.errorProviderLetter.ContainerControl = this;
            // 
            // LetterInputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFixedCost);
            this.Controls.Add(this.lblDesAddress);
            this.Controls.Add(this.lblOrignAddress);
            this.Name = "LetterInputBox";
            this.Text = "LetterInputBox";
            this.Load += new System.EventHandler(this.LetterInputBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrignAddress;
        private System.Windows.Forms.Label lblDesAddress;
        private System.Windows.Forms.Label lblFixedCost;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderLetter;
    }
}