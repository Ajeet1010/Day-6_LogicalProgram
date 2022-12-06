using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Logical
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the no to choose perform: \n 1) Fibonacci Series \n 2) Perfect no \n" +
                "Enter the no to operate: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Fiboncci fiboncci = new Fiboncci();
                        fiboncci.Series();
                        break;
                    case 2:
                        Perfectno perfectno = new Perfectno();
                        perfectno.No();
                        break;
                }

            }
            

        }
    }
}