﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib {
    class Program {
        static void Main(string[] args) {
            var a = new Quaternion(1, 2, 3, 4);
            var b = new Quaternion(8, 7, 6, 5);
            var c = new Quaternion(9, 11, 13, 10);

            Console.WriteLine();
            Console.WriteLine("Quaternion Tests");
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.Write("a) \t" + ((a + b + c) == (c + b + a)).ToString() + " \t");
            Console.WriteLine((a + b + c).ToString() + "\t\t\t= \t" + (c + b + a).ToString());

            Console.Write("b) \t" + ((a * b) == (b * a)).ToString() + " \t");
            Console.WriteLine((a * b).ToString() + "\t\t\t= \t" + (b * a).ToString());

            Console.Write("c) \t" + (((a + b) * c) == (a * c + b * c)).ToString() + " \t");
            Console.WriteLine(((a + b) * c).ToString() + "\t\t= \t" + (a * c + b * c).ToString());

            Console.Write("d) \t" + (((a * b) * c) == (a * (b * c))).ToString() + " \t");
            Console.WriteLine(((a * b) * c).ToString() + "\t\t= \t" + (a * (b * c)).ToString());

            Console.WriteLine();

            Console.Write("Division:");
            Console.WriteLine("\t" + (a * b) / a);

            Console.Write("Inverse:");
            Console.WriteLine("\t" + a.Inverse() + "\t= \t" + Quaternion.Conjugate(a) / Math.Pow(a.Abs(), 2));

            var d = new Matrix4X4();
            var e = new Matrix4X4(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            var f = new Matrix4X4(new double[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } });

            Console.WriteLine();
            Console.WriteLine("Matrix Tests");
            Console.WriteLine("------------");
            Console.WriteLine();

            Console.WriteLine("Initialization:");
            Console.WriteLine(d.ToString());

            Console.WriteLine("d + e:");
            Console.WriteLine((d + e).ToString());

            Console.WriteLine("d - e:");
            Console.WriteLine((d - e).ToString());

            Console.WriteLine("e * f:");
            Console.WriteLine((e * f).ToString());

            Console.ReadLine();
        }
    }
}