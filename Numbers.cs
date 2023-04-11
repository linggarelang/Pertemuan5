using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Numbers
    {
        public int cariNilaiMin(int a, int b)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai Minimum dari kedua nilai adalah : {0} ", min = a);
            }
            else
            {
                Console.WriteLine("Nilai Minimum dari kedua nilai adalah : {0} ", min = b);
            }

            return min;
        }
        public int cariNilaiMin(int a, int b, int c)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai Minimum dari ketiga nilai adalah : {0} ", min = a);
            }
            else if (b < c)
            {
                Console.WriteLine("Nilai Minimum dari ketiga nilai adalah : {0} ", min = b);
            }
            else
            {
                Console.WriteLine("Nilai Minimum dari ketiga nilai adalah : {0} ", min = c);
            }

            return min;
        }

        public int cariNilaiMax(int a, int b)
        {
            int min;
            if (a > b)
            {
                Console.WriteLine("Nilai Maksimum dari kedua nilai adalah : {0} ", min = a);
            }
            else
            {
                Console.WriteLine("Nilai Maksimum dari kedua nilai adalah : {0} ", min = b);
            }

            return min;
        }
        public int cariNilaiMax(int a, int b, int c)
        {
            int min;
            if (a > b)
            {
                Console.WriteLine("Nilai Maksimum dari ketiga nilai adalah : {0} ", min = a);
            }
            else if (b > c)
            {
                Console.WriteLine("Nilai Maksimum dari ketiga nilai adalah : {0} ", min = b);
            }
            else
            {
                Console.WriteLine("Nilai Maksimum dari ketiga nilai adalah : {0} ", min = c);
            }

            return min;
        }
    }
}