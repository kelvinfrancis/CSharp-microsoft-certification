// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

// string[] pallets = {"B14", "A11", "B12", "A13"};
// ------------- Sort
// System.Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// ------------- Reverse
// System.Console.WriteLine("");
// System.Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// --------------- Clear
// System.Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// ------------ Resize
// System.Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// System.Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// ------------- method ToCharArray()
// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);
// //string result = new string(valueArray);
// // ---------- Join()
// string result = String.Join(",", valueArray);
// System.Console.WriteLine(result);

// // --------- Split()
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     System.Console.WriteLine(item);
// }

// DESAFIO - Complete un desafío para invertir las palabras de una oración
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] message = pangram.Split(' ');
// string[] newMessage = new string[message.Length];
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// string result = string.Join(" ", newMessage);
// System.Console.WriteLine(result);

// DESAFIO - Desafío para analizar una cadena de pedidos, ordenar los pedidos y etiquetar posibles errores
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] idOrders = orderStream.Split(",");
Array.Sort(idOrders);
foreach (var id in idOrders)
{
    if (id.Length != 4)
        System.Console.WriteLine(id + "\t- Error");
    else
        System.Console.WriteLine(id);
}
