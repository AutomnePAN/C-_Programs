using System;

namespace Test_Parameters
{
    class Program
    {
        static double Sum(out double sum_val, params double[] array)
        {
            sum_val = 0;
            double sum = 0;
            foreach(double val in array)
            {
                sum += val;
                sum_val = sum;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double sum_val = 0.0;
            double [] array = { 1.2, 3.4, 5.6 ,7.8};

            Console.WriteLine("The sum of the array is : {0}, {1}", Sum(out sum_val,1.2,3.4,5.6,7.8), sum_val);
        }
    }
}
