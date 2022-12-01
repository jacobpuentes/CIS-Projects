// Program 4
// CIS 199-XX
// Due: 4/20/2020
// By: Andrew L. Wright (Students use Grading ID)

// File: Program.cs
// This file creates a simple test application class that creates
// an array of GroundPackage objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    public class Program
    {
        // Precondition:  None
        // Postcondition: The packages have been printed to the console
        public static void DisplayPackages(GroundPackage[] packages)
        {
            foreach (GroundPackage package in packages)
            {
                WriteLine($"{package}"); // Implicit call to .ToString()
                WriteLine($"Cost: {package.CalcCost():C}");
                WriteLine("----------"); // Separator
            }
        }

        // Precondition:  None
        // Postcondition: The GroundPackage class has been tested
        public static void Main(string[] args)
        {
            // Test data - Magic #s are OK here
            GroundPackage p1 = new GroundPackage(40208, 00123, 12.5, 9.0, 4.0, 3.7);    // 1st GroundPackage
            GroundPackage p2 = new GroundPackage(91653, 47130, 10.0, 7.5, 5.1, 2.2);    // 2nd GroundPackage
            GroundPackage p3 = new GroundPackage(12345, 54321, 15.0, 15.0, 5.0, 7.5);   // 3rd GroundPackage
            GroundPackage p4 = new GroundPackage(91234, 43210, 36.0, 24.0, 12.0, 17.2); // 4th GroundPackage
            GroundPackage p5 = new GroundPackage(00321, 90214, 4.5, 6.5, 2.5, 1.5);     // 5th GroundPackage
            GroundPackage p6 = new GroundPackage(-1, -1, -1, -1, -1, -1);               // 6th GroundPackage to test validation

            GroundPackage[] thePackages = { p1, p2, p3, p4, p5, p6 }; // Array of test GroundPackages

            WriteLine("Original Packages:");
            DisplayPackages(thePackages);

            // Make some changes
            p1.Length = 5.5;
            p2.OriginZip = 33128;
            p3.Width = 10.0;
            p4.Height = 15.1;
            p5.Weight = 2.3;
            p6.DestinationZip = 30314;

            WriteLine("After Changes:");
            DisplayPackages(thePackages);
        }
    }
}
