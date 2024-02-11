using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace CalculationFunction
{
    //3. создаем класс логики
    public class Logic
    {
        public string First { get; set; }
        public string Last { get; set; }
        public double Step = 0.1;
        
        public Logic() 
        {
            First = "0";
            Last = "0";
        }

        public string Massage()
        {
            return "Левая граница: "+ First + ", правая граница: " + Last;

            //double a = Convert.ToDouble(First);
            //return "Тест"+ a + "; " + Math.Sin(a);
        }

        public string[] PrintArr()
        {
            double a = Convert.ToDouble(First);
            double b = Convert.ToDouble(Last);
            int i=0;
            int c=0;
             

            if (a < b)
            {
                c = Convert.ToInt32((b - a) / Step)+1;
                string[] arr = new string[c];
                while (a < b)
                {
                    arr[i] = Math.Round(a, 2) + ": " + Math.Round(Math.Sin(a),2);
                    Math.Round(a += Step,2);
                    i++;
                }
                return arr;
            }
            else if (a > b)
            {
                c = Convert.ToInt32((a - b) / Step)+1;
                string[] arr = new string[c];
                while(a > b)
                {
                    arr[i] = Math.Round(a, 2) + ": " + Math.Round(Math.Sin(a), 2);
                    Math.Round(a -= Step, 2);
                    i++;
                }
                return arr;
            }
            else 
            {
                string[] arr = { Math.Round(a, 2) + ": " + Math.Round(Math.Sin(a), 2) };
                return arr;
            }

            
            
            //for (double i = a; i < b; i++) { }

        }
    }
}
