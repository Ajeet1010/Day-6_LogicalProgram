using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Primeno
    {
        public void Prime()
        {
            int count = 0;
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine(num +  "is a Prime Number");
            else
                Console.WriteLine( num + "is not a prime number");

        }
    }
}
