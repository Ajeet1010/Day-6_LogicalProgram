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
                Console.WriteLine("Enter the no to choose perform: \n 1) Fibonacci Series \n 2) Perfect no \n 3) Prime no \n 4) Reverse no\n " +
                    "5) Coupon chk" +
                    
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
                    case 3:
                        Primeno primeno= new Primeno();
                        primeno.Prime();
                        break;
                    case 4:
                        Reverse reverse = new Reverse();
                        reverse.no();
                        break;
                    case 5:
                        Coupon coupon = new Coupon();
                        coupon.Num();
                        break;


                }

            }
            

        }
    }
}