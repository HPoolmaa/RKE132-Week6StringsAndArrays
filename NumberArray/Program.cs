﻿

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;

int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length+1);
   // numbers[i] = rnd.Next(1, 11);
   sum = sum + numbers[i];
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total:{sum}");