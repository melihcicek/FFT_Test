using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;



namespace fft_test
{
    public partial class Form1 : Form
    {
       
        private Bitmap _canvasFrequencyDomain;
        public double[] _fft = new double[512];
        private double[] Input_Buffer = new double[512];
        private double dt = 0.0001;
        private double freq = 4000;
        int i;
        
        public Form1()
        {
            InitializeComponent();    
       
       
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
 
           
        }

        private void btn_FFT_Click(object sender, EventArgs e)
        {
            
            dt = Convert.ToDouble( 1) / Convert.ToDouble(txt_Ornekleme.Text);
            freq = Convert.ToDouble(txt_Freq.Text);
            for (i = 0; i < 512; i++)
            {
                Input_Buffer[i] = 30 * Math.Sin(2 * Math.PI * freq * i * dt) + 10 * Math.Sin(2 * Math.PI * freq*3 * i * dt);
            }

            _fft = fourier.FFT(ref Input_Buffer);
       
            RenderFrequencyDomain(ref pictureBox1, ref _fft);
        }

        private void trackBar_Freq_Scroll(object sender, EventArgs e)
        {
            txt_Freq.Text = trackBar_Freq.Value.ToString();
            dt = Convert.ToDouble(1) / Convert.ToDouble(txt_Ornekleme.Text);
            freq = Convert.ToDouble(trackBar_Freq.Value);
            for (i = 0; i < 512; i++)
            {
                Input_Buffer[i] = 30 * Math.Sin(2 * Math.PI * freq * i * dt)/* + 10 * Math.Sin(2 * Math.PI * freq * 3 * i * dt)*/; 
            }

            _fft = fourier.FFT(ref Input_Buffer);
    
            RenderFrequencyDomain(ref pictureBox1, ref _fft);
        }




        public void RenderFrequencyDomain(ref PictureBox pictureBox, ref double[] fft)
        {
            // Set up for drawing
            _canvasFrequencyDomain = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics offScreenDC = Graphics.FromImage(_canvasFrequencyDomain);
            SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(0, 0, 0));
            Pen pen = new System.Drawing.Pen(Color.WhiteSmoke);

        
            int width = _canvasFrequencyDomain.Width;
            int height = _canvasFrequencyDomain.Height;

          
         

            int rightTop = 0;
            int rightRight = width;
            int rightBottom = height;
            int fft_Index = 0;
            for (int xAxis = 0; xAxis < 512; xAxis++)
            {
                double amplitude = (int)fft[fft_Index++];

                if (amplitude < 0)
                    amplitude = 0;
                int yAxis = (int)(rightBottom - ((rightBottom - rightTop) * amplitude) / 100);
                pen.Color = pen.Color = Color.LimeGreen;//Color.FromArgb(0, 0, (int)amplitude % 255);
                offScreenDC.DrawLine(pen, xAxis, rightBottom, xAxis, yAxis);
                xAxis++;
                offScreenDC.DrawLine(pen, xAxis, rightBottom, xAxis, yAxis);
            }

            // Clean up
            pictureBox.Image = _canvasFrequencyDomain;
            offScreenDC.Dispose();
        }

 


    }
}
