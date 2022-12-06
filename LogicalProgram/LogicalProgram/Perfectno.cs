using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public  class Perfectno
    {
        public void No()
        {
            int sum = 0;
            Console.WriteLine("Enter the no: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
            {
                Console.WriteLine("Number is a PerfectNumber ");
            }
            else
            {
                Console.WriteLine("Number is not a PerfectNumber");
            }
        }
    }
}
