namespace EightPuzzle
{
    partial class Form1
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
            this.t0 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.movesTB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t0
            // 
            this.t0.Location = new System.Drawing.Point(12, 12);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(42, 20);
            this.t0.TabIndex = 0;
            this.t0.Text = "8";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(60, 12);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(42, 20);
            this.t1.TabIndex = 1;
            this.t1.Text = "1";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(108, 12);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(42, 20);
            this.t2.TabIndex = 2;
            this.t2.Text = "7";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(12, 38);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(42, 20);
            this.t3.TabIndex = 3;
            this.t3.Text = "4";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(60, 38);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(42, 20);
            this.t4.TabIndex = 4;
            this.t4.Text = "5";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(108, 38);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(42, 20);
            this.t5.TabIndex = 5;
            this.t5.Text = "6";
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(12, 64);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(42, 20);
            this.t6.TabIndex = 6;
            this.t6.Text = "2";
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(60, 64);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(42, 20);
            this.t7.TabIndex = 7;
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(108, 64);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(42, 20);
            this.t8.TabIndex = 8;
            this.t8.Text = "3";
            // 
            // movesTB
            // 
            this.movesTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movesTB.Location = new System.Drawing.Point(172, 12);
            this.movesTB.Name = "movesTB";
            this.movesTB.ReadOnly = true;
            this.movesTB.Size = new System.Drawing.Size(180, 96);
            this.movesTB.TabIndex = 9;
            this.movesTB.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movesTB);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t0);
            this.Name = "Form1";
            this.Text = "EightPuzzle Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t0;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.RichTextBox movesTB;
        private System.Windows.Forms.Button button1;
    }
}

