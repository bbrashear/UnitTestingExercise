using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add(int num1, int num2, int num3)
        {
           return num1 + num2 + num3;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers

        public object Divide(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"Division of {num1} by zero");
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        public int OnePlusOne(int one1, int one2)
        {
            return one1 + one1;
        }

        public int TwoTimesTwo(int two1, int two2)
        {
            return two1 * two2;
        }
        
    }
}
