// string [] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     if (names[i] == "David") names[i] = "Sammy";
// }

// foreach (var name in names)
// {
//     System.Console.WriteLine(name);
// }

// FizzBuzz Challenge
for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
        System.Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        System.Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        System.Console.WriteLine($"{i} - Buzz");
    else
        System.Console.WriteLine(i);
}