using System;

namespace CSharpFundamentalsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying options for the user to select
            Console.WriteLine("1 - Random Number Guessing Game");
            Console.WriteLine("2 - Calculator");
            Console.WriteLine("3 - Average Grade Calculator");

            string choice;

            // Loop to ensure the user selects a valid option (1, 2, or 3)
            do
            {                
                Console.Write("Which program would you like to run? (1, 2, 3): ");
                choice = Console.ReadLine();

                // Start the corresponding program based on the user's choice
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nStarting the Random Number Guessing Game...\n");
                        StartRandomNumberGuessingGame();
                        break;

                    case "2":
                        Console.WriteLine("\nStarting the Calculator...\n");
                        StartCalculatorProgram();
                        break;

                    case "3":
                        Console.WriteLine("\nStarting the Average Calculator...\n");
                        StartAverageGradeCalculator();
                        break;

                    default:
                        // If the user enters an invalid option, display an error message
                        Console.WriteLine("\nInvalid choice.Please select 1, 2, or 3.");
                        break;
                }
            } while (choice != "1" && choice != "2" && choice != "3");
            
            //  --------------------------------------------- 
            //  ---------RANDOM NUMBER GUESSING GAME---------
            //  --------------------------------------------- 

            void StartRandomNumberGuessingGame()
            {
                // Explanation and introduction to the game
                Console.WriteLine("Welcome to the Random Number Guessing Game!");
                Console.WriteLine("The computer has selected a random number between 1 and 100.");
                Console.WriteLine("You have 5 lives to guess the correct number.");
                Console.WriteLine("Good luck!\n");

                // Generate a random number between 1 and 100
                Random random = new Random();
                int randomNumber = random.Next(1, 101);

                int guess;
                int i = 5;  // The user has 5 attempts to guess correctly
                do
                {
                    // Prompt the user to make a guess
                    Console.Write("Enter your guess (1-100): ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    i--;    // Decrease the number of remaining attempts

                    if (i == 0) // Check if the game is over (user ran out of lives)
                    {
                        Console.WriteLine("Game Over! You've run out of lives.");
                        Console.WriteLine($"The correct number was {randomNumber}.");   // Display the correct number
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Try a lower number.");
                        Console.WriteLine($"You have {i} lives remaining.\n");  // Display remaining attempts
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Try a higher number.");
                        Console.WriteLine($"You have {i} lives remaining.\n");  // Display remaining attempts
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the correct number!");
                        Console.WriteLine("The game is over. Thanks for playing!"); // Congratulate the user for guessing correctly
                    }

                } while (randomNumber != guess && i != 0);  // Continue until the user guesses correctly or runs out of attempts.
            }

            //  ---------------------------------------------- 
            //  ------------------CALCULATOR------------------
            //  ---------------------------------------------- 

            void StartCalculatorProgram()
            {
                // Explanation of the calculator program
                Console.WriteLine("Welcome to the Calculator Program!");
                Console.WriteLine("This program allows you to perform basic arithmetic operations.");
                Console.WriteLine("You can choose to add, subtract, multiply or divide two numbers.");
                Console.WriteLine("Follow the prompts to enter your numbers and operation.");

                // Ask the user for the first and second numbers
                Console.Write("\nEnter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());                              

                char operations;
                do
                {
                    // Present operation choices to the user
                    Console.WriteLine("\nChoose an operation:");
                    Console.WriteLine("+ for Addition");
                    Console.WriteLine("- for Subtraction");
                    Console.WriteLine("* for Multiplication");
                    Console.WriteLine("/ for Division");

                    // Ask the user to choose an operation
                    Console.Write("Enter your choice: ");
                    operations = Convert.ToChar(Console.ReadLine());

                    // Perform the chosen operation
                    switch (operations)
                    {

                        case '+':
                            double addition = num1 + num2;                            
                            Console.WriteLine($"\nThe result is --> {num1} {operations} {num2} = {addition}");
                            break;

                        case '-':
                            double subtraction = num1 - num2;                            
                            Console.WriteLine($"\nThe result is --> {num1} {operations} {num2} = {subtraction}");
                            break;

                        case '*':
                            double multiplication = num1 * num2;                             
                            Console.WriteLine($"\nThe result is --> {num1} {operations} {num2} = {multiplication}");
                            break;

                        case '/':
                            while (num2 == 0)   // If the user tries to divide by zero, ask them to enter a new second number
                            {
                                Console.WriteLine("\nDivision by zero is not allowed. Please enter a different number.");
                                Console.Write("Enter the second number: ");
                                num2 = Convert.ToDouble(Console.ReadLine());
                            }

                            double division = num1 / num2;                            
                            Console.WriteLine($"\nThe result is --> {num1} {operations} {num2} = {division}");
                            break;

                        default:    // If the user enters an invalid operation, display an error message
                            Console.WriteLine("Invalid operation. Please select +, -, *, or /.");
                            break;
                    }

                } while (operations != '+' && operations != '-' && operations != '*' && operations != '/'); // Loop until a valid operation is selected.

            }

            //  ----------------------------------------------          
            //  -----------AVERAGE GRADE CALCULATOR-----------
            //  ---------------------------------------------- 

            void StartAverageGradeCalculator()
            {
                Console.WriteLine("Welcome to the Average Grade Calculator!");
                Console.WriteLine("In this program, you'll enter three subject grades.");
                Console.WriteLine("The program will calculate your average grade and show you your letter grade.");
                Console.WriteLine("Please make sure to enter valid grades between 0 and 100.\n");

                // Collect the grades for each subject from the user
                double grade1 = EnterGrade();
                if (grade1 == -1) return;

                double grade2 = EnterGrade();
                if (grade2 == -1) return;

                double grade3 = EnterGrade();
                if (grade3 == -1) return;

                // Calculate the average of the grades
                double average = (grade1 + grade2 + grade3) / 3;
                Console.WriteLine("\nThe average grade is: " + average);

                // Determine the letter grade based on the average
                string letterGrade = LetterGrade(average);
                Console.WriteLine("Your letter grade is: " + letterGrade);
            }


            //  -----------------ENTER GRADE-----------------

            double EnterGrade() // Function to ask the user to input a grade
            {
                Console.Write("Enter the grade for the subject (0-100): ");
                double grade = Convert.ToDouble(Console.ReadLine());

                // If an invalid grade is entered, display an error message and terminate the program
                if (grade < 0 || grade > 100)   
                {
                    Console.WriteLine("\nInvalid grade entered! The grade must be between 0 and 100. The program will terminate.");
                    return -1;
                }
                return grade;
            }

            //  -----------------LETTER GRADE-----------------

            string LetterGrade(double average)  // Function to return the letter grade based on the average score
            {
                if (average >= 90) return "AA";
                else if (average >= 85) return "BA";
                else if (average >= 80) return "BB";
                else if (average >= 75) return "CB";
                else if (average >= 70) return "CC";
                else if (average >= 65) return "DC";
                else if (average >= 60) return "DD";
                else if (average >= 55) return "FD";
                else return "FF";
            }
        }
    }
}