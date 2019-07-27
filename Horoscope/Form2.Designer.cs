namespace Horoscope
{
    partial class Form2
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
            this.grbEntire = new System.Windows.Forms.GroupBox();
            this.tbEntire = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbEntire.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEntire
            // 
            this.grbEntire.Controls.Add(this.tbEntire);
            this.grbEntire.Location = new System.Drawing.Point(28, 35);
            this.grbEntire.Name = "grbEntire";
            this.grbEntire.Size = new System.Drawing.Size(490, 579);
            this.grbEntire.TabIndex = 0;
            this.grbEntire.TabStop = false;
            this.grbEntire.Text = "Entire predictions";
            // 
            // tbEntire
            // 
            this.tbEntire.Location = new System.Drawing.Point(6, 36);
            this.tbEntire.Multiline = true;
            this.tbEntire.Name = "tbEntire";
            this.tbEntire.ReadOnly = true;
            this.tbEntire.Size = new System.Drawing.Size(466, 529);
            this.tbEntire.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbEntire);
            this.Name = "Form2";
            this.Text = "Horoscope";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbEntire.ResumeLayout(false);
            this.grbEntire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntire;
        private System.Windows.Forms.TextBox tbEntire;
        private System.Windows.Forms.Button btnClose;
    }
}