namespace UPVApp
{
    partial class Prog2Form
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
            this.menuStripForm2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.menuStripForm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripForm2
            // 
            this.menuStripForm2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripForm2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStripForm2.Location = new System.Drawing.Point(0, 0);
            this.menuStripForm2.Name = "menuStripForm2";
            this.menuStripForm2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripForm2.Size = new System.Drawing.Size(625, 28);
            this.menuStripForm2.TabIndex = 0;
            this.menuStripForm2.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.letterToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addressToolStripMenuItem.Text = "&Address";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem
            // 
            this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            this.letterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.letterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.letterToolStripMenuItem.Text = "&Letter";
            this.letterToolStripMenuItem.Click += new System.EventHandler(this.letterToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressToolStripMenuItem,
            this.listParcelToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // listAddressToolStripMenuItem
            // 
            this.listAddressToolStripMenuItem.Name = "listAddressToolStripMenuItem";
            this.listAddressToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.listAddressToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listAddressToolStripMenuItem.Text = "List &Addresses";
            this.listAddressToolStripMenuItem.Click += new System.EventHandler(this.listAddressToolStripMenuItem_Click);
            // 
            // listParcelToolStripMenuItem
            // 
            this.listParcelToolStripMenuItem.Name = "listParcelToolStripMenuItem";
            this.listParcelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.listParcelToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listParcelToolStripMenuItem.Text = "List &Parcels";
            this.listParcelToolStripMenuItem.Click += new System.EventHandler(this.listParcelToolStripMenuItem_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(12, 44);
            this.textBoxReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ReadOnly = true;
            this.textBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReport.Size = new System.Drawing.Size(601, 339);
            this.textBoxReport.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 395);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.menuStripForm2);
            this.MainMenuStrip = this.menuStripForm2;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prog2Form";
            this.Text = "Program2";
            this.Load += new System.EventHandler(this.Prog2Form_Load);
            this.menuStripForm2.ResumeLayout(false);
            this.menuStripForm2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripForm2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

