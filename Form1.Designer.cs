namespace fft_test
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
            this.btn_FFT = new System.Windows.Forms.Button();
            this.txt_Ornekleme = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Freq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_Freq = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Freq)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FFT
            // 
            this.btn_FFT.Location = new System.Drawing.Point(12, 358);
            this.btn_FFT.Name = "btn_FFT";
            this.btn_FFT.Size = new System.Drawing.Size(75, 23);
            this.btn_FFT.TabIndex = 0;
            this.btn_FFT.Text = "FFT";
            this.btn_FFT.UseVisualStyleBackColor = true;
            this.btn_FFT.Click += new System.EventHandler(this.btn_FFT_Click);
            // 
            // txt_Ornekleme
            // 
            this.txt_Ornekleme.Location = new System.Drawing.Point(113, 300);
            this.txt_Ornekleme.Name = "txt_Ornekleme";
            this.txt_Ornekleme.ReadOnly = true;
            this.txt_Ornekleme.Size = new System.Drawing.Size(100, 20);
            this.txt_Ornekleme.TabIndex = 1;
            this.txt_Ornekleme.Text = "44100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 214);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Freq
            // 
            this.txt_Freq.Location = new System.Drawing.Point(113, 326);
            this.txt_Freq.Name = "txt_Freq";
            this.txt_Freq.Size = new System.Drawing.Size(100, 20);
            this.txt_Freq.TabIndex = 1;
            this.txt_Freq.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frekans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Örnekleme frekansı";
            // 
            // trackBar_Freq
            // 
            this.trackBar_Freq.LargeChange = 172;
            this.trackBar_Freq.Location = new System.Drawing.Point(12, 232);
            this.trackBar_Freq.Maximum = 22000;
            this.trackBar_Freq.Name = "trackBar_Freq";
            this.trackBar_Freq.Size = new System.Drawing.Size(513, 45);
            this.trackBar_Freq.TabIndex = 4;
            this.trackBar_Freq.Scroll += new System.EventHandler(this.trackBar_Freq_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(607, 417);
            this.Controls.Add(this.trackBar_Freq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Freq);
            this.Controls.Add(this.txt_Ornekleme);
            this.Controls.Add(this.btn_FFT);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Freq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
       
        private System.Windows.Forms.Button btn_FFT;
        private System.Windows.Forms.TextBox txt_Ornekleme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Freq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_Freq;
       // private System.Windows.Forms.TrackBar trackB_Freq;
    }
}

