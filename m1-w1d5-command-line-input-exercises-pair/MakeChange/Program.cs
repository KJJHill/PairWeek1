using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.
 
        C:\Users> MakeChange
         
        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */


        static void Main(string[] args)
        {
            Decimal amountOfBillDecimal = 0M;
            Decimal amountTenderedDecimal = 0M;
            char[] separators = { '.' };


            Console.WriteLine("Please enter the amount of the bill: ");
            string amountOfBill = Console.ReadLine();
            bool isBillNumeric = Decimal.TryParse(amountOfBill, out amountOfBillDecimal);


            // give an error if the the amount of bill is not in numeric form
            while (!isBillNumeric)
            {
                Console.WriteLine("Please enter only numeric numbers: ");
                amountOfBill = Console.ReadLine();
                isBillNumeric = Decimal.TryParse(amountOfBill, out amountOfBillDecimal);
                Console.WriteLine();
            }

            //if the user inputted a decimal check to make sure there are only 2 decimal places.
            string[] numberParts = amountOfBill.Split(separators);

            if (numberParts.Length > 1)
            {
                while (numberParts[1].Length > 2)
                {
                    Console.WriteLine("You have entered too many digits after the decimal.  Please re-enter");
                    amountOfBill = Console.ReadLine();
                    numberParts = amountOfBill.Split(separators);
                    Console.WriteLine();
                }
            }


            Console.WriteLine("Please enter the amount tendered: ");
            string amountTendered = Console.ReadLine();
            bool isTenderedNumeric = Decimal.TryParse(amountTendered, out amountTenderedDecimal);

            // give an error if the the amount tendered is not in numeric form
            while (!isTenderedNumeric)
            {
                Console.WriteLine("Please enter only numeric numbers: ");
                amountTendered = Console.ReadLine();
                isTenderedNumeric = Decimal.TryParse(amountTendered, out amountTenderedDecimal);
            }

            //if the user inputted a decimal check to make sure there are only 2 decimal places.
            string[] numberTenderedParts = amountTendered.Split(separators);

            if (numberTenderedParts.Length > 1)
            {

                while (numberTenderedParts[1].Length > 2)
                {
                    Console.WriteLine("You have entered too many digits after the decimal.  Please re-enter");
                    amountTendered = Console.ReadLine();
                    numberTenderedParts = amountTendered.Split(separators);
                    Console.WriteLine();
                }
            }

            if ((amountTenderedDecimal - amountOfBillDecimal) > 0)
            {
                Console.WriteLine("The change required is: $" + (amountTenderedDecimal - amountOfBillDecimal));
            } 
            else
            {
                Console.WriteLine("You still owe $" + (amountOfBillDecimal - amountTenderedDecimal));
            }


        }

    }
}

