﻿namespace TicTacToc
{
    partial class TicTacToc
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Location = new System.Drawing.Point(81, 58);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 75);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Info;
            this.btn2.Location = new System.Drawing.Point(170, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 75);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Location = new System.Drawing.Point(251, 58);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 75);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Info;
            this.btn4.Location = new System.Drawing.Point(80, 139);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 75);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Info;
            this.btn5.Location = new System.Drawing.Point(170, 139);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 75);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Info;
            this.btn6.Location = new System.Drawing.Point(251, 139);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 75);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Info;
            this.btn7.Location = new System.Drawing.Point(80, 226);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 75);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Info;
            this.btn8.Location = new System.Drawing.Point(170, 226);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 75);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.LeftClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Info;
            this.btn9.Location = new System.Drawing.Point(251, 226);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 75);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.LeftClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(221, 346);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.Exit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicTacToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "TicTacToc";
            this.Text = "Tic Tac Toc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
    }
}

