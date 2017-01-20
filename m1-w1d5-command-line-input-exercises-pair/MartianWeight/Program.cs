using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianWeight
{
    class Program
    {
        /*
        In case you've ever pondered how much you weight on Mars, here's the calculation:
 	    Wm = We* 0.378
 	    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

        Write a command line program which accepts a series of Earth weights from the user  
        and displays each Earth weight as itself, and its Martian equivalent.


        C:\Users> MartianWeight  
        Enter a series of Earth weights (space-separated): 98 235 185
            
        98 lbs.on Earth, is 37 lbs.on Mars.
        235 lbs.on Earth, is 88 lbs.on Mars.
        185 lbs.on Earth, is 69 lbs.on Mars. 
        */
        //check the string to check for letters.
        //take a string of Earth weights and turn into string array.
        //convert to double. do math. 
        static void Main(string[] args)
        {
            
            string earthWeights = "";
            Console.WriteLine("Enter a series of Earth Weights (space-separated): ");
            earthWeights = Console.ReadLine();

            //double earthWeightDouble = 0;
            //bool isNumeric = Double.TryParse(earthWeights, out earthWeightDouble);
            
            //give an error if the the amount of bill is not in numeric form
            //while (!isNumeric)
            //{
            //    Console.WriteLine("Please enter only numeric numbers followed by a single space: ");
            //    earthWeights = Console.ReadLine();
            //    isNumeric = Double.TryParse(earthWeights, out earthWeightDouble);
            //    Console.WriteLine();
            //}

            string[] earthWeightsArray = earthWeights.Split(' ');
            double[] martianWeightArray = new double[earthWeightsArray.Length];
            for (int i = 0; i<earthWeightsArray.Length;i++)
            {
                martianWeightArray[i] = double.Parse(earthWeightsArray[i]) * 0.378;
            }
            for (int x=0; x<martianWeightArray.Length; x++)
            {

                //  earthWeightsArray[x] *= 0.378;
                Console.WriteLine(earthWeightsArray[x] + "lbs.on Earth, is " + martianWeightArray[x] + "lbs on Mars.");
            }
        }
    }
}
