﻿using System;

namespace TiengMathFormulaRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1A - C# Mathmatical Formual Revision
            //Basic Difficulty
            CircumAreaVol();

            //Intermediate Difficulty
            TriangleArea();

            //Advanced Difficulty: Quadratic Equation
            //Ask for user input for variables
            Console.Write("Type in the value for 'a': ");
            float aValue = float.Parse(Console.ReadLine());
            Console.Write("Type in the value for 'b': ");
            float bValue = float.Parse(Console.ReadLine());
            Console.Write("Type in the value for 'c': ");
            float cValue = float.Parse(Console.ReadLine());

            QuadraticEquation(aValue, bValue, cValue);
        }
        private static void CircumAreaVol()
        {
            //Basic Difficulty: Circumference, Area, and Volume equations
            //My program asks the user for a valid radius value to use as part of the formulas and returns the respective calculations
            Console.Write("Please type in a valid integer for the radius: ");
            double userRadius = Convert.ToInt32(Console.ReadLine()); //Recieved METHOD assistance from w3schools.com on how to convert string input to integer
            Console.WriteLine($"With a radius of {userRadius}, here are some important values: ");

            double circumferenceValue = (2 * Math.PI * userRadius);
            Console.WriteLine("The Circumference of the circle is: " + circumferenceValue + " units");

            double areaValue = (2 * Math.PI * Math.Pow(userRadius, 2));//Recieved METHOD assistance from geeksforgreeks.org (Exponent Method Syntax)
            Console.WriteLine("The area of the circle is: " + areaValue + " units");

            double volumeHemisphere = ((4 / 3) * Math.PI * Math.Pow(userRadius, 3)) / 2;
            Console.WriteLine("The Volume of a Hemisphere is: " + volumeHemisphere + " units");
            Console.ReadLine();
        }
        private static void TriangleArea()
        {
            //Intermediate Difficulty: Area of a triangle utilizing Heron's Formula
            //Ask User for length values for Heron's formula
            Console.Write("What is the length of side one of the triangle: ");
            int length1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the length of side two of the triangle: ");
            int length2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the length of side three of the triangle: ");
            int length3 = Convert.ToInt32(Console.ReadLine());

            //Calculate the P-Value that can be used as a variable later in the code block
            int heronsPValue = (length1 + length2 + length3)/2;
            Console.WriteLine("Heron's P-Value is: " + heronsPValue + " units");

            //Simplify the variables in the parenthesis to use later in code block
            int parenthesis1 = (heronsPValue - length1);
            int parenthesis2 = (heronsPValue - length2);
            int parenthesis3 = (heronsPValue - length3);

            //Combine values to use Square Root function in accordance with C# syntax
            int radicandValue = (heronsPValue * parenthesis1 * parenthesis2 * parenthesis3);

            double heronsArea = Math.Sqrt(radicandValue);
            Console.WriteLine("The area of the triangle using Heron's formula is: " + heronsArea + " units");
            Console.ReadLine();
            //used https://www.mathsisfun.com/geometry/herons-formula.html to check if the calculations result with the correct answer
        }
        public static void QuadraticEquation(float aValue, float bValue, float cValue)
        {
            double deltaRoot = Math.Sqrt(bValue * bValue - 4 * aValue * cValue);

            if (deltaRoot >= 0)
            {
                double x1 = (-bValue + deltaRoot) / 2 * aValue;
                double x2 = (-bValue + deltaRoot) / 2 * aValue;
                Console.WriteLine("The possible 'x' values are: x1= " + x1 + " and x2= " + x2);
            }
            else
            {
                Console.WriteLine("There are no roots");
            }
        }
    }
}
/* I did my work in this manner because I want to practice using methods. I had trouble understanding the functionality of using programmer-defined
 methods during my self-study on CodeAcademy's C# learning path. I recently started Bob Tabor's C# youtube curiculum and everything seemed to click.
I wanted to keep practicing using methods so I can perfect its usage. Furthermore, I used the code, and process outlined in website #6 below to create
a quadratic equation program.

Webites used:
1. https://www.w3schools.com/cs/cs_user_input.asp

2. https://www.geeksforgeeks.org/c-sharp-math-pow-method/

3. https://www.mathsisfun.com/geometry/herons-formula.html

4. https://www.geeksforgeeks.org/c-sharp-math-sqrt-method/

5. https://www.youtube.com/watch?v=SDe-1lGeS0U (used to  refamiliarize how to solve/simplify quadratic equations by factoring)

6. https://www.youtube.com/watch?v=IdLuuIqAAgM (I used the code provided in this video to create a quadratic equation program)

Assignment completed 031330JUL2020
 */
