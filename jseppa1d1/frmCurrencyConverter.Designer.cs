namespace jseppa1d1
{
    partial class frmCurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyConverter));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDBrazil = new System.Windows.Forms.TextBox();
            this.txtUSDIsrael = new System.Windows.Forms.TextBox();
            this.txtUSDBhutan = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRateBrazil = new System.Windows.Forms.TextBox();
            this.txtRateIsrael = new System.Windows.Forms.TextBox();
            this.txtRateBhutan = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtAmountBrazil = new System.Windows.Forms.TextBox();
            this.txtAmountIsrael = new System.Windows.Forms.TextBox();
            this.txtAmountBhutan = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 27);
            this.btnExit.TabIndex = 92;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 27);
            this.btnReset.TabIndex = 90;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 29);
            this.label9.TabIndex = 109;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "$ US";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(674, 202);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(132, 22);
            this.txtTotalUSD.TabIndex = 110;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDBrazil
            // 
            this.txtUSDBrazil.Location = new System.Drawing.Point(501, 202);
            this.txtUSDBrazil.Name = "txtUSDBrazil";
            this.txtUSDBrazil.ReadOnly = true;
            this.txtUSDBrazil.Size = new System.Drawing.Size(122, 22);
            this.txtUSDBrazil.TabIndex = 108;
            this.txtUSDBrazil.TabStop = false;
            this.txtUSDBrazil.Text = "0.00";
            this.txtUSDBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDBrazil.TextChanged += new System.EventHandler(this.usdTextChanged);
            // 
            // txtUSDIsrael
            // 
            this.txtUSDIsrael.Location = new System.Drawing.Point(363, 202);
            this.txtUSDIsrael.Name = "txtUSDIsrael";
            this.txtUSDIsrael.ReadOnly = true;
            this.txtUSDIsrael.Size = new System.Drawing.Size(132, 22);
            this.txtUSDIsrael.TabIndex = 107;
            this.txtUSDIsrael.TabStop = false;
            this.txtUSDIsrael.Text = "0.00";
            this.txtUSDIsrael.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDIsrael.TextChanged += new System.EventHandler(this.usdTextChanged);
            // 
            // txtUSDBhutan
            // 
            this.txtUSDBhutan.Location = new System.Drawing.Point(216, 202);
            this.txtUSDBhutan.Name = "txtUSDBhutan";
            this.txtUSDBhutan.ReadOnly = true;
            this.txtUSDBhutan.Size = new System.Drawing.Size(141, 22);
            this.txtUSDBhutan.TabIndex = 106;
            this.txtUSDBhutan.TabStop = false;
            this.txtUSDBhutan.Text = "0.00";
            this.txtUSDBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDBhutan.TextChanged += new System.EventHandler(this.usdTextChanged);
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(78, 202);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(132, 22);
            this.txtUSDAustralia.TabIndex = 105;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDAustralia.TextChanged += new System.EventHandler(this.usdTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "Amount:";
            // 
            // txtRateBrazil
            // 
            this.txtRateBrazil.Location = new System.Drawing.Point(501, 174);
            this.txtRateBrazil.Name = "txtRateBrazil";
            this.txtRateBrazil.Size = new System.Drawing.Size(122, 22);
            this.txtRateBrazil.TabIndex = 96;
            this.txtRateBrazil.Text = "0.244712";
            this.txtRateBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBrazil.TextChanged += new System.EventHandler(this.brazilTextChanged);
            // 
            // txtRateIsrael
            // 
            this.txtRateIsrael.Location = new System.Drawing.Point(363, 174);
            this.txtRateIsrael.Name = "txtRateIsrael";
            this.txtRateIsrael.Size = new System.Drawing.Size(132, 22);
            this.txtRateIsrael.TabIndex = 95;
            this.txtRateIsrael.Text = "0.279117";
            this.txtRateIsrael.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateIsrael.TextChanged += new System.EventHandler(this.israelTextChanged);
            // 
            // txtRateBhutan
            // 
            this.txtRateBhutan.Location = new System.Drawing.Point(216, 174);
            this.txtRateBhutan.Name = "txtRateBhutan";
            this.txtRateBhutan.Size = new System.Drawing.Size(141, 22);
            this.txtRateBhutan.TabIndex = 94;
            this.txtRateBhutan.Text = "0.0137809";
            this.txtRateBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBhutan.TextChanged += new System.EventHandler(this.bhutanTextChanged);
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(78, 174);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(132, 22);
            this.txtRateAustralia.TabIndex = 93;
            this.txtRateAustralia.Text = "0.711178";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.australiaTextChanged);
            // 
            // txtAmountBrazil
            // 
            this.txtAmountBrazil.Location = new System.Drawing.Point(501, 146);
            this.txtAmountBrazil.Name = "txtAmountBrazil";
            this.txtAmountBrazil.Size = new System.Drawing.Size(122, 22);
            this.txtAmountBrazil.TabIndex = 89;
            this.txtAmountBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBrazil.TextChanged += new System.EventHandler(this.brazilTextChanged);
            // 
            // txtAmountIsrael
            // 
            this.txtAmountIsrael.Location = new System.Drawing.Point(363, 146);
            this.txtAmountIsrael.Name = "txtAmountIsrael";
            this.txtAmountIsrael.Size = new System.Drawing.Size(132, 22);
            this.txtAmountIsrael.TabIndex = 87;
            this.txtAmountIsrael.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountIsrael.TextChanged += new System.EventHandler(this.israelTextChanged);
            // 
            // txtAmountBhutan
            // 
            this.txtAmountBhutan.Location = new System.Drawing.Point(216, 146);
            this.txtAmountBhutan.Name = "txtAmountBhutan";
            this.txtAmountBhutan.Size = new System.Drawing.Size(141, 22);
            this.txtAmountBhutan.TabIndex = 84;
            this.txtAmountBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBhutan.TextChanged += new System.EventHandler(this.bhutanTextChanged);
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(78, 146);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(132, 22);
            this.txtAmountAustralia.TabIndex = 83;
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.australiaTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "US Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Brazil Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Israeli Shekel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Bhutanese Ngultrum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Australian Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(674, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 111);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 91;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(363, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 111);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 88;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(501, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // frmCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 283);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDBrazil);
            this.Controls.Add(this.txtUSDIsrael);
            this.Controls.Add(this.txtUSDBhutan);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRateBrazil);
            this.Controls.Add(this.txtRateIsrael);
            this.Controls.Add(this.txtRateBhutan);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtAmountBrazil);
            this.Controls.Add(this.txtAmountIsrael);
            this.Controls.Add(this.txtAmountBhutan);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCurrencyConverter";
            this.Text = "jseppa1d1: Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDBrazil;
        private System.Windows.Forms.TextBox txtUSDIsrael;
        private System.Windows.Forms.TextBox txtUSDBhutan;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRateBrazil;
        private System.Windows.Forms.TextBox txtRateIsrael;
        private System.Windows.Forms.TextBox txtRateBhutan;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtAmountBrazil;
        private System.Windows.Forms.TextBox txtAmountIsrael;
        private System.Windows.Forms.TextBox txtAmountBhutan;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

