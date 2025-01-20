//using Colorful;

using Centvrio.Emoji;
using Newtonsoft.Json.Linq;
using Spectre.Console;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace PastasCSharpNotesAndExamples
{
    public class PracticeCode
    {
        public static void numeric_C_Sharp()
        {


            int x = 10;
            int y = 20;
            int z = 30;

            // could do something like:
            // int x, y, z;
            // or
            // int x = 10, y = 20, z = 30;

            int age = 23;
            Helper.writeLine($"{age}", Colors.salmonOrange);  // will display what age equals


            Helper.writeLine($"{int.MaxValue}", Colors.goldenYellow);  // will display the max range of the defined var
                                                                       // or int, i.e: 2147483647

            //Colorful.Console.ForegroundColor = Colors.brightRed;
            Helper.writeLine($"{int.MinValue}", Colors.forestGreen);  // will display the max range of the defined var
                                                                      // or int, i.e: -2147483648
            Colorful.Console.ForegroundColor = Colors.numberColor;

            long bigNumber = -90000000L;
            Console.WriteLine(bigNumber);
            System.Console.WriteLine("\n\n");


            Console.WriteLine($"the max value of a long is: \t {long.MaxValue}");
            Console.WriteLine($"the minimum value of a long is: \t {long.MinValue}");

            System.Console.WriteLine("\n\n");
            /////

            double negative = -55.2D;
            Console.WriteLine(negative);

            Console.WriteLine($"the max value of a double is: \t\t{double.MaxValue}");
            Console.WriteLine($"the minimum value of a double is: \t{double.MinValue}");
            System.Console.WriteLine("\n\n");
            /////


            float precision = 5.000001F;
            Console.WriteLine($"the max value of a float is: \t\t{float.MaxValue}");
            Console.WriteLine($"the minimum value of a float is: \t{double.MinValue}");
            System.Console.WriteLine("\n\n");
            /////

            decimal money = 14.99M;
            Console.WriteLine($"the max value of a decimal is: \t\t{decimal.MaxValue}");
            Console.WriteLine($"the minimum value of a decimal is: \t{decimal.MinValue}");
            System.Console.WriteLine("\n\n");
            /////






            Colorful.Console.ReadLine();
        }

        public static void textBasedDataTypes()
        {
            string name = "Aba";  //Strings use double quotations, or "
            char letter = 'A';    // chars use single quotations, or '



            Console.ReadLine();
        }


        public static void convertingStringToNumbers()
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Helper.writeLine($"{age}", Colors.salmonOrange);  // will display what age equals


            Helper.writeLine($"{int.MaxValue}", Colors.goldenYellow);  // will display the max range of the defined var
                                                                       // or int, i.e: 2147483647

            //Colorful.Console.ForegroundColor = Colors.brightRed;
            Helper.writeLine($"{int.MinValue}", Colors.forestGreen);  // will display the max range of the defined var
                                                                      // or int, i.e: -2147483648
            Colorful.Console.ForegroundColor = Colors.numberColor;


            string textBigNumer = "900000000";
            long bigNumer = Convert.ToInt64(textBigNumer);
            long bigNumber = -90000000L;
            Console.WriteLine(bigNumber);
            System.Console.WriteLine("\n\n");


            Console.WriteLine($"the max value of a long is: \t {long.MaxValue}");
            Console.WriteLine($"the minimum value of a long is: \t {long.MinValue}");

            System.Console.WriteLine("\n\n");
            /////


            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);


            //double negative = -55.2D;
            Console.WriteLine(negative);

            Console.WriteLine($"the max value of a double is: \t\t{double.MaxValue}");
            Console.WriteLine($"the minimum value of a double is: \t{double.MinValue}");
            System.Console.WriteLine("\n\n");
            /////

            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            //float precision = 5.000001F;
            Console.WriteLine($"the max value of a float is: \t\t{float.MaxValue}");
            Console.WriteLine($"the minimum value of a float is: \t{double.MinValue}");
            System.Console.WriteLine("\n\n");
            /////


            string textDouble = "14.99";
            double doubleDouble = Convert.ToDouble(textDouble);
            decimal money = 14.99M;
            Console.WriteLine($"the max value of a decimal is: \t\t{decimal.MaxValue}");
            Console.WriteLine($"the minimum value of a decimal is: \t{decimal.MinValue}");
            System.Console.WriteLine("\n\n");
            /////

            Console.ReadLine();

        }

        public static void booleanDataTypes()
        {

            bool value = true;
            Console.Write(value);

            bool isMale = true;
            Console.WriteLine(isMale);

            Console.ReadLine();
        }

        public static void operators()
        {
            double age = 23;
            age++;   //incriments by 1 when using ++
            age = age + 10;  //can choose how much you incriment by
            age += 10;  //similar to above line


            age -= 10;  //would  equal 13
            age *= 10;  // would equal 230
            age /= 10;  //would equal 2 because it isnt a decimal var, i.e: float, double and would use 2

            age /= 10; //would equal 2.3 because youre using a decimal var now

            string name = "Aba";
            name += " is programing";   //would work or combine both strings
            Console.WriteLine(age);  //will result 24


            age--; //incriments down by 1 when using --
            Console.WriteLine(age);  //will result 23

            int i = 0;
            Console.WriteLine(i++);  //would execute or write what i is, but wouldnt add 1 to it
            //  it would store the new value when you write i out again, this would equal 0
            // if just running this single writeLine

            Console.WriteLine(++i);  //this would add to i, before printing it, which the output will be 1
            // i.e: please do action first, and then show what (i) is




            Console.ReadLine();
        }


        public static void remainder()
        {
            int firstNum = 12;
            int secondNum = 3;

            //10 / 3 = 3r(remainder of)1
            //3 x 3 = 9, 1 left over to get to 10 

            //Console.WriteLine(firstNum / secondNum);  //would output 3
            //Console.WriteLine(firstNum % secondNum);  //would output 3.333
            /* if you did 10 % 2, it would equal 0, because the outcome is even
             * if you did 11 % 2, it would equal 1, because 
            */

            Console.WriteLine(1000 % 90);  //output = 10
            Console.WriteLine(100 % 90);   // Output = 10
            Console.WriteLine(71 % 10);     // output = 1
            Console.WriteLine(300 % 8);     // output = 4


            int result1 = 35 % 6;
            Console.WriteLine("35 % 6 = " + result1); // Outcome: 5 because 6 * 5 = 30 and 35 - 30 = 5

            // Calculate and print the result of 58 % 7
            int result2 = 58 % 7;
            Console.WriteLine("58 % 7 = " + result2); // Outcome: 2 because 7 * 8 = 56 and 58 - 56 = 2

            // Calculate and print the result of 81 % 9
            int result3 = 81 % 9;
            Console.WriteLine("81 % 9 = " + result3); // Outcome: 0 because 9 * 9 = 81 and 81 - 81 = 0

            // Calculate and print the result of 123 % 11
            int result4 = 123 % 11;
            Console.WriteLine("123 % 11 = " + result4); // Outcome: 2 because 11 * 11 = 121 and 123 - 121 = 2

            // Calculate and print the result of 49 % 8
            int result5 = 49 % 8;
            Console.WriteLine("49 % 8 = " + result5); // Outcome: 1 because 8 * 6 = 48 and 49 - 48 = 1

            // Calculate and print the result of 77 % 5
            int result6 = 77 % 5;
            Console.WriteLine("77 % 5 = " + result6); // Outcome: 2 because 5 * 15 = 75 and 77 - 75 = 2

            // Calculate and print the result of 64 % 4
            int result7 = 64 % 4;
            Console.WriteLine("64 % 4 = " + result7); // Outcome: 0 because 4 * 16 = 64 and 64 - 64 = 0

            // Calculate and print the result of 90 % 13
            int result8 = 90 % 13;
            Console.WriteLine("90 % 13 = " + result8); // Outcome: 9 because 13 * 6 = 78 and 90 - 78 = 12

            // Calculate and print the result of 102 % 15
            int result9 = 102 % 15;
            Console.WriteLine("102 % 15 = " + result9); // Outcome: 12 because 15 * 6 = 90 and 102 - 90 = 12

            // Calculate and print the result of 67 % 6
            int result10 = 67 % 6;
            Console.WriteLine("67 % 6 = " + result10); // Outcome: 1 because 6 * 11 = 66 and 67 - 66 = 1


            Console.ReadLine();
        }


        public static void varKeyword()
        {
            char L = 'L'; // this is for a long
            char F = 'F'; // this is for a float
            char M = 'M'; // this is for a decimal
            var example = "var can take any form of variable, by placing var in the beginning and initizing what it equals" +
                "which it will then automatically pick up what type of var it is" +
                "i.e:" +
                "var yes = true" +
                "it will detect that it is a boolean type variable, being bool equals either true or false";

            var bigNumber = 90000;
            var example2 = $"if say you intended on bigNumber in being a Long int variable, or defined as int64, you would need to use {L} at the end" +
                $"which then it would convert from an int32, to now being classified as a Long/int64";
            // can take

            var name = "Abba";
            var letter = 'a';



            Colorful.Console.ReadLine();

        }


        public static void constKeyword()
        {
            //int vat = 20;

            //vat = 10;  // this now sets vat at 10

            const int vat = 20;  //this sets the var at a predetermined value and cannot be changed anywhere within the code after its initialized
            const double percentVAT = vat / 100D;
            //  if i tried to do vat = 10, it would error out because youre trying to define vat as something else after you set a const to vat beforehand

            int balance = 1000;
            Console.WriteLine(balance * (vat / 100D)); // = 200
            Console.WriteLine(balance * percentVAT);   // = 200

            const string version = "v1.0";

            Console.ReadLine();
        }


        /// <summary>
        /// this exersiz
        /// </summary>
        public static void storing_User_Data_Exercise()
        {
            /*
             * Objectives:
             *1:     Define a variable to hold your name
             *2:     Define a variable to hold your phone number
             *3:     Define a Variable to hold your age
             *4:     Print variables line-by-line to the screen
             * 
             * Bonus:   Extra: define variables using the var keyword
             */

            string name = "Aba";
            long number = 0123456789;   // 0s dont show in the beginning, but can show usually in the middle or end of a number
            //alternatively you can do 
            string number1 = "0123456789";  // the correct outcome would show 0123456789
            int age = 31;



            /*
             * alternatively you can do
             * 
             * var name = "Aba";
             * 
             * var number = 0123456789;
             * or
             * var number1 = "0123456789L"; 
             * to show the 0s in the beginning of numbers
             * 
             * var age = 31;
             * 
             */

            Console.WriteLine(name);
            Console.WriteLine(number1);
            Console.WriteLine(age);




            Console.ReadLine();

        }

        public static void storing_User_Data_Exercise_2()
        {
            /*
          * Objectives:
          *1:     Create a C# program that declares variables of different numeric data types.
          *2:     Assign values to these variables and print them to the console. 
          *3:      Use at least three different numeric data types (e.g., int, double, decimal).
          * 
          */

            int age = 31;
            int population = 55000;
            short hoursPlayed = 10000;
            byte hoursPerDay = 24;
            long worldPopulation = 8000000000L;
            double decimalNumber = 12.34D;
            float velocity = 5f;
            decimal YTDEarnings = 32154.232134234523M;

            Console.WriteLine(age);
            Console.WriteLine(population);
            Console.WriteLine(hoursPlayed);
            Console.WriteLine(hoursPerDay);
            Console.WriteLine(worldPopulation);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(velocity);
            Console.WriteLine(YTDEarnings);
            Console.WriteLine(decimalNumber + age);

            Console.ReadLine();

        }

        public static void storing_User_Data_Exercise_3()
        {
            /*
             * Exercise 2: Text-Based Data Types
             *
             * Objectives:
             * 1. Create a C# program that declares variables of text-based data types (string and char).
             * 2. Assign values to these variables and print them to the console.
             * 3. Concatenate two strings and print the result.
             */

            string firstName = "Eddie";
            string lastName = "Smith"; // Add a last name for concatenation
            char middleInitial = 'J';

            Console.WriteLine($"Hello, my first name is: {firstName}, " +
                              $"and my middle name starts with the initial: {middleInitial}");

            // Concatenate first name and last name
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

            Console.ReadLine();
        }


        public static void storing_User_Data_Exercise_4()
        {

            // Exercise 3: Working with Boolean Logic
            // Objective: Check the relationship between two integers and display the results using boolean expressions.

            // Steps:
            // 1. Declare two integer variables and assign them values.
            // 2. Use boolean expressions to check:
            //    - If the first number is greater than the second.
            //    - If the first number is less than the second.
            //    - If the two numbers are equal.
            // 3. Display the appropriate messages based on the results.


            int var1 = 30, var2 = 10, var3 = 20, var4 = 40, var5 = 100, var6 = 100;



            string message;
            message = (var1 >= var2) ? "var1 is greater than var2\n\n" : "var1 is less than var2\n\n\n\n";
            Colorful.Console.ForegroundColor = Colors.goldenYellow;

            Console.WriteLine("this first comparrison is looking between var1 and var2." +
        "var1 = 30, " +
        "var2 = 10");
            Colorful.Console.ForegroundColor = Colors.peach;
            Console.WriteLine(message);

            Colorful.Console.ForegroundColor = Colors.salmonOrange;

            Console.WriteLine("this 1st else statement  comparrison is looking between var1 and var2." +
                "var1 = 30, " +
                "var2 = 10");
            if (var1 >= var2)
            {
                Colorful.Console.ForegroundColor = Colors.goldenYellow;

                Console.WriteLine("var1 is greater than var2\n");
            }
            else if (var1 <= var2)
            {
                Colorful.Console.ForegroundColor = Colors.goldenYellow;

                Console.WriteLine("var1 is greater than var2\n");
            }
            else
            {
                Colorful.Console.ForegroundColor = Colors.goldenYellow;

                Console.WriteLine("both equal the same thing\n");
            }


            Colorful.Console.ForegroundColor = Colors.lightTeal;

            Console.WriteLine("this 2nd else statement  comparrison is looking between var3 and var4." +
    "var3 = 20, " +
    "var4 = 40");


            if (var3 >= var4)
            {
                Colorful.Console.ForegroundColor = Colors.lightPurple;

                Console.WriteLine("var3  is greater than var4\n");
            }
            else if (var3 <= var4)
            {
                Colorful.Console.ForegroundColor = Colors.lightPurple;

                Console.WriteLine("var3 is less than var4\n");
            }
            else
            {
                Colorful.Console.ForegroundColor = Colors.lightPurple;

                Console.WriteLine("var3 equal the same thing\n");
            }


            Colorful.Console.ForegroundColor = Colors.peach;

            Console.WriteLine("this 3rd else statement  comparrison is looking between var3 and var4." +
    "var3 = 100, " +
    "var4 = 100");



            if (var5 >= var6)
            {
                Colorful.Console.ForegroundColor = Colors.forestGreen;

                Console.WriteLine("var5 is greater than var6\n");
            }
            else if (var5 <= var6)
            {
                Colorful.Console.ForegroundColor = Colors.forestGreen;

                Console.WriteLine("var5 is greater than var6\n");
            }
            else
            {
                Colorful.Console.ForegroundColor = Colors.forestGreen;

                Console.WriteLine("both equal the same thing\n");
            }
            Console.ReadLine();
        }



        public static void storing_User_Data_Exercise_5()
        {
            // Exercise: Basic Operations and Data Type Manipulation
            // Objective: Create a program that involves numeric, text, and boolean data types.
            // You will also use operators and the var and const keywords.

            // Tasks:

            // Declare Constants:

            // Create two constant integers with arbitrary values.
            // Use var:

            // Declare a variable using var to store the result of an arithmetic operation involving the constants.
            // User Input and Conversion:

            // Prompt the user to enter a number as a string.
            // Convert the string input to a numeric type.
            // Boolean Comparison:

            // Compare the user input number with one of the constants.
            // Display whether the input is greater than, less than, or equal to the constant.
            // Remainder Operator:

            // Determine if the user's number is odd or even using the remainder operator.
            // Output the result.
            // Remember to use Console.WriteLine to display messages to the user and Console.ReadLine to capture input.
            const int age1 = 20;
            const int age2 = 40;

            // Use var for an arithmetic operation
            var ageResults = age1 + age2;
            Console.WriteLine("Sum of age1 and age2: " + ageResults);

            // Use var for additional variables
            var age3 = 5;
            var age4 = 8;

            // Boolean comparison between age3 and age4
            if (age3 > age4)
            {
                Console.WriteLine("age3 is greater than age4");
            }
            else if (age3 < age4)
            {
                Console.WriteLine("age3 is less than age4");
            }
            else
            {
                Console.WriteLine("age3 is equal to age4");
            }



            // Determine if age3 is odd or even
            if (age3 % 2 == 0)
            {
                Console.WriteLine("age3 is even.");
            }
            else
            {
                Console.WriteLine("age3 is odd.");
            }

            // Determine if age4 is odd or even

            if (age4 % 2 == 0)
            {
                Console.WriteLine("age3 is even.");
            }
            else
            {
                Console.WriteLine("age3 is odd.");
            }


            // Wait for user input to close the console
            Console.ReadLine();
        }

        public static void odd_Even_Checker_Exercise_1()
        {
            /*
             * Create & initialize two ints
             * Make a variable to work out the remainder
             * Output remainder to the screen
             * Change the first int variable to another number
             *   and recalculate the remainder
             *   output new remainder to the screen
             */



            int test1 = 100;
            var test2 = 6;

            Helper.write("test 1 equals: ", Colors.goldenYellow);
            Helper.write($"{test1}\n", Colors.numberColor);
            Helper.write("test 2 equals: ", Colors.goldenYellow);
            Helper.write($"{test2}\n", Colors.numberColor);



            int results = test1 % test2;

            // results = 4 for now
            // test 1 = 100
            // test 2 = 6
            //Console.WriteLine(results);

            Console.WriteLine($"The remainder of {test1} and {test2} is: {results}\n");
            if (results == 0)
            {
                Console.WriteLine("which results is even.\n");
            }
            else
            {
                Console.WriteLine("which results is not even.\n");
            }


            Console.WriteLine("\n\n");
            Console.WriteLine("test");
            test1 = results + test2;    // 4 + 6 = 10
            test2 = results + test1;    // 4 + 10 = 14
            results = test2 % test1;    // 14 % 10
                                        // sould be 4
            Console.WriteLine(results);
            Console.WriteLine("test");

            // test 1 is results, which is results, or 4
            // and its 4 plus test2, which is 6, so thats 10
            /*
             * test 1 is now 10
             * 
             * test2 now is results, which is 4,
             * and its 4 plus test1, whhich is 10
             * 
             * test 2 is 14
             * 
             * results is test1, finding the remainding amount of 2
             * which that is 4
            */

            Console.Write("now lets change up what ");
            Helper.write($"test1 ", Colors.goldenYellow);
            Helper.write("and ", Colors.numberColor);
            Helper.write($"results ", Colors.goldenYellow);
            Helper.write("equal\n\n", Colors.numberColor);

            Helper.WriteLine("Test1 now equals the remainder of results and test2, ", Colors.goldenYellow);
            Helper.WriteLine("and find the remainder of both Test1 and Test2 again with the new value.\n\n\n", Colors.goldenYellow);
            Helper.write("test1 now equals: ", Colors.peach);
            System.Console.WriteLine("\n");
            Helper.write($"{test1}\n\n", Colors.numberColor);
            Helper.write("test2 ", Colors.goldenYellow);
            Helper.write("now equals: \n\n", Colors.numberColor);
            Helper.write($"{test2}\n\n", Colors.goldenYellow);
            System.Console.WriteLine("\n\n");

            Helper.WriteLine($"The remainder of {test1} and {test2} is: {results}\n", Colors.numberColor);
            if (results == 0)
            {
                Helper.WriteLine("which results is even.\n", Colors.peach);
            }
            else
            {
                Helper.WriteLine("which results is not even.\n", Colors.brightRed);
            }


            Console.ReadLine();

        }



        public static void console_Input_output()
        {

            Console.WriteLine("hello, my name is aba");

            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("what is your age? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);


            //   Console.WriteLine(name);

            Console.WriteLine("what is your age? ");
            //  Console.WriteLine(age);
            string world = "world!";
            Console.WriteLine($"hello {name}, Nice to meet you. you are {age} years old");
            Console.WriteLine($"hello {world}");
            Console.ReadLine();

        }

        public static void if_statements()
        {

            //Console.WriteLine("hello, my name is aba");

            //Console.WriteLine("enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("what is your age? ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);
            ////Console.WriteLine($"hello {name}, Nice to meet you. you are {age} years old");



            ////if (age >= 18)
            ////{
            ////    Console.WriteLine("you are 18 or over");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("you are younger than 17");
            ////}


            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("invalid age");
            //}
            //else
            //{

            //}


            //string world = "world!";
            // Console.WriteLine($"hello {world}");
            //Console.ReadLine();

        }

        public static void multiplication_example()
        {
            /*
                * Objective: This method prompts the user to input two integers,
                * then calculates and displays the product of these two numbers.
                * 
                * Steps:
                * 1. Prompt the user to enter the first number and read the input.
                * 2. Convert the first input from a string to an integer.
                * 3. Prompt the user to enter the second number and read the input.
                * 4. Convert the second input from a string to an integer.
                * 5. Multiply the two integers to find the product.
                * 6. Display the result in a formatted message.
            */



            Console.Write("Enter the first number:\n ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the Second number:\n ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int numberResults = numberA * numberB;

            Console.WriteLine($"{numberA} times {numberB} equals {numberResults}");
        }


        public static void calculator_exercise_1()
        {
            /*
                 * Exercise: Simple Calculator
                 *
                 * Objective: Create a simple calculator that can perform basic arithmetic operations 
                 * (addition, subtraction, multiplication, and division) based on user input.
                 *
                 * Requirements:
                 * 1. Prompt the user to enter two numbers.
                 * 2. Ask the user to choose an operation: addition (+), subtraction (-), multiplication (*), or division (/).
                 * 3. Perform the chosen operation using if statements to determine which arithmetic operation to apply.
                 * 4. Display the result of the operation.
                 * 5. Handle division by zero by displaying an appropriate message if the user tries to divide by zero.
                 *
                 * Steps to Implement:
                 * 1. Read the first number from the user.
                 * 2. Read the second number from the user.
                 * 3. Prompt the user to enter an arithmetic operator.
                 * 4. Use if statements to check which operation to perform based on the operator entered.
                 * 5. Calculate and output the result.
                 * 6. Include error handling for division by zero.
            */
            Console.WriteLine("Enter the first number:");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number:");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            char operationChar;
            bool validInput = false;
            bool inputsEntered = false;
            // Loop until a valid operation is entered
            do
            {
                if (!inputsEntered  && !validInput)
             
                    Console.WriteLine("Choose which operation you wish to do: +, -, *, /");
                inputsEntered = true;
                ConsoleKeyInfo operationKey = Console.ReadKey();
                Console.WriteLine(); // Move to the next line after key press
                inputsEntered = true;
                operationChar = operationKey.KeyChar;

                if (operationChar == '+' || operationChar == '-' || operationChar == '*' || operationChar == '/')
                {
                    validInput = true;
                }
                else 
                {
                    Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
                }
            } 
            while (!validInput);

            // Perform the operation based on the valid key pressed
            if (operationChar == '+')
            {
                Console.WriteLine($"Result: {numberA} + {numberB} = {numberA + numberB}");
            }
            else if (operationChar == '-')
            {
                Console.WriteLine($"Result: {numberA} - {numberB} = {numberA - numberB}");
            }
            else if (operationChar == '*')
            {
                Console.WriteLine($"Result: {numberA} * {numberB} = {numberA * numberB}");
            }
            else if (operationChar == '/')
            {
                if (numberB != 0)
                {
                    Console.WriteLine($"Result: {numberA} / {numberB} = {(double)numberA / numberB}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            Console.ReadLine();
        }
}



}

    
