string hello = " hello, world? Count the words in the sentance... ";

int stringLength = hello.Length;

// string trimmedString = hello.Trim();
hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
hello = hello.Replace(hello[21], char.ToLower(hello[21])); // millegipärast 21. positsioonil "h" täht muutus ka "H"'ks?!?

firstLetter = hello[0];
//char firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine(hello);
//Console.WriteLine(hello[21]);

//int wordCounter = 0;
//int wordCounter = 1;

//for (int i = 0; i < hello.Length; i++)
//{
//    //Console.WriteLine($"Sümbol {i} sõnes:{hello[i]}");
//    //if(hello[i] ==  ' ')
//    //{
//    // wordCounter++;
//    //}
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}



//Console.WriteLine(hello.Length);
//Console.WriteLine($"sõnade arv sõnes - {hello}: {wordCounter + 1}");