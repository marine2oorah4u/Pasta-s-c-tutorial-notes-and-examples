//using Colorful;

using Spectre.Console;
using NAudio.Wave;

using System.Diagnostics;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace PastasCSharpNotesAndExamples
{
    public class PracticeCode
    {


        public static bool running = true; // Initialize running here

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
                if (!inputsEntered && !validInput)

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



        public static void numberGuessingGameExercise(Random random)


        {
            // Task: Guess the Number Game

            // Step 1: Generate a random number between 1 and 100
            // - Use the Random class to generate a random number and store it

            // Step 2: Create a loop that continues until the user guesses the correct number
            // - Use a boolean flag to control the loop

            // Step 3: Inside the loop, prompt the user to enter their guess
            // - Use Console.WriteLine to ask for a guess
            // - Read the user's input using Console.ReadLine and convert it to an integer

            // Step 4: Compare the user's guess with the random number using if statements
            // - If the guess is higher than the random number, inform the user that the guess is too high
            // - If the guess is lower than the random number, inform the user that the guess is too low
            // - If the guess is correct, congratulate the user and exit the loop

            // Step 5: End the program once the correct number is guessed





            int number = random.Next(1, 101); // Correct range is 1 to 100
            int score = 0;

            Console.WriteLine("Let's play a guessing game. Choose a number between 1 and 100.");

            bool correct = false;

            // Step 2: Create a loop that continues until the user guesses the correct number
            while (!correct)
            {
                // Step 3: Inside the loop, prompt the user to enter their guess
                Console.WriteLine("Enter your guess:");
                string input = Console.ReadLine();

                // Check if the input is empty
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You pressed Enter without typing anything.");
                    continue; // Skip the rest of the loop iteration
                }

                // Assume the input is invalid until proven otherwise
                bool isValidInput = false;
                int guess = 0;

                // Attempt to parse the input
                try
                {
                    guess = int.Parse(input);
                    isValidInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // If the input was valid, proceed with the game logic
                if (isValidInput)
                {
                    score++; // Increment the score for each valid guess

                    // Step 4: Compare the user's guess with the random number using if statements
                    if (guess < number)
                    {
                        Console.WriteLine("Your guess is too low!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Your guess is too high!");
                    }
                    else
                    {
                        // Step 5: End the program once the correct number is guessed
                        Console.WriteLine($"Congrats, you guessed the number right! It took you {score} tries.");
                        correct = true; // Exit the loop
                    }
                }
            }

            // Wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static List<string> userInputs = new List<string>();

        public static string? ReadLine { get; private set; }

        public static void toDo_List()
        {
            while (PracticeCode.running == true)
            {
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Check the list");
                Console.WriteLine("2. Add to the list");
                Console.WriteLine("3. Exit the Program");
                string userInput = Console.ReadLine();

                if (userInput.Equals("1", StringComparison.OrdinalIgnoreCase))
                {
                    PracticeCode.displayList();
                }
                else if (userInput.Equals("2", StringComparison.OrdinalIgnoreCase))
                {
                    addToList();
                }
                else if (userInput.Equals("3", StringComparison.OrdinalIgnoreCase))
                {
                    PracticeCode.running = false;
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose one of the options from up above");
                }
            }
        }

        public static void displayList()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t");
            for (int i = 0; i < userInputs.Count; i += 3)
            {
                Console.Write($"Task Name: ({userInputs[i]}) ");
                Console.Write($"Completion Date: ({userInputs[i + 1]}) ");
                Console.Write("Priotity: ");
                string priority = userInputs[i + 2];
                if (priority.Equals("High", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = Color.Red;
                }
                else if (priority.Equals("Medium", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = Color.Yellow;
                }
                else if (priority.Equals("Low", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = Color.Green;
                }

                Console.Write(priority);
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void addToList()
        {
            string input1, input2, input3;
            Console.Clear();
            Console.WriteLine("Enter three items to add to the list. Type 'exit' in the first field to finish.");

            while (true)
            {
                Console.WriteLine("What is the task name? ");
                input1 = Console.ReadLine();
                Console.Clear();

                if (string.IsNullOrEmpty(input1))
                {
                    Console.WriteLine("You pressed Enter without typing anything. Please try again.");
                    continue;
                }

                if (input1.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.WriteLine("When do you wish to complete this by? ");
                while (true)
                {
                    input2 = Console.ReadLine();
                    Console.Clear();

                    if (!string.IsNullOrEmpty(input2))
                    {
                        break;
                    }

                    Console.WriteLine("You pressed Enter without typing anything. Please try again.");
                }

                Console.WriteLine("What is its priority? High, Medium, or Low ");
                while (true)
                {
                    input3 = Console.ReadLine();
                    //Console.Clear();

                    if (string.IsNullOrEmpty(input3))
                    {
                        Console.WriteLine("You pressed Enter without typing anything. Please try again.");
                        continue;
                    }

                    if (input3.Equals("High", StringComparison.OrdinalIgnoreCase) ||
                        input3.Equals("Medium", StringComparison.OrdinalIgnoreCase) ||
                        input3.Equals("Low", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid priority. Please choose High, Medium, or Low.");
                    }


                }

                //input3 = Console.ReadLine();
                Console.Clear();


                Console.Write($"Items '{input1}', '{input2}', and ");

                if (input3.Equals("high", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (input3.Equals("Medium", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (input3.Equals("Low", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write(input3);
                Console.ResetColor();
                Console.WriteLine(" have been added to the list.\n\n");

                userInputs.Add(input1);
                userInputs.Add(input2);
                userInputs.Add(input3);

                Task.Delay(500);
                Console.WriteLine("Do you want to add another item to the list? (yes/no):");
                string continueInput = Console.ReadLine();

                while (true)
                {
                    if (string.IsNullOrEmpty(continueInput))
                    {
                        Console.WriteLine("You pressed Enter without typing anything. Please try again.");
                        continueInput = Console.ReadLine();
                    }
                    else if (continueInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        PracticeCode.running = true;
                        Console.Clear();
                        Task.Delay(500);
                        PracticeCode.addToList();
                        break;
                    }
                    else if (continueInput.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        Task.Delay(500);
                        PracticeCode.toDo_List();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input. Please choose yes or no.");
                        continueInput = Console.ReadLine();
                    }
                }
            }

        }


        public static void switch_statements()
        {
            Console.WriteLine("enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            //if (day == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("tuesday");
            //}
            //else
            //{
            //    Console.WriteLine("invald, please enter a value between 1-7");
            //}


            switch (day)
            {
                case 1:
                    Console.WriteLine("mon");
                    break;
                // can do say
                /// case:2
                /// case 3: {bla}
                /// and both 2 and 3 will equal the same
                /// vs doing both case 2 and case 3 the same thing
                case 2:

                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wed");
                    break;
                case 4:
                    Console.WriteLine("thurs");
                    break;
                case 5:
                    Console.WriteLine("fri");
                    break;
                case 6:
                    Console.WriteLine("sat");
                    break;
                case 7:
                    Console.WriteLine("sun");
                    break;
                default:
                    Console.WriteLine("invald, please enter a value between 1-7");
                    break;
            }

            Console.ReadLine();

        }

        public static void switches_Exercise_01()
        {


            // Task: Write a switch statement that takes an integer input representing a month
            //       (1 = January, 2 = February, ..., 12 = December) and outputs the corresponding month name.
            // Obj: Practice using switches with integer inputs and string outputs.

            Console.WriteLine("What month of the year is it?");
            Console.WriteLine("Please type the month name (e.g. January, February, etc.)");

            string month = Console.ReadLine();

            switch (month)
            {
                case "january": Console.WriteLine("It is currently January"); break;
                case "february": Console.WriteLine("It is currently February"); break;
                case "march": Console.WriteLine("It is currently March"); break;
                case "april": Console.WriteLine("It is currently April"); break;
                case "may": Console.WriteLine("It is currently May"); break;
                case "june": Console.WriteLine("It is currently June"); break;
                case "july": Console.WriteLine("It is currently July"); break;
                case "august": Console.WriteLine("It is currently August"); break;
                case "september": Console.WriteLine("It is currently September"); break;
                case "october": Console.WriteLine("It is currently October"); break;
                case "november": Console.WriteLine("It is currently November"); break;
                case "december": Console.WriteLine("It is currently December"); break;
                default: Console.WriteLine("Please enter a valid month name"); break;
            }

            Console.ReadLine();
        }


        public static void switches_Exercise_02()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a color to change the text to. Your options are either:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow,");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Green,");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Blue,");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cyan, ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Magenta, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("or ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gray.");

            string textColor = Console.ReadLine().ToLower();

            switch (textColor)
            {
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("the text is now Yellow");
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("the text is now Green");
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the text is now Blue");
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("the text is now Cyan");
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("the text is now Magenta");
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("the text is now White");
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("the text is now Gray");
                    break;
            }

            Console.ReadLine();
        }

        public static void switches_Exercise_03()
        {
            CanvasImage CreatePlanetImage(string filename)
            {
                var image = new CanvasImage(filename);
                image.MaxWidth = 30;
                return image;
            }
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "space.wav");
            var soundPlayer = new SoundPlayer(filePath);
            soundPlayer.Play();

            CanvasImage sun = CreatePlanetImage("sun.png");
            CanvasImage mercury = CreatePlanetImage("mercury.png");
            CanvasImage venus = CreatePlanetImage("venus.png");
            CanvasImage earth = CreatePlanetImage("earth.png");
            CanvasImage moon = CreatePlanetImage("moon.png");
            CanvasImage mars = CreatePlanetImage("mars.png");
            CanvasImage jupiter = CreatePlanetImage("jupiter.png");
            CanvasImage saturn = CreatePlanetImage("saturn.png");
            CanvasImage uranus = CreatePlanetImage("uranus.png");
            CanvasImage neptune = CreatePlanetImage("neptune.png");
            CanvasImage pluto = CreatePlanetImage("pluto.png");
            // Render the image to the console
            //AnsiConsole.Write(sun);
            //AnsiConsole.Write(mercury);
            //AnsiConsole.Write(venus);
            //AnsiConsole.Write(earth);
            //AnsiConsole.Write(moon);
            //AnsiConsole.Write(mars);
            //AnsiConsole.Write(jupiter);
            //AnsiConsole.Write(saturn);
            //AnsiConsole.Write(uranus);
            //AnsiConsole.Write(neptune);
            //AnsiConsole.Write(pluto);
            //AnsiConsole.MarkupLine("[bold blue on yellow blink underline]Warning![/] This is very [italic green on black strikethrough]important[/].");

            Color[] textColor = { Color.Red, Color.Yellow, Color.Green, Color.Maroon, Color.Olive, Color.Blue };
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("What Planet do you wish to look up today?\n");
                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                string[] planets2 = { "the sun", "mercury", "venus", "the earth", "the moon", "mars", "jupiter", "saturn", "uranus", "neptune" };
                Console.ResetColor(); // Reset the color back to default

                Console.WriteLine("choose between:");

                foreach (string planets in planets2)
                {
                    Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                    Console.WriteLine($"■ {planets}");
                    Console.ResetColor(); // Reset the color back to default
                }


                string planet = Console.ReadLine().ToLower();

                switch (planet)
                {
                    case "sun":
                    case "the sun":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(1000);
                            AnsiConsole.Write(sun);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The Sun![/][/].\n\n");



                            string[] sunFacts = {
    "The Sun is the center of our solar system and the primary source of light and heat for our planets.",
    "The Sun's surface temperature is about 5,500 degrees Celsius (10,000 degrees Fahrenheit).",
    "The Sun is a massive ball of hot, glowing gas and makes up about 99.8% of the mass of our solar system.",
    "The Sun is about 109 times bigger than the Earth.",
    "The Sun's core is incredibly hot, with temperatures reaching over 15,000,000 degrees Celsius (27,000,000 degrees Fahrenheit).",
    "The Sun's energy is produced by nuclear reactions that occur in its core.",
    "The Sun's light takes about 8 minutes and 20 seconds to reach the Earth.",
    "The Sun's surface is covered in convective cells that help to distribute heat around the star.",
    "The Sun's magnetic field is incredibly strong and plays a crucial role in shaping the solar system.",
    "The Sun is about 4.6 billion years old and has already burned through about half of its fuel.",
    "The Sun will eventually exhaust its fuel and expand into a red giant, engulfing the inner planets.",
    "The Sun's corona is much hotter than its surface, with temperatures reaching over 1,000,000 degrees Celsius (1,800,000 degrees Fahrenheit).",
    "The Sun's solar flares can release enormous amounts of energy and affect the Earth's magnetic field.",
    "The Sun's sunspots are cooler regions on the surface that can affect the Earth's climate.",
    "The Sun's rotation is not uniform and can vary depending on the latitude."
};


                            foreach (string sunFact in sunFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {sunFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);
                            }

                        }
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();

                        break; // E




                    case "mercury":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(1000);
                            AnsiConsole.Write(mercury);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet Mercury![/][/].");

                            string[] mercuryFacts = {
    "Mercury is the smallest planet in our solar system, with a diameter of only about 4,879 kilometers.",
    "Mercury is the closest planet to the Sun, with an average distance of about 58 million kilometers.",
    "Mercury has no atmosphere, which means there's no air, no wind, and no weather on the planet.",
    "Mercury's surface temperature can range from -173 degrees Celsius (-279 degrees Fahrenheit) at night to 427 degrees Celsius (801 degrees Fahrenheit) during the day.",
    "Mercury's orbit is highly eccentric, which means its distance from the Sun varies throughout the year.",
    "Mercury's rotation is tidally locked, which means it always shows the same face to the Sun.",
    "Mercury's surface is heavily cratered, indicating a geologically inactive surface.",
    "Mercury's magnetic field is very weak, which means it offers little protection from the Sun's radiation.",
    "Mercury's interior is composed of a large iron core surrounded by a mantle of rock.",
    "Mercury's surface is composed of a variety of rock types, including basalts and anorthosites.",
    "Mercury's geology is characterized by numerous fault lines and ridges.",
    "Mercury's surface has many similarities to the Moon's surface.",
    "Mercury's orbit is slowly increasing in size due to the tidal interactions with the Sun.",
    "Mercury's rotation is slowing down over time due to the tidal interactions with the Sun."
};

                            foreach (string mercuryFact in mercuryFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {mercuryFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);

                            }
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }

                    case "venus":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(venus);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet venus![/][/].");

                            string[] venusFacts = {
    "Venus is often called Earth's 'sister planet' because of their similar size and mass.",
    "Venus has a thick atmosphere that traps heat, making it the hottest planet in the solar system with surface temperatures reaching up to 462 degrees Celsius (863 degrees Fahrenheit).",
    "Venus rotates very slowly, with its day lasting 243 Earth days, but it also rotates in the opposite direction of its orbit around the Sun.",
    "Venus has no moons, making it one of the few planets in the solar system without a natural satellite.",
    "Venus's atmosphere is composed mostly of carbon dioxide, with clouds of sulfuric acid and droplets of sulfuric acid.",
    "Venus's surface is hidden by thick clouds of sulfuric acid and droplets of sulfuric acid.",
    "Venus's surface temperature is hot enough to melt lead.",
    "Venus's atmosphere is crushing, with pressures reaching up to 92 times that of the Earth's atmosphere.",
    "Venus's surface is relatively young, with few craters and a geologically active surface.",
    "Venus's interior is composed of a solid iron core surrounded by a mantle of rock.",
    "Venus's surface is composed of numerous volcanoes and lava flows.",
    "Venus's geology is characterized by numerous fault lines and ridges.",
    "Venus's surface has many similarities to the Earth's surface, with features such as mountains and valleys."
};
                            foreach (string venusFact in venusFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {venusFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);

                            }


                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "the earth":
                    case "earth":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(earth);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet earth![/][/].");

                            string[] earthFacts = {
    "Earth is the only known planet in the universe with liquid water, which is essential for life.",
    "Earth's atmosphere is made up of 78% nitrogen, 21% oxygen, and 1% other gases, which is perfect for supporting life.",
    "Earth's rotation is slowing down over time, which is why we have to add an extra second to our clocks every few years to keep them in sync with the planet's rotation.",
    "Earth has a unique tilt in its axis, which is why we have seasons and why the planet's climate varies so much from one region to another.",
    "Earth's magnetic field is incredibly strong and plays a crucial role in protecting the planet from the Sun's radiation.",
    "Earth's interior is composed of a solid iron core surrounded by a mantle of rock.",
    "Earth's surface is composed of 71% water, with the remaining 29% consisting of continents and islands.",
    "Earth's atmosphere is home to a diverse range of weather patterns, including hurricanes, tornadoes, and blizzards.",
    "Earth's geology is characterized by numerous fault lines and ridges, with features such as mountains and valleys.",
    "Earth's surface is home to a diverse range of ecosystems, including forests, deserts, and oceans.",
    "Earth's climate is constantly changing, with factors such as volcanic eruptions and human activities contributing to global warming.",
    "Earth's rotation is not uniform and can vary depending on the latitude.",
    "Earth's orbit is not a perfect circle and can vary slightly over time."
};

                            foreach (string earthFact in earthFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {earthFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }


                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "moon":
                    case "the moon":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(1000);
                            AnsiConsole.Write(moon);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The moon![/][/].\n\n");

                            string[] moonFacts = {
    "The Moon is Earth's only natural satellite and is the fifth-largest moon in the solar system.",
    "The Moon is thought to have formed about 4.5 billion years ago when a massive object collided with Earth, causing debris to be thrown into orbit and eventually coalesce into the Moon.",
    "The Moon's surface is covered with craters, which were formed by asteroid and comet impacts over billions of years.",
    "The Moon has no atmosphere, which means there's no air, no wind, and no weather on the Moon.",
    "The Moon's surface temperature can range from -173 degrees Celsius (-279 degrees Fahrenheit) at night to 127 degrees Celsius (261 degrees Fahrenheit) during the day.",
    "The Moon's orbit is slowly increasing in size due to the tidal interactions with the Earth.",
    "The Moon's rotation is tidally locked, which means it always shows the same face to the Earth.",
    "The Moon's surface is composed of a variety of rock types, including basalts and anorthosites.",
    "The Moon's geology is characterized by numerous fault lines and ridges.",
    "The Moon's surface has many similarities to the Earth's surface, with features such as mountains and valleys.",
    "The Moon's interior is composed of a solid iron core surrounded by a mantle of rock.",
    "The Moon's surface is home to a diverse range of geological features, including craters, mountains, and lava flows."
};

                            foreach (string moonFact in moonFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {moonFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "mars":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(mars);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet mars![/][/].");


                            string[] marsFacts = {
    "Mars is often called the 'Red Planet' because of its reddish appearance, which is caused by iron oxide in the planet's soil.",
    "Mars has the tallest volcano in our solar system, Olympus Mons, which stands at a height of over 27 kilometers (17 miles).",
    "Mars has polar ice caps, which suggest that the planet may have had liquid water on its surface in the past.",
    "Mars has the longest valley in our solar system, Valles Marineris, which stretches over 4,000 kilometers (2,500 miles) in length.",
    "Mars's atmosphere is very thin, with pressures reaching only about 1% of the Earth's atmosphere.",
    "Mars's surface temperature can range from -125 degrees Celsius (-193 degrees Fahrenheit) at night to 20 degrees Celsius (68 degrees Fahrenheit) during the day.",
    "Mars's geology is characterized by numerous fault lines and ridges, with features such as mountains and valleys.",
    "Mars's surface is home to a diverse range of geological features, including craters, volcanoes, and canyons.",
    "Mars's interior is composed of a solid iron core surrounded by a mantle of rock.",
    "Mars's surface is thought to have been shaped by water in the past, with features such as riverbeds and lakebeds.",
    "Mars's atmosphere is mostly carbon dioxide, with some nitrogen and argon.",
    "Mars's rotation is very similar to the Earth's, with a day lasting 24.6 hours."
};

                            foreach (string marsFact in marsFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {marsFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "jupiter":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(jupiter);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet jupiter![/][/].");

                            string[] jupiterFacts = {
    "Jupiter is the largest planet in our solar system, with a diameter of over 142,984 kilometers (88,846 miles).",
    "Jupiter is a gas giant, meaning that it's primarily composed of hydrogen and helium gases.",
    "Jupiter's Great Red Spot is a giant storm that has been raging forover 350 years and is larger than Earth.",
    "Jupiter has at least 79 known moons, with the four largest being Ganymede, Callisto, Io, and Europa, known as the Galilean moons.",
    "Jupiter's atmosphere is characterized by bands of clouds, which are caused by high-speed winds and the planet's rapid rotation.",
    "Jupiter has a very strong magnetic field, which is about 20,000 times stronger than Earth's magnetic field.",
    "Jupiter's interior is believed to consist of a solid core surrounded by a layer of metallic hydrogen and an outer layer of gaseous hydrogen and helium.",
    "Jupiter has a rotation period of about 10 hours, making it the fastest rotating planet in the solar system.",
    "Jupiter emits more heat than it receives from the Sun due to the slow gravitational compression of its massive interior.",
    "Jupiter's ring system is faint and composed mostly of dust particles, making it difficult to observe.",
    "Jupiter has a very high number of storms, with some regions of its atmosphere experiencing wind speeds of up to 600 kilometers per hour (370 miles per hour).",
    "Jupiter's atmosphere contains various compounds, including ammonia, methane, and water vapor.",
    "Jupiter's large size and mass allow it to exert a strong gravitational pull, which helps protect the inner planets from potential asteroid impacts.",
    "Jupiter's cloud tops are extremely cold, with temperatures reaching -145 degrees Celsius (-234 degrees Fahrenheit)."
};

                            foreach (string jupiterFact in jupiterFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {jupiterFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "saturn":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(saturn);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet saturn![/][/].");

                            string[] saturnFacts = {
    "Saturn is the second-largest planet in our solar system, with a diameter of about 120,536 kilometers (74,898 miles).",
    "Saturn is best known for its stunning ring system, which is composed of ice and rock particles ranging in size from tiny grains to large boulders.",
    "Saturn is a gas giant, primarily composed of hydrogen and helium, with a small rocky core.",
    "Saturn has at least 83 known moons, with Titan being the largest and the second-largest moon in the solar system.",
    "Saturn's rings are made up of several distinct rings and gaps, with the main rings being A, B, and C rings.",
    "Saturn's atmosphere has a banded structure similar to Jupiter's, with storms and high-speed winds.",
    "Saturn rotates very quickly, with a rotation period of about 10.7 hours.",
    "Saturn has a very low density, even lower than water, which means it could theoretically float in a large enough body of water.",
    "Saturn's magnetic field is about 580 times stronger than Earth's magnetic field.",
    "Saturn's winds can reach speeds of up to 1,800 kilometers per hour (1,100 miles per hour) in the upper atmosphere.",
    "Saturn's interior is believed to have a core made of rock and metal, surrounded by a layer of liquid metallic hydrogen.",
    "Saturn's rings are constantly changing due to gravitational interactions with its moons.",
    "Saturn's moon Titan has a dense atmosphere and is the only moon in the solar system known to have stable bodies of liquid on its surface."
};
                            foreach (string saturnFact in saturnFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {saturnFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "uranus":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(uranus);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet uranus![/][/].");

                            string[] uranusFacts = {
    "Uranus is the seventh planet from the Sun and is classified as an ice giant due to its unique composition.",
    "Uranus has a diameter of about 50,724 kilometers (31,518 miles), making it the third-largest planet in the solar system.",
    "Uranus has a tilted axis of rotation, at about 98 degrees, which causes it to rotate on its side compared to other planets.",
    "Uranus has a faint ring system composed of 13 known rings made up of ice and rock particles.",
    "Uranus has 27 known moons, with the five largest being Miranda, Ariel, Umbriel, Titania, and Oberon.",
    "Uranus's atmosphere is primarily composed of hydrogen and helium, with a higher proportion of water, ammonia, and methane compared to Jupiter and Saturn.",
    "Uranus is the coldest planet in the solar system, with minimum temperatures dropping to -224 degrees Celsius (-371 degrees Fahrenheit).",
    "Uranus has a rotation period of about 17.2 hours.",
    "Uranus's magnetic field is tilted at an angle of 59 degrees from its rotational axis and is offset from the planet's center.",
    "Uranus has a relatively low density, which suggests that it is composed of a large amount of ices and gases.",
    "Uranus's atmosphere exhibits bands of clouds and storms, although they are less prominent than those on Jupiter and Saturn.",
    "Uranus is often referred to as the 'sideways planet' due to its extreme axial tilt.",
    "Uranus's moons show a variety of geological features, including canyons, craters, and ice formations."
};
                            foreach (string uranusFact in uranusFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {uranusFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }



                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "neptune":
                        {
                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(neptune);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet neptune![/][/].");

                            string[] neptuneFacts = {
    "Neptune is the eighth and farthest planet from the Sun in our solar system.",
    "Neptune has a diameter of about 49,244 kilometers (30,598 miles), making it slightly smaller than Uranus.",
    "Neptune has a deep blue color due to the presence of methane in its atmosphere, which absorbs red light.",
    "Neptune experiences some of the fastest winds in the solar system, with speeds reaching up to 2,100 kilometers per hour (1,300 miles per hour).",
    "Neptune has a faint ring system composed of ice and dust particles, along with six known rings.",
    "Neptune has 14 known moons, with Triton being the largest and the only large moon in the solar system that orbits in the opposite direction of its planet.",
    "Neptune's atmosphere is primarily composed of hydrogen, helium, and methane, with an active weather system that includes storms and high-speed winds.",
    "Neptune has a rotation period of about 16 hours and 6 minutes.",
    "Neptune has a strong magnetic field that is tilted relative to its rotational axis, similar to Uranus.",
    "Neptune was discovered in 1846 by Johann Galle and Heinrich d'Arrest based on mathematical predictions.",
    "Neptune's interior is thought to consist of a rocky core surrounded by water, ammonia, and methane ices.",
    "Neptune's distance from the Sun means that it receives very little sunlight, resulting in extremely cold temperatures.",
    "Neptune has a dynamic atmosphere with large storms, including the Great Dark Spot, which is similar in nature to Jupiter's Great Red Spot."
};

                            foreach (string neptuneFact in neptuneFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {neptuneFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                            Console.Clear();

                            break; // E
                        }
                    case "pluto":
                        {

                            Console.Clear();

                            Console.WriteLine("you chose: ");
                            Console.WriteLine("\n\n");
                            Thread.Sleep(500);
                            AnsiConsole.Write(pluto);
                            AnsiConsole.MarkupLine("[bold blue on yellow blink underline][italic green on black strikethrough]The planet pluto![/][/].");



                            string[] plutoFacts = {
    "Pluto is no longer considered a planet, but is now classified as a dwarf planet.",
    "Pluto is a small, icy world with a highly eccentric orbit that takes it as close as 29.7 astronomical units (AU) from the Sun and as far as 49.3 AU from the Sun.",
    "Pluto has a highly tilted axis, which means that the planet essentially spins on its side, resulting in extreme seasons on the planet.",
    "Pluto has a moon called Charon, which is about half the size of Pluto itself.",
    "Pluto was discovered in 1930 by Clyde Tombaugh and was initially considered to be the ninth planet in our solar system.",
    "Pluto's surface is composed primarily of nitrogen ice mixed with darker organic material.",
    "Pluto has a thin atmosphere, which freezes and thaws as it moves closer to and farther from the Sun.",
    "Pluto has a highly eccentric orbit, which takes it as close as 29.7 AU from the Sun and as far as 49.3 AU from the Sun.",
    "Pluto is part of a population of similar objects in the Kuiper Belt, a region of icy bodies beyond Neptune.",
    "Pluto's size is approximately 2,374 kilometers (1,475 miles) in diameter, making it much smaller than the other planets in our solar system.",
    "Pluto's surface features include mountains, valleys, and craters, which suggest a geologically active past.",
    "Pluto's moon Charon has a surface composed primarily of water ice mixed with darker organic material.",
    "Pluto's orbit overlaps with that of Neptune, and the two objects are in a 3:2 orbital resonance, meaning that Pluto orbits the Sun twice for every three orbits of Neptune.",
    "Pluto's discovery led to a reevaluation of the definition of a planet, ultimately resulting in its reclassification as a dwarf planet in 2006."
};
                            foreach (string plutoFact in plutoFacts)
                            {

                                Console.ForegroundColor = textColor[random.Next(textColor.Length)];
                                Console.WriteLine($"■ {plutoFact}");
                                Console.ResetColor(); // Reset the color back to default
                                Thread.Sleep(1000);


                            }




                        }
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();

                        break; // E

                    default:
                        Console.WriteLine("invalid chouce. Choose one of the planets from up above");
                        break;


                }




                //Console.ReadLine();
            }


        }
        public static void for_loops()
        {
            Console.WriteLine("What do you want to repeat?");
            string message = Console.ReadLine();

            Console.WriteLine("and how many times do you want to repeat it?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("sorry, please, enter a value above 0");
            }
            else
            {
                for (int i = 1; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }

            //Console.WriteLine("hi");



            Console.ReadLine();
        }



        public static void for_Loop_exercise_01()
        {
            // Task: Print a Countdown

            // Write a program that uses a for loop to print a countdown from 10 to 1.

            Console.WriteLine("lets count down from 10");

            for (int i = 10; i >= 1; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            Console.WriteLine("Blast off!"); // You could add this to make it feel more like a real countdown
            Console.ReadLine();

        }

        public static void for_Loop_exercise_02()
        {
            // Write a program that prints the following pattern to the console:
            // *
            // **
            // ***
            // ****
            // *****
            // Use a for loop to iterate over the rows of the pattern
            // Use another for loop (nested inside the first one) to iterate over the columns of the pattern
            // Print a * character for each column in the current row


            Console.WriteLine("lets mimic a loading bar");

            Console.Write("Now loading ");
            for (int i = 1; i <= 10; i++)
            {

                Console.Write("* ");
                Thread.Sleep(500);
            }
            Console.WriteLine("Done!");

        }

        public static void for_loop_exercise_03()
        {
            Random random = new Random();
            Helper.WriteLine("Lets have a horse race", Colors.lightPurple);
            Console.WriteLine("=======================");

            int horseSpeed = random.Next(0, 10);
            int horseSpeed2 = random.Next(0, 10);
            int horseSpeed3 = random.Next(0, 10);
            int horseSpeed4 = random.Next(0, 10);

            for (int timer = 10; timer <= 50; timer += 10)
            {
                Thread.Sleep(500);
                Console.WriteLine("\n");
                int horseIncrement = random.Next(1, 10);
                int horseIncrement2 = random.Next(1, 10);
                int horseIncrement3 = random.Next(1, 10);
                int horseIncrement4 = random.Next(1, 10);

                horseSpeed += horseIncrement;
                horseSpeed2 += horseIncrement2;
                horseSpeed3 += horseIncrement3;
                horseSpeed4 += horseIncrement4;

                Helper.writeLine($"Horse 1: {horseSpeed}", Colors.lightRed);
                Helper.writeLine($"Horse 2: {horseSpeed2}", Colors.lightYellow);
                Helper.writeLine($"Horse 3: {horseSpeed3}", Colors.forestGreen);
                Helper.WriteLine($"Horse 4: {horseSpeed4}", Colors.blueJayBlue);

                //Console.Clear();

                if (timer >= 50)
                {
                    if (horseSpeed > horseSpeed2 && horseSpeed > horseSpeed3 && horseSpeed > horseSpeed4)
                    {
                        Console.WriteLine("horse 1 is the winner");
                    }
                    else if (horseSpeed2 > horseSpeed && horseSpeed2 > horseSpeed3 && horseSpeed2 > horseSpeed4)
                    {
                        Console.WriteLine("horse 2 is the winner");
                    }
                    else if (horseSpeed3 > horseSpeed && horseSpeed3 > horseSpeed2 && horseSpeed3 > horseSpeed4)
                    {
                        Console.WriteLine("horse 3 is the winner");
                    }
                    else
                    {
                        Console.WriteLine("horse 4 is the winner");
                    }
                    break;
                }

            }
            Console.ReadLine();
        }


        public static void for_loop_exercise_04()
        {

            // Galaxy Invaders 

            // Create a program that simulates a space battle between a spaceship and a fleet of alien invaders. 
            // The spaceship has 100 health points and the alien invaders have 50 health points each. 
            // The spaceship can fire laser blasts that deal 20 damage to the alien invaders. 
            // The alien invaders can fire plasma blasts that deal 10 damage to the spaceship. 
            // The battle continues until either the spaceship or all the alien invaders are destroyed.

            // Task: // Write a C# program that simulates the space battle using a for loop. 
            // The program should ask the user for the number of alien invaders.
            // The program should then simulate the battle, printing out the health points of the spaceship and the alien invaders after each round.
            // If the spaceship is destroyed, print out "Game Over".
            // / If all the alien invaders are destroyed, print out "Victory!".

            Random random = new Random();

            int playerHealth = 100;
            int enemyhealth = 50;
            int playerDamage = 20;
            int enemyDamage = 10;
            bool running = true;

            int numberOfEnemies = 12;
            bool enemyHit = false;
            bool playerHit = false;

            int roundNumber = 0;
            int score = 0;
            int moreEnemies = 2;


            Console.WriteLine("lets play Galaxy invaders");

            Console.WriteLine("=========================");
            Thread.Sleep(1000);
            Console.WriteLine("prss any key to start");
            Console.ReadKey();



            Console.WriteLine(score);
            roundNumber = 1;
            playerHealth = 100;
            enemyhealth = 50;
            score = 0;


            for (int timer = 10; timer <= 50; timer += 1)
            {
                Thread.Sleep(500);
                int enemyAccuracy = random.Next(0, 5);
                int playerAccuracy = random.Next(0, 2);


                int randomHealthPickup = random.Next(0, 7);
                int randomEnemyChance = random.Next(1, numberOfEnemies);

                Console.WriteLine($"Enemy health: {enemyhealth}");
                Console.WriteLine($"player health:\n {playerHealth}");
                Thread.Sleep(400);

                if (enemyAccuracy >= 3)
                {
                    var filePath5 = Path.Combine(Directory.GetCurrentDirectory(), "oww.wav");
                    var soundPlayer5 = new SoundPlayer(filePath5);
                    soundPlayer5.Play();
                    playerHealth -= enemyDamage;
                    Helper.WriteLine("player Hit!\n", Colors.lightRed);
                    Colorful.Console.ForegroundColor = Colors.defaultColor;
                    Thread.Sleep(1000);
                }
                else { }



                if (playerAccuracy >= 1)
                {
                    enemyhealth -= playerDamage;

                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "LanderDie.wav");
                    var soundPlayer = new SoundPlayer(filePath);
                    soundPlayer.Play();
                    Helper.WriteLine("enemy Hit!\n", Colors.forestGreen);
                    Colorful.Console.ForegroundColor = Colors.defaultColor;
                    score += 10;
                    Thread.Sleep(1000);


                }
                else { }



                Console.ResetColor();
                int healthPickupChance = 0;

                if (playerHealth <= 80 && randomHealthPickup >= 5)
                {
                    healthPickupChance = random.Next(1, 40);
                    if (healthPickupChance <= 20)
                    {
                        playerHealth += 10;
                        Colorful.Console.ForegroundColor = Colors.forestGreen;
                        Console.WriteLine("Congrats, you picked up a health pickup!");
                        Console.WriteLine("Player health +10\n");
                        Colorful.Console.ForegroundColor = Colors.defaultColor;
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "powerUp.wav");
                        var soundPlayer = new SoundPlayer(filePath);
                        soundPlayer.Play();
                        Thread.Sleep(1000);


                    }



                }

                else
                {

                }


                if (playerHealth <= 0)
                {
                    var filePath4 = Path.Combine(Directory.GetCurrentDirectory(), "wahWah.wav");
                    var soundPlayer4 = new SoundPlayer(filePath4);
                    soundPlayer4.Play();
                    Console.WriteLine($"Game over! You reached round number {roundNumber}. Your total score is: {score}");
                    Colorful.Console.ForegroundColor = Colors.defaultColor;

                    running = false;
                    break;
                }
                if (enemyhealth <= 0)
                {
                    Colorful.Console.ForegroundColor = Colors.defaultColor;
                    var filePath1 = Path.Combine(Directory.GetCurrentDirectory(), "fanfare.wav");
                    var soundPlayer = new SoundPlayer(filePath1);
                    soundPlayer.Play();
                    Console.WriteLine($"Congratulations! You defeated the alien invader in round {roundNumber}. Your total score is: {score}");
                    score += 100;
                    enemyDamage = enemyDamage + 5;
                    enemyhealth = enemyhealth + 10;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    roundNumber++;
                    numberOfEnemies++;
                    enemyhealth = 50;
                    Thread.Sleep(1000);
                    Console.Clear();
                    var filePath3 = Path.Combine(Directory.GetCurrentDirectory(), "nextLevel.wav");
                    var soundPlayer3 = new SoundPlayer(filePath3);
                    soundPlayer3.Play();
                    Thread.Sleep(1000);

                }

                Thread.Sleep(400);
            }

            Console.ReadLine();
        }


        public static void while_loops()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Write("Enter the first number:\n ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the Second number:\n ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;



            Console.WriteLine($"value of {numberA} x {numberB}: ");



            //while (answer != actualAnswer)
            //{
            //    Console.WriteLine("enter your answer: \n");
            //    string answerInput = Console.ReadLine();
            //   actualAnswer = Convert.ToInt32(answerInput);


            //    if (answer != actualAnswer)
            //    {
            //        Console.WriteLine("Close, but it was wrong.\n");
            //    }
            //}
            do
            {
                Console.WriteLine("enter your answer: \n");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);


                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close, but it was wrong.\n");
                }
            } while (answer != actualAnswer);  //  will do code in do 1 time and re check the code in the do 

            //  code in while loop depends on condition to be true
            // do loop, 1st interation does not depend on anything, except 2nd, 3rd, 4th, etc


            Console.WriteLine("well done.");

            Console.ReadLine();
        }

        public static void while_loop_Exercise_01()
        {
            // Task: Print the numbers from 1 to 5 using a while loop.
            // Goal: Understand the basic syntax of a while loop and how to use it to repeat a task.
            // Constraints: Use a while loop and a counter variable to print the numbers.

            int number = 1;

            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
            }


            Console.ReadLine();

        }
        public static void while_loop_Exercise_02()
        {
            // Task: Ask the user for a number, and then print the numbers from 1 to that number using a while loop.
            // Goal: Understand how to use a while loop to repeat a task based on user input.
            // Constraints: Use a while loop and a counter variable to print the numbers.

            Console.WriteLine("Let's count some numbers.\nWhat do you want to count up from?\n\nChoose a number between 0-25");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0 || number > 25)
            {
                Console.WriteLine("Please pick a number between 0-25.");
                return;
            }

            int counter = 1;
            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.ReadLine();
        }



        public static void while_loop_Exercise_03()
        {
            // Task: Write a program that asks the user for a password and keeps asking until the correct password is entered.
            // Goal: Understand how to use a while loop to repeat a task until a certain condition is met.
            // Constraints: Use a while loop and a boolean variable to control the loop.
            bool correctUserInput = true;
            Helper.WriteLine("Choose an Option:\n", Colors.goldenYellow);

            Helper.write("1: ", Colors.numberColor);
            Helper.write("login\n", Colors.peach);
            Helper.write("2: ", Colors.numberColor);
            Helper.write("create account\n", Colors.peach);
            Colorful.Console.ForegroundColor = Colors.numberColor;

            int userChoice = Convert.ToInt32(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    logIn();
                    break;
                case 2:
                    createUsername();
                    break;
                default:
                    Helper.WriteLine("Please choose a valid option", Colors.lightRed);
                    Colorful.Console.ForegroundColor = Colors.numberColor;

                    correctUserInput = false;

                    break;

            }







            Console.ReadLine();

        }

        static void logIn()
        {
            while_loop_Exercise_03();
        }

        static void createUsername()
        {

            List<string> userName = new List<string>();
            {

            }

            List<string> password = new List<string>();
            {

            }


            Helper.write("Username:\t", Colors.goldenYellow);
            string userInput = Console.ReadLine();



            //if (userName.Contains(userInput))
            //{
            //    if (condition2)
            //    {
            //        // code to execute if both conditions are true
            //    }
            //    else
            //    {
            //        password.Add(userInput);
            //    }
            //}
            //else
            //{
            //    userName.Add(userInput);
            //}


            //        if (userName.Contains(userInput))
            //        {
            //            if (password.Contains(userInput))
            //            {
            //                Console.WriteLine("Error: Value already exists in the list.");
            //                {
            //                    Console.WriteLine("Error: Value already exists in the list.");
            //                }
            //            }


            //            userName.Add(userInput);
            //        }
            //        userName.Add(userInput);
            //    }
            //}
            Helper.write("Password:\t", Colors.goldenYellow);
            userInput = Console.ReadLine();

            if (userName.Contains(userInput))
            {
                Console.WriteLine("Error: Value already exists in the list.");
            }
            else
            {
                userName.Add(userInput);
            }
        }


        public static void nested_if_statements_exercise_01()
        {
            // Create a program that simulates a theme park ride
            // The ride has certain restrictions and requirements that must be met before a rider can board

            // Define variables
            string rideName = "The Rollercoaster of Regret";
            int riderHeight =52; // in inches
            int riderAge = 77; // in years
            bool hasHealthInsurance = true; // true or false

            // Requirements:
            // The rider must be at least 48 inches tall to ride
            // The rider must be at least 12 years old to ride
            // The rider must have health insurance to ride

            // Create a nested if statement that checks if the rider meets all the requirements
            // If they do, print a message saying "You can ride the rollercoaster!"
            // If they don't meet one or more of the requirements, print a message explaining why they can't ride

            // Your code goes here...

            if (rideName == "The Rollercoaster of Regret")
            {
                if (riderHeight >= 48)
                {
                    if (riderAge >= 12)
                    {
                        if (hasHealthInsurance == true) 
                        {
                            Console.WriteLine("You meet all requirements, please enjoy the ride");
                        }
                        else 
                        {
                            Console.WriteLine("PLEASE DONT DIE");
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry, you are too young to enter this ride");
                    }
                }
                else
                {
                    Console.WriteLine("sorry, you are too short to ride this");
                }
            }
            else
            {
                Console.WriteLine("this is the wrong ride. are you lost?");
            }
        
            Console.ReadLine();
        }

        public static void nested_if_statements_exercise_02()
        {
            // Create a program that simulates a university admission system
            // The program should check if a student is eligible for admission based on their GPA and test scores

            // Define variables
            double gpa = 3.5; // the student's GPA
            int mathScore = 80; // the student's math test score
            int englishScore = 20; // the student's English test score

            // Requirements:
            // The student must have a GPA of at least 3.0 to be eligible for admission
            // The student must have a math test score of at least 70 to be eligible for admission
            // The student must have an English test score of at least 80 to be eligible for admission
            // If the student meets all the requirements, display a message saying "You are eligible for admission"
            // If the student does not meet one or more of the requirements, display a message explaining why they are not eligible

            if (gpa < 3.0)
            {
                Console.WriteLine("Your GPA is too low for admission");
            }
            else if (mathScore < 70)
            {
                Console.WriteLine("Your math score is too low for admission");
            }
            else if (englishScore < 80)
            {
                Console.WriteLine("Your English score is too low for admission");
            }
            else
            {
                Console.WriteLine("You are eligible for admission");
            }

            Console.ReadLine();
        }

        public static void nested_if_statements_exercise_03()
        {
            // Create a program that determines the grade of a student based on their score
            // The program should ask the user to enter the student's score
            // The program should display the grade based on the following criteria:
            // 90-100: A
            // 80-89: B
            // 70-79: C
            // 60-69: D
            // Below 60: F
            // However, if the student is in their first year, the grading criteria is different:
            // 80-100: A
            // 70-79: B
            // 60-69: C
            // Below 60: F

            // Define variables
            int score; // the student's score
            int year; // the student's year

            // Requirements:
            // The program should ask the user to enter the student's score and year
            // The program should display the grade based on the criteria above
            // The program should use nested if statements to handle the different grading criteria

            // Your code goes here...



            Console.WriteLine("lets grade tests!\n");
            Thread.Sleep(1000);

            Console.WriteLine("what was the score of your test?");
            score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what grade level are you?. Are you year 1, or year 2?");
            year = Convert.ToInt32(Console.ReadLine());


            if (year == 1)
            {
                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("your grade is an A. Well Done");
                }
                else if (score >= 80 && score < 90)
                {
                    Console.WriteLine("your grade is a B");
                }
                else if (score >= 70 && score < 80)
                {
                    Console.WriteLine(" your grade is a C");
                }
                else if (score >= 60 && score < 70)
                {
                    Console.WriteLine("your grade is a D");
                }
                else
                {
                    Helper.writeLine("You failed the test!", Colors.lightRed);
                }
            }
            else if (year == 2)
            {
                if (score >= 80 && score <= 100)
                {
                    Console.WriteLine("your grade is an A. Well Done");
                }
                else if (score >= 70 && score < 80)
                {
                    Console.WriteLine("your grade is a B");
                }
                else if (score >= 60 && score < 70)
                {
                    Console.WriteLine(" your grade is a C");
                }
                else
                {
                    Helper.writeLine("You failed the test!", Colors.lightRed);
                }
            }
            else
            {
                Console.WriteLine("You are in the wrong classroom");
            }


            Console.ReadLine();
        }




        public static void nested_if_statements_exercise_04()
        {

            // Define some variables
            string favoriteCoffee = "";
            string preferredSize = "Large";
            string preferredFlavor = "Vanilla";


            // order of opperation
            /*
             *  1 2 3 = true
             *  if 3 is false
             *  1 2 correct, and 3b is checked
             */

            // Check if the coffee shop has the favorite coffee
            if (favoriteCoffee == "Latte")
            {
                // If they have latte, check if they have the preferred size
                if (preferredSize == "Large")
                {                                                                                                // this is the beginning check. if this fails, then the final else happens
                    // If they have large size, check if they have the preferred flavor             
                    if (preferredFlavor == "Caramel")
                    {
                        Console.WriteLine("Perfect! They have a large caramel latte.");                          // this checks to see if they have caramel, or this if statement is true or not
                                                                                                                 //it will check and execute everything in this if statement block if Large is true
                                                                                                                 // if theres a large, but no caramel, it will go the else for no flavor
                    }
                    else if (preferredFlavor == "Vanilla")
                    {
                        Console.WriteLine("They have a large vanilla latte.");                                          // if caramel is false but is still a large, it will check for vanilla
                    }
                    else
                    {
                        Console.WriteLine("Sorry, they don't have your preferred flavor.");                             // if large but none of the available flavors are there, then it will default to this
                    }
                }
                else if (preferredSize == "Medium")                                                                     // if its not a large, but is a medium, it will go to this code
                                                                                                                        // this block has no flavor checks, so it wont check for that statement
                {
                    Console.WriteLine("They have a medium latte.");                                                     //if medium is true, then it will say this...still ignoring flavor because flavor isnt a possible option
                }
                else
                {
                    Console.WriteLine("Sorry, they don't have your preferred size.");                                   // if the size isnt true, i.e: no large or medium, it will always default as a last resort to no size
                                                                                                                        // if no size or flavor available, but the very beginning condition is true, i.e: latte, it will still say
                                                                                                                        // they dont have your preferred size, but still true for coffee, being that is still true. flavor
                                                                                                                        // is not counted for at this point
                }
            }
            else
            {
                Console.WriteLine("Sorry, they don't have your favorite coffee.");                                      //  if the 1st check is false, i.e: type of coffee available, it will always default to this
                                                                                                                        // being this is the only coffee. even if the size and flavor are available, this will be default result
            }


            Console.ReadLine();
        }

        public static void nested_if_statements_exercise_05()
        {
            // Task 5: Nested If Statement Exercise
            // -------------------------------------
            // Write a C# program that prompts the user to input a year.
            // First, check if the year is a leap year.
            // A year is a leap year if:
            // - It is divisible by 4, but not divisible by 100, or
            // - It is divisible by 400.
            // If the year is a leap year, further check if the year is a century year (divisible by 100).
            // Print whether the year is a leap year, a century leap year, or a common year.



            Console.Write( "enter the current year:    ");
            int year = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine( "lets dive into this year some more....");
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.Write("Loading ");

            for (int i = 1; i < 10; i++)
            { 
                Console.Write(". ");
                Thread.Sleep(400);
            }

            Console.WriteLine("\n");


           String[] leapYearFacts = new String[]
                {
            "Some Fun Facts about Leap Years:",
            "1. A leap year has 366 days instead of the usual 365 days.",
            "2. Leap years occur every 4 years to help synchronize the calendar year with the Earth's orbit around the Sun.",
            "3. A year is a leap year if it is divisible by 4.",
            "4. However, if the year is divisible by 100, it is not a leap year, unless...",
            "5. The year is also divisible by 400, in which case it is a leap year.",
            "6. For example, the year 2000 was a leap year, while 1900 was not.",
            "7. Leap year adjustments prevent the calendar from drifting over time.",
            "8. February 29 is the additional day in a leap year, known as 'Leap Day'."
                };

            foreach (string fact in leapYearFacts)
            {
                foreach (char c in fact)
                    {
                        Console.Write(c);
                        Thread.Sleep(25); // Delays for 50 milliseconds to simulate typing
                    }
                
                Thread.Sleep(400);

                Console.WriteLine("");
                }

            Thread.Sleep(1000);

            Console.WriteLine("\n\n");

            Console.WriteLine( "Now lets take a look at your year you entered;");
            Thread.Sleep(1000);
            Console.WriteLine($"You entered {year}. Based off of the facts above: \n\n ");
            Thread.Sleep(1000);


            // Task 5: Nested If Statement Exercise
            // -------------------------------------
            // Write a C# program that prompts the user to input a year.
            // First, check if the year is a leap year.
            // A year is a leap year if:
            // - It is divisible by 4, but not divisible by 100, or
            // - It is divisible by 400.
            // If the year is a leap year, further check if the year is a century year (divisible by 100).
            // Print whether the year is a leap year, a century leap year, or a common year.

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            if (isLeapYear)
            {
                Helper.WriteLine($"{year} is in fact a leap year.\n", Colors.forestGreen);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "woo.wav");
                var soundPlayer = new SoundPlayer(filePath);
                soundPlayer.Play();
                Thread.Sleep(1000);


            }
            else
            {
                Helper.WriteLine($"{year} is in fact not a leap year.\n", Colors.brightRed);
                var filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "aww.wav");
                var soundPlayer2 = new SoundPlayer(filePath2);
                soundPlayer2.Play();
                Thread.Sleep(2500);
            }
            Thread.Sleep(1000);

            // Checking if it's a century year
            bool isCenturyYear = year % 100 == 0;
            if (isCenturyYear)
            {
                Helper.WriteLine($"{year} is a century year.\n", Colors.forestGreen);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "woo.wav");
                var soundPlayer = new SoundPlayer(filePath);
                soundPlayer.Play();
                Thread.Sleep(1000);
            }
            else
            {
                Helper.WriteLine($"{year} is not a century year.\n", Colors.brightRed);
                var filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "aww.wav");
                var soundPlayer2 = new SoundPlayer(filePath2);
                soundPlayer2.Play();
                Thread.Sleep(2500);
            }
            Thread.Sleep(1000);

            //  checking  for common year if it's not a leap year and not a century leap year
            bool isCommonYear = !isLeapYear;
            if (isCommonYear)
            {
                Helper.WriteLine($"{year} is a common year.\n", Colors.forestGreen);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "woo.wav");
                var soundPlayer = new SoundPlayer(filePath);
                soundPlayer.Play();
                Thread.Sleep(1000);
            }
            else
            {
                Helper.WriteLine($"{year} is not a common year.", Colors.brightRed);
                var filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "aww.wav");
                var soundPlayer2 = new SoundPlayer(filePath2);
                soundPlayer2.Play();
                Thread.Sleep(2500);
            }


            Console.ReadLine();

        }



    }


}


    



    
    


    



    




