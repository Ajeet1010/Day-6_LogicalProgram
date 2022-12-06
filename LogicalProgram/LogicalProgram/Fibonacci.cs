using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Fiboncci
    {
        public void Series()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 1, num3=0;

            for (int i = 0; i < num; i++)
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                Console.WriteLine(num3);

                
            }
        }
    }
}
