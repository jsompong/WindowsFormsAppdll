namespace WindowsFormsAppdll
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
            this.txtFirstNo = new System.Windows.Forms.TextBox();
            this.txtSecNo = new System.Windows.Forms.TextBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SUBbutton = new System.Windows.Forms.Button();
            this.MULbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstNo
            // 
            this.txtFirstNo.Location = new System.Drawing.Point(23, 25);
            this.txtFirstNo.Name = "txtFirstNo";
            this.txtFirstNo.Size = new System.Drawing.Size(74, 20);
            this.txtFirstNo.TabIndex = 0;
            // 
            // txtSecNo
            // 
            this.txtSecNo.Location = new System.Drawing.Point(103, 25);
            this.txtSecNo.Name = "txtSecNo";
            this.txtSecNo.Size = new System.Drawing.Size(79, 20);
            this.txtSecNo.TabIndex = 1;
            // 
            // ADDbutton
            // 
            this.ADDbutton.Location = new System.Drawing.Point(23, 73);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(42, 32);
            this.ADDbutton.TabIndex = 2;
            this.ADDbutton.Text = "+";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(46, 130);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(118, 20);
            this.txtResult.TabIndex = 3;
            // 
            // SUBbutton
            // 
            this.SUBbutton.Location = new System.Drawing.Point(82, 75);
            this.SUBbutton.Name = "SUBbutton";
            this.SUBbutton.Size = new System.Drawing.Size(39, 30);
            this.SUBbutton.TabIndex = 4;
            this.SUBbutton.Text = "-";
            this.SUBbutton.UseVisualStyleBackColor = true;
            this.SUBbutton.Click += new System.EventHandler(this.SUBbutton_Click);
            // 
            // MULbutton
            // 
            this.MULbutton.Location = new System.Drawing.Point(144, 75);
            this.MULbutton.Name = "MULbutton";
            this.MULbutton.Size = new System.Drawing.Size(38, 28);
            this.MULbutton.TabIndex = 5;
            this.MULbutton.Text = "x";
            this.MULbutton.UseVisualStyleBackColor = true;
            this.MULbutton.Click += new System.EventHandler(this.MULbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 192);
            this.Controls.Add(this.MULbutton);
            this.Controls.Add(this.SUBbutton);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.txtSecNo);
            this.Controls.Add(this.txtFirstNo);
            this.Name = "Form1";
            this.Text = "+ / - / x   via DLL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNo;
        private System.Windows.Forms.TextBox txtSecNo;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button SUBbutton;
        private System.Windows.Forms.Button MULbutton;
    }
}

