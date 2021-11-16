using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Conditional_Statements
{
    class conditional_statements
    {
        public static void Question1()
        {
            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.WriteLine("Question 1 : Write a C# Sharp program to accept two integers and check whether they are equal or not.");
            int num1, num2;
            Console.WriteLine("Please enter your first favourite number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second favourite number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Your favourite numbers are the same!");
            }
            else
            {
                Console.WriteLine("Your favourite numbers are not the same");
            }
            Console.ReadLine();
        }

        public static void Question2()
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("Question 2 : Write a C# Sharp program to check whether a given number is even or odd.");
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            //if a number is dividable by 2 and leaves no remainder,it is an even number , else it's an odd number
            //if (num)
            //{

            //}
            Console.ReadLine();
        }

        public static void Question3()
        {
            // Write a C# Sharp program to check whether a given number is positive or negative

            Console.WriteLine("Question 3 : Write a C# Sharp program to check whether a given number is positive or negative.");
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Your number is a positive integer");
            }
            else
            {
                Console.WriteLine("Your number is a negative integer");
            }
            Console.ReadLine();
        }

        public static void Question4()
        {
            //Write a C# Sharp program to find whether a given year is a leap year or not.
        }

        public static void Question5()
        {
            //Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
            Console.WriteLine("Question 5 : Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.");
            int age;
            Console.WriteLine("Enter your favourite age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are eligible to vote in South Africa!");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote in South Africa!");
            }
            Console.ReadLine();
        }

        public static void Question6()
        {
            // Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
            Console.WriteLine("Question 6 : Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, and -1 when m is less than 0.");
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Your number is a positive integer therefore your n is 1");
            }
            else
            {
                Console.WriteLine("Your number is a negative integer therefore your n is -1");
            }
            Console.ReadLine();
        }

        public static void Question7()
        {
            //Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
            double height;
            Console.WriteLine("Question 7 : Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height in centimetres.");
            height = Convert.ToDouble(Console.ReadLine());
            if (height <= 200)
            {
                Console.WriteLine("You are short");
            }
            else if (height < 500)
            {
                Console.WriteLine("You are okay");
            }

            else
            {
                Console.WriteLine("Damn you are tall");
            }
            Console.ReadLine();
        }

        public static void Question8()
        {
            //Write a C# Sharp program to find the largest of three numbers
            int num1, num2, num3;
            Console.WriteLine("Question 3 : Write a C# Sharp program to find the largest of three numbers.");
            Console.WriteLine("Enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Your first number is greater thanyour other numbers");
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Your second number is greater your other numbers");
                }
            }

            else
            {
                Console.WriteLine("Your third number is greater than your other numbers");
            }
        }

        public static void Question9()
        {
            // Write a C# Sharp program to find the largest of three numbers
            int num1, num2, num3;
            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + "is greater than the other numbers");
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is greater than the other numbers");
                }
            }

            else
            {
                Console.WriteLine(num3 + " is greater than the other numbers");
            }

            Console.ReadLine();
        }

        public static void Question10()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            double x;
            double y;

            Console.WriteLine("Please enter your x coordinate");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your y coordinate");
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Your coordinate is in the second quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Your coordinate is in the first quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Your coordinate is in the third quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Your coordinate is in the fourth quadrant");
            }

            Console.ReadLine();
        }

        public static void Question11()
        {
            //Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
        }

        public static void Question12()
        {
            //Write a C# Sharp program to calculate root of Quadratic Equation.
        }

        public static void Question13()
        {
            //Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        }

        public static void Question14()
        {
            //Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below :
        }

        public static void Question15()
        {
            //Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        }
    }

    }
}
