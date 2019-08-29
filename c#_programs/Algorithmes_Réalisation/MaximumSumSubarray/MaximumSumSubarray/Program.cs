using System;
using System.Collections;
using System.Collections.Generic;

namespace MaximumSumSubarray
{
    class Program
    {

        static double[] Maximum_Cross_Subarray(double[] A, int low, int middle, int high)
        {
            double[] res = new double[3];
            double left_max = -1000, current_left_sum = 0;
            double right_max = -1000, current_right_sum = 0;
            int left_index = middle;
            int right_index = middle + 1;

            for (int i = middle; i>=low; i--)
            {
                current_left_sum += A[i];
                if(current_left_sum > left_max)
                {
                    left_max = current_left_sum;
                    left_index = i;
                }
            }

            for (int i = middle + 1; i <= high; i++)
            {
                //Console.WriteLine("Current Sum: " + current_right_sum);
                current_right_sum += A[i];

                if (current_right_sum > right_max)
                {
                    right_max = current_right_sum;
                    right_index = i;
                }
            }

            res[0] = left_index;
            res[1] = right_index;
            res[2] = left_max + right_max;
            return res;
        }

        static double[] Maximum_Sum_Subarray(double[] A, int low, int high)
        {
            double[] res = new double[3];
            int n = A.Length;
            if(low == high)
            {
                res[0] = low;
                res[1] = high;
                res[2] = A[low];
                return res;
            }
            int middle = (low + high) / 2;
            double[] left_max_set = Maximum_Sum_Subarray(A, low, middle);
            double[] right_max_set = Maximum_Sum_Subarray(A, middle + 1, high);
            double[] cross_max_set = Maximum_Cross_Subarray(A, low,middle, high);
            
            if(right_max_set[2] > left_max_set[2] && right_max_set[2] > cross_max_set[2])
            {
                return right_max_set;
            }
            else
            {
                if(left_max_set[2] > right_max_set[2] && left_max_set[2] > cross_max_set[2])
                {
                    return left_max_set;
                }
                else
                {
                    return cross_max_set;
                }
            }
        }

        static void Main(string[] args)
        {
            double[] Test_A = { -1,-2,-3,-4};
            Console.WriteLine(Maximum_Sum_Subarray(Test_A, 0, Test_A.Length-1)[0]);
            Console.WriteLine(Maximum_Sum_Subarray(Test_A, 0,  Test_A.Length-1)[1]);
            Console.WriteLine(Maximum_Sum_Subarray(Test_A, 0, Test_A.Length-1)[2]);
        }
    }
}
