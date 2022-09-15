using System;

namespace Macierze_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////  1 test
            var arr1 = new int[3, 3]
            {
                {1, 2, 3},
                {1, 2, 3},
                {1, 2, 3}
            };
            Console.WriteLine(DiagonalAbsolue(3, arr1));

            //////////////////////////////////////////  2 test
            var arr2 = new int[3, 3]
            {
                {10, 2, 5},
                {1, 10, 3},
                {5, 2, 10}
            };
            Console.WriteLine(DiagonalAbsolue(3, arr2));

            //////////////////////////////////////////  3 test
            var arr3 = new int[3, 3]
            {
                {10, 2, 5},
                {1, 10, 3},
                {5, 2, 10}
            };
            Console.WriteLine(DiagonalAbsolue(4, arr3));
        }

        static int DiagonalAbsolue(int n, int[,] arr) {
            
            int SumR = 0, SumL = 0;

            try{
                for(int i=0; i<n; i++) {
                    SumL += arr[i, i];
                    SumR += arr[Math.Abs(i-n+1), i];
                }
            }
            catch(System.Exception){
                return -1;
            }

            //Console.WriteLine($"SumR: {SumR}, SumL {SumL}");
            return Math.Abs(SumR-SumL);
        }
    }
}
