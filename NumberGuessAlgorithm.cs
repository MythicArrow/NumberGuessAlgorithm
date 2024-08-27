using System;

class Program
{
    static void Main()
    {
        // 1. Ask the user to select a number (n) between 1 and 8
        Console.Write("Choose a number between 1 and 8 (n): ");
        int n = int.Parse(Console.ReadLine());

        // 2. Multiply the number by 4
        int step2 = n * 4;

        // 3. Add 10 to the result
        int step3 = step2 + 10;

        // 4. Multiply the result by 25
        int step4 = step3 * 25;

        // 5. Add 1773 to the result
        int step5 = step4 + 1773;

        // 6. Ask the user if they have celebrated their birthday this year
        Console.Write("Have you celebrated your birthday this year? (Y for Yes, N for No): ");
        string birthdayCelebrated = Console.ReadLine().ToUpper();

        if (birthdayCelebrated == "Y")
        {
            // If the birthday was celebrated, add 1
            step5 += 1;
        }

        // 7. Ask the user for their birth year
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        // Subtract the birth year from the result
        int finalResult = step5 - birthYear;

        // Calculate the age by subtracting the birth year from the current year
        int currentYear = birthdayCelebrated == "Y" ? 2024 : 2023;
        int age = currentYear - birthYear;

        // Print the selected number (n), the age, and the final result
        Console.WriteLine($"You selected the number: {n}");
        Console.WriteLine($"Your age is: {age}");
        Console.WriteLine($"The final result is: {finalResult}");
    }
}
