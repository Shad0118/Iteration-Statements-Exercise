namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an alphabet between (A to H) to execute the following options : ");
            Console.WriteLine(" A. To print numbers between 1000 to -1000\n B. To print numbers between 3 to 999 with increment of 3\n C. To know the equality between two numbers\n D. To find out if a number is even or odd\n E. To find out if a number is positive or negetive\n F. To find out if you are eligible for vote or not\n G. To find out if your number is ranged between 10 to -10\n H. To know the multiplication table of 1 to 12 ");
            string order = Console.ReadLine().ToUpper();
            switch (order)
            {
            
                case "C" :
                //
                Console.WriteLine("Enter two numbers to find out if they are Equal or not :");
                Console.WriteLine("1st number : ");
                double numOne = double.Parse(Console.ReadLine());
                Console.WriteLine("2nd number : ");
                double numTwo = double.Parse(Console.ReadLine());
                EqualNumbers(numOne, numTwo);
                break;
                
                case "D" :
                //
                Console.WriteLine("Enter a number to find out if it's Odd or Even : ");
                int givenNum = int.Parse(Console.ReadLine());
                OddEven(givenNum);
                break;
                
                case "E" :
                //
                Console.WriteLine("Enter a number  to find out if its positive or negetive");
                int numThree = int.Parse(Console.ReadLine());
                PositiveNegetive(numThree);
                break;
                
                case "F" :
                //
                Console.WriteLine("Please enter your age to find out your eligibility for Votting : ");
                int numFour = int.Parse(Console.ReadLine());
                LegalVoteAge(numFour);
                break;
                
                case "G" :
                //
                Console.WriteLine("Enter a number to see if  it's in the range between 10 to -10");
                int numFive = int.Parse(Console.ReadLine());
                NumberMatch(numFive);
                break;
                
                case "H" :
                //
                Console.WriteLine("Enter a number between 1 to 12 to see the Multiplication Table");
                int numSix = int.Parse(Console.ReadLine());
                MultiTable(numSix);
                break;
                
                //
                case "A" :
                Console.WriteLine("Numbers between 1000 and -1000 are : ");
                PositiveToNegetive();
                break;
                //
                case "B" :
                Console.WriteLine("Numbers between 3 and 999 are : ");
                IncrementByThree();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public static void PositiveToNegetive()
        {
            for (int i = 1000; i >= -1000; i--)
            {
               Console.WriteLine(i);
            }
        }

        public static void IncrementByThree()
        {
            for (int i = 3; i <= 999; i +=3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualNumbers(double a, double b)
        {
            if (a == b)
            {
                Console.WriteLine("These numbers are equal\n");
            }
            else
            {
                Console.WriteLine("These numbers are not equal\n");
            }
        }

        public static void OddEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("It's an even number\n");
            }
            else
            {
                Console.WriteLine("It's an odd number\n");
            }
        }

        public static void PositiveNegetive(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("It's a Positive number");
            }
            else if (a < 0)
            {
                Console.WriteLine("It's a Negative number");
            }
            else
            {
                Console.WriteLine("THE NUMBER IS 0");
            }
        }

        public static void LegalVoteAge(int a)
        {
            if (a >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else if (a < 18)
            {
                int diff = 18 - a;
                Console.WriteLine($"You are not old enough to vote try again after {diff} years !");
            }
        }

        public static void NumberMatch(int a)
        {
            List<int> collector = new List<int>();
            for (int i = 10; i >= -10; i--)
            {
                collector.Add(i);
            }

            if (collector.Contains(a))
            {
                Console.WriteLine("It's a Match");
            }
            else
            {
                Console.WriteLine("It's not a Match");
            }
        }

        public static void MultiTable(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = a * i;
                Console.WriteLine($"{a} X {i} = {result}");
            }
        }
    }
}
