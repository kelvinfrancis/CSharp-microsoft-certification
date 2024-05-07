// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

// int first = 2;
// string second = "4";
// string result = first + second;
// System.Console.WriteLine(result);

// ------------ Conversion Implicita
// int myInt = 3;
// System.Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// System.Console.WriteLine($"decimal: {myDecimal}");

// ----------- Conversion explicita
// decimal myDecimal = 3.14m;
// System.Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// System.Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// System.Console.WriteLine($"Decimal: {myDecimal}");
// System.Console.WriteLine($"Float  : {myFloat}");

// ---------------- ToString()
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// System.Console.WriteLine(message);

// --------------- string to int with Parse()
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// System.Console.WriteLine(sum);

// ---------------- Convert Class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// System.Console.WriteLine(result);

// redondeo de decimales con Convert
// int value = (int)1.5m; // casting truncates
// System.Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// System.Console.WriteLine(value2);

// ----------- Conversion de cadena en int con TryParse()
string value = "badBunny";
int result = 0;
if (int.TryParse(value, out result))
{
    System.Console.WriteLine($"Measurement: {result}");
}
else
{
    System.Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
    System.Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Ejercicio: Realización de un desafío para combinar valores de matriz de cadenas como cadenas y como enteros

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = "";
// decimal num;
// decimal sum = 0;

// foreach (var item in values)
// {
//     if (decimal.TryParse(item, out num))
//         sum += num;
//     else
//         message += item;
// }
// System.Console.WriteLine($"Message: {message}");
// System.Console.WriteLine($"Total: {sum}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3/value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
