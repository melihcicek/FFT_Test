using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fft_test
{
    class fourier
    {
        public static double[] FFT(ref double[] x)
        {
            double[] decibel = new double[512];
            int N = x.Length;
            complex[] X = new complex[N];
            for (int k = 0; k < 256; k++)
            {
                X[k] = new complex(0, 0);
                for (int n = 0; n < 512; n++)
                {
                    complex temp = complex.from_polar(x[n], -2 * Math.PI * n * k / N);
                    //temp *= x[n];
                    X[k] += temp;
                }
                decibel[k] = X[k].magnitude/100;//10.0 * Math.Log10(X[k].magnitude);
            }
            return decibel;
        }
       
    }

}
