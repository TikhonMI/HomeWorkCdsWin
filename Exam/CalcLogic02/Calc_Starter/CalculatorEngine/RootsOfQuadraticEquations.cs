using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RootsOfQuadraticEquations
    {
        public string aS { get; set; }
        public string bS { get; set; }
        public string cS { get; set; }
        public string massage;

        public RootsOfQuadraticEquations() 
        {
            aS = "0";
            bS = "0";
            cS = "0";
            massage = "0";
        }

        public string massageAnswer()
        {
            double a = double.Parse(aS);
            double b = double.Parse(bS);
            double c = double.Parse(cS);
            double[] n = { a, b, c };
            var kor = RootSearch(n);
            (int i, double x1, double x2) = kor;
            massage=OutputRoot(i, a, b, c, x1, x2);

            return massage;
        }
        public static string OutputRoot(int i, double a, double b, double c, double x1, double x2)
        {
            switch (i)
            {
                case 0: return ($"x1 = x2 = {x1}"); break;
                case 1: return ($"x1 = {x1}; x2 = {x2}."); break;
                case -1: return ($"Корней нет."); break;
                default: return ("Не является уравнением!"); break;
            }
        }

        public static (int i, double x1, double x2) RootSearch(double[] mas)
        {
            double a = mas[0], b = mas[1], c = mas[2];
            double x1 = 0;
            double x2 = 0;

            int i = 2;

            if (a == 0) { i = 2; }
            else if ((b * b - 4 * a * c) < 0)
            {
                i = -1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                if (x1 == x2)
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }
            }

            return (i, x1, x2);
        }
    }
}
