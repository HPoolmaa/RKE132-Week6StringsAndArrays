//string[] fruit = {"apples", "bananas", "oranges"}

using System.Drawing;

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}.");

int fruitArrayLenght = fruit.Length;

Console.WriteLine($"There are {fruitArrayLenght} fruits in your array");


//// 1 ---
//for (int i = 0; i < fruitArrayLenght; i++)
//{
//    Console.WriteLine(fruit[i]);
//}

// 2 ---
//foreach(string fruitString in fruit)
//{
//    Console.WriteLine(fruitString);
//}

// 3 ---
//for (int i = 2; i < fruitArrayLenght; i--)
//{
//    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); // foreach'is ei saa elemente muuta, ainult for-loop'is
//    Console.WriteLine(fruit[i]);
//}

string[] colors = { "red", "green", "blue", "pink", "yellow" };
for (int i = colors.Length - 5; i >= 0; i++)
{
    Console.WriteLine($"{colors.Length - i}. {colors[i]}");
}
