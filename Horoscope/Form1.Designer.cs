namespace Horoscope
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
            this.lbZodiac = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cmbZodiac = new System.Windows.Forms.ComboBox();
            this.tbPredictions = new System.Windows.Forms.TextBox();
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.tbAddPrediction = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.btnSeeNow = new System.Windows.Forms.Button();
            this.btnEntire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbZodiac
            // 
            this.lbZodiac.AutoSize = true;
            this.lbZodiac.Location = new System.Drawing.Point(34, 71);
            this.lbZodiac.Name = "lbZodiac";
            this.lbZodiac.Size = new System.Drawing.Size(61, 20);
            this.lbZodiac.TabIndex = 0;
            this.lbZodiac.Text = "Zodiac:";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(29, 12);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(439, 42);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TabStop = false;
            this.tbTitle.Text = "HOROSCOPES";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbZodiac
            // 
            this.cmbZodiac.FormattingEnabled = true;
            this.cmbZodiac.ItemHeight = 20;
            this.cmbZodiac.Location = new System.Drawing.Point(101, 68);
            this.cmbZodiac.Name = "cmbZodiac";
            this.cmbZodiac.Size = new System.Drawing.Size(367, 28);
            this.cmbZodiac.TabIndex = 3;
            this.cmbZodiac.SelectedIndexChanged += new System.EventHandler(this.cmbZodiac_SelectedIndexChanged);
            this.cmbZodiac.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbZodiac_Format);
            // 
            // tbPredictions
            // 
            this.tbPredictions.Location = new System.Drawing.Point(29, 122);
            this.tbPredictions.Multiline = true;
            this.tbPredictions.Name = "tbPredictions";
            this.tbPredictions.ReadOnly = true;
            this.tbPredictions.Size = new System.Drawing.Size(216, 254);
            this.tbPredictions.TabIndex = 4;
            // 
            // pbImages
            // 
            this.pbImages.Location = new System.Drawing.Point(251, 122);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(217, 254);
            this.pbImages.TabIndex = 5;
            this.pbImages.TabStop = false;
            // 
            // tbAddPrediction
            // 
            this.tbAddPrediction.Location = new System.Drawing.Point(29, 394);
            this.tbAddPrediction.Multiline = true;
            this.tbAddPrediction.Name = "tbAddPrediction";
            this.tbAddPrediction.Size = new System.Drawing.Size(335, 44);
            this.tbAddPrediction.TabIndex = 6;
            this.tbAddPrediction.Text = "Enter additional prediction";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(380, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.tbRandom);
            this.grb1.Controls.Add(this.btnSeeNow);
            this.grb1.Location = new System.Drawing.Point(29, 455);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(439, 132);
            this.grb1.TabIndex = 8;
            this.grb1.TabStop = false;
            this.grb1.Text = "Today\'s Horoscope";
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(160, 25);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ReadOnly = true;
            this.tbRandom.Size = new System.Drawing.Size(263, 89);
            this.tbRandom.TabIndex = 1;
            // 
            // btnSeeNow
            // 
            this.btnSeeNow.Location = new System.Drawing.Point(19, 36);
            this.btnSeeNow.Name = "btnSeeNow";
            this.btnSeeNow.Size = new System.Drawing.Size(113, 72);
            this.btnSeeNow.TabIndex = 0;
            this.btnSeeNow.Text = "See now";
            this.btnSeeNow.UseVisualStyleBackColor = true;
            this.btnSeeNow.Click += new System.EventHandler(this.btnSeeNow_Click);
            // 
            // btnEntire
            // 
            this.btnEntire.Location = new System.Drawing.Point(29, 602);
            this.btnEntire.Name = "btnEntire";
            this.btnEntire.Size = new System.Drawing.Size(439, 46);
            this.btnEntire.TabIndex = 9;
            this.btnEntire.Text = "See the entire horoscope";
            this.btnEntire.UseVisualStyleBackColor = true;
            this.btnEntire.Click += new System.EventHandler(this.btnEntire_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 671);
            this.Controls.Add(this.btnEntire);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddPrediction);
            this.Controls.Add(this.pbImages);
            this.Controls.Add(this.tbPredictions);
            this.Controls.Add(this.cmbZodiac);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbZodiac);
            this.Name = "Form1";
            this.Text = "Horoscope Prediction";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbZodiac;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ComboBox cmbZodiac;
        private System.Windows.Forms.TextBox tbPredictions;
        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.TextBox tbAddPrediction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnSeeNow;
        private System.Windows.Forms.Button btnEntire;
    }
}

