using System.Diagnostics.CodeAnalysis;

namespace MathProblem
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            double temp = 0;
            double j = 0;
            double[] numbers = new double[10];
            for(int i = 0; i < 11; i++)
            {
                  while(j<123456789)
                  {
                     j =  i +j*10;
                    numbers[i] = j/ Math.Pow(10, i);
                    Console.WriteLine(numbers[i]);
                    break;
                  }
            }
            
        }
    }
}