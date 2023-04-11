using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Mencari nilai terkecil dan nilai terbesar
            Numbers numbers1 = new Numbers();
            Numbers numbers2 = new Numbers();
            Numbers numbers3 = new Numbers();

            numbers1.cariNilaiMin(2, 3);
            numbers2.cariNilaiMin(2, 3, 4);
            numbers3.cariNilaiMax(2, 8);
            numbers3.cariNilaiMax(2, 3, 5);
        }

    }
}