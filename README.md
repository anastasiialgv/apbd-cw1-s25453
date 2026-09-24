# Statistics Helper (C# Homework) 📊

A utility class written in C# designed to perform basic statistical calculations and check the parity (even/odd) of numbers within collections. Part of a C# homework assignment (`Homework1` namespace).

## ✨ Features

- **Average Calculation (`CalculateAverage`):** Computes the integer average of an array of values.
- **Maximum Value (`CalculateMax`):** Finds the highest number in a given array.
- **Minimum Value (`CalculateMin`):** Finds the lowest number in a given array.
- **Parity Checker (`CheckParity`):** Evaluates a list of integers using a C# lambda expression (`Func<int, bool>`) to determine whether each number is even or odd, and prints the result to the console.

## 🚀 How to Use

1. Add the `StatisticsHelper.cs` file to your C# project under the `Homework1` namespace.
2. Initialize and use the methods as shown in the example below:

```csharp
using System;
using System.Collections.Generic;
using Homework1;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 42, 7, 89, 3 };

        // Static calculations
        Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");
        Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers)}");
        Console.WriteLine($"Min: {StatisticsHelper.CalculateMin(numbers)}");

        // Instance-based parity check
        List<int> listToCheck = new List<int> { 4, 5, 12, 17 };
        StatisticsHelper helper = new StatisticsHelper(listToCheck);
        helper.CheckParity();
    }
}
