namespace veri_taban
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lableAd = new System.Windows.Forms.Label();
            this.labelSoy = new System.Windows.Forms.Label();
            this.labelDogum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonKayıd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableAd
            // 
            this.lableAd.AutoSize = true;
            this.lableAd.Location = new System.Drawing.Point(105, 47);
            this.lableAd.Name = "lableAd";
            this.lableAd.Size = new System.Drawing.Size(29, 15);
            this.lableAd.TabIndex = 0;
            this.lableAd.Text = "AD :";
            this.lableAd.Click += new System.EventHandler(this.lableAd_Click);
            // 
            // labelSoy
            // 
            this.labelSoy.AutoSize = true;
            this.labelSoy.Location = new System.Drawing.Point(87, 87);
            this.labelSoy.Name = "labelSoy";
            this.labelSoy.Size = new System.Drawing.Size(47, 15);
            this.labelSoy.TabIndex = 1;
            this.labelSoy.Text = "SoyAd :";
            this.labelSoy.Click += new System.EventHandler(this.labelSoy_Click);
            // 
            // labelDogum
            // 
            this.labelDogum.AutoSize = true;
            this.labelDogum.Location = new System.Drawing.Point(44, 127);
            this.labelDogum.Name = "labelDogum";
            this.labelDogum.Size = new System.Drawing.Size(90, 15);
            this.labelDogum.TabIndex = 2;
            this.labelDogum.Text = "Doğum Yeriniz :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 23);
            this.textBox3.TabIndex = 5;
            // 
            // buttonKayıd
            // 
            this.buttonKayıd.Location = new System.Drawing.Point(171, 170);
            this.buttonKayıd.Name = "buttonKayıd";
            this.buttonKayıd.Size = new System.Drawing.Size(98, 32);
            this.buttonKayıd.TabIndex = 6;
            this.buttonKayıd.Text = "KAYIDET";
            this.buttonKayıd.UseVisualStyleBackColor = true;
            this.buttonKayıd.Click += new System.EventHandler(this.buttonKayıd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 232);
            this.Controls.Add(this.buttonKayıd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDogum);
            this.Controls.Add(this.labelSoy);
            this.Controls.Add(this.lableAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lableAd;
        private Label labelSoy;
        private Label labelDogum;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonKayıd;
    }
}