# C# Fundamentals Project <img src="https://github.com/user-attachments/assets/ff3abfce-ddd8-479e-aa57-7c77887f4ee3" style="width:60%; height:auto;">

This project consists of three programs that provide basic functionality in a simple console application. The user can choose between a random number guessing game, a basic calculator, and an average grade calculator. Each program serves as a demonstration of fundamental C# concepts.

## Programs

### 1. Random Number Guessing Game
In this game:
- The computer selects a random number between 1 and 100.
- The user is tasked with guessing the number.
- The user has 5 lives (5 attempts) to guess correctly.
- After each guess, the program gives feedback on whether the guess should be higher or lower.
- The game ends either when the user guesses the number correctly or runs out of lives.

### 2. Calculator
This program allows the user to perform basic arithmetic operations:
- **Addition** (`+`)
- **Subtraction** (`-`)
- **Multiplication** (`*`)
- **Division** (`/`)

The user is prompted to enter two numbers and select an operation. The program performs the chosen operation and displays the result. If division is selected, it checks if the second number is zero and provides a warning if so.

### 3. Average Grade Calculator
In this program:
- The user is prompted to input grades for three subjects.
- The program calculates the average grade and then determines the corresponding letter grade based on the average.
- If an invalid grade (less than 0 or greater than 100) is entered, the program stops and shows an error message.

The following letter grade mapping is used:
- 90-100: AA
- 85-89: BA
- 80-84: BB
- 75-79: CB
- 70-74: CC
- 65-69: DC
- 60-64: DD
- 55-59: FD
- 0-54: FF

