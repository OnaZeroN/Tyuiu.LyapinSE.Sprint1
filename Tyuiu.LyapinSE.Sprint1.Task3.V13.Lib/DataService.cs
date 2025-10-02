using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LyapinSE.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int n = (int)number;               
            int a = n / 100;                   
            int b = (n / 10) % 10;             
            int c = n % 10;                    

            double result = a * b * c;         
            return Math.Round(result, 3);      
        }
    }
}
