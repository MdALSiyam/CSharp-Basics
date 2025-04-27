using System;

namespace MyProject
{
    internal class Program
    {
        public static int count = 0;

        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            // --> Uncomment any method you want to test <-- \\

            // DecisionAndIteration();
            // ShortCircuit();
            // WorkWithMethod();
            // VariableDataTypeArithmeticOperator();
            // HandleExceptions();
            // CheckAndUncheck();
            // OverLoading();
            // ExpressionBodiedMethod();
            // ReturnWithoutTuple();
        }

        private static void ReturnWithoutTuple()
        {
            var obj = Math(100, 10);
            Console.WriteLine($"Summation of a & b is {obj.Item1}");
            Console.WriteLine($"Multiplication of a & b is {obj.Item2}");
        }

        private static (int, int) Math(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }

        private static void ExpressionBodiedMethod()
        {
            int result = DivideNumber(20, 10);
            Console.WriteLine(result);
        }

        private static int DivideNumber(int m, int n) => m / n;

        private static void OverLoading()
        {
            AddNumbers();
            AddNumbers(10, 20);
            AddNumbers(100.50, 50.30, 25.20);
            AddNumbers("Abdul", "Latif");
        }

        private static void AddNumbers(string fName, string lName)
        {
            string result = fName + " " + lName;
            Console.WriteLine(result);
        }

        private static int AddNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }

        private static double AddNumbers(double num1, double num2, double num3)
        {
            double result = num1 + num2 + num3;
            Console.WriteLine(result);
            return result;
        }

        private static void AddNumbers()
        {
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        private static void CheckAndUncheck()
        {
            int x = int.MaxValue;
            checked
            {
                Console.WriteLine($"Checked value: {x}");
            }

            int y = int.MaxValue;
            unchecked
            {
                Console.WriteLine($"Unchecked value: {y}");
            }
        }

        private static void HandleExceptions()
        {
            try
            {
                int x = 100;
                int y = 0;
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException dx)
            {
                Console.WriteLine($"Divide By Zero Error: {dx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This is final block");
            }
        }

        private static void VariableDataTypeArithmeticOperator()
        {
            int a = 10;
            int b = 5;
            int result;

            result = a + b;
            Console.WriteLine($"Summation is {result}");

            result = a - b;
            Console.WriteLine($"Subtraction is {result}");

            result = a * b;
            Console.WriteLine($"Multiplication is {result}");

            result = a / b;
            Console.WriteLine($"Division is {result}");

            result = a % b;
            Console.WriteLine($"Remainder is {result}");

            Console.WriteLine("Increment and Decrement:");
            int x = 1;
            Console.WriteLine($"Post Increment: {x++}");
            Console.WriteLine($"Pre Increment: {++x}");

            int y = 10;
            Console.WriteLine($"Post Decrement: {y--}");
            Console.WriteLine($"Pre Decrement: {--y}");
        }

        private static void WorkWithMethod()
        {
            // Positional Parameter
            AddNumber(15, 14);

            // Named Parameter
            AddNumber(x: 15, y: 14);

            // Optional Parameter
            AddNumber();

            // Class Scope
            Console.WriteLine($"Count = {count}");
            count++;
        }

        private static void AddNumber(int x = 15, int y = 14)
        {
            int result = x + y;
            Console.WriteLine($"Sum is {result}");
        }

        private static void ShortCircuit()
        {
            Console.WriteLine("Enter your mark:");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark <= 100 && mark >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

        private static void DecisionAndIteration()
        {
            Console.WriteLine("Decision Statements");

            // If Statement
            int age = 18;
            if (age == 18)
            {
                Console.WriteLine("You can vote");
            }

            // If-else Statement
            int mark = 60;
            if (mark >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // If-ElseIf-Else Statement
            int mark1 = 75;
            if (mark1 >= 60 && mark1 <= 69)
            {
                Console.WriteLine("Grade B");
            }
            else if (mark1 >= 70 && mark1 <= 79)
            {
                Console.WriteLine("Grade A");
            }
            else if (mark1 >= 80 && mark1 <= 100)
            {
                Console.WriteLine("Grade A+");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            // Switch Statement
            Console.WriteLine("Enter Number \nGender: 1 = Male & 2 = Female");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Male");
                    break;
                case 2:
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Iteration Statements");

            // While Statement
            int start = 1;
            int end = 10;
            Console.WriteLine("Enter Timetable number:");
            int timetable = Convert.ToInt32(Console.ReadLine());
            while (start <= end)
            {
                int result = timetable * start;
                Console.WriteLine("{0} * {1} = {2}", timetable, start, result);
                start++;
            }

            // Do-While Statement
            int start1 = 1;
            int end1 = 10;
            Console.WriteLine("Enter another Timetable number:");
            int timetable1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                int result1 = timetable1 * start1;
                Console.WriteLine("{0} * {1} = {2}", timetable1, start1, result1);
                start1++;
            }
            while (start1 <= end1);

            // For Loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Foreach Loop
            int[] numbers = { 10, 20, 30 };
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
