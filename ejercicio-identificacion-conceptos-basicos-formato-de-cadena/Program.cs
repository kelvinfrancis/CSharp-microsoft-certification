// // ----- MONEY FORMAT :C
// decimal price = 67.55m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // ------ NUMBER FORMAT :N
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// // ----- with 4 :N4 number after de . 
// Console.WriteLine($"Measurement: {measurement:N4} units");
// // ------- PERCENTAGE FORMAT
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// // FORMAT COMBINATION 
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
// System.Console.WriteLine(yourDiscount);

// ------- Ejercicio: Exploración de la interpolación de cadenas
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// System.Console.WriteLine($"   Shares: {productShares:N3} Product");
// System.Console.WriteLine($"     Sub Total: {subtotal:C}");
// System.Console.WriteLine($"           Tax: {taxPercentage:P2}");
// System.Console.WriteLine($"     Total Billed: {total:C}");

// Ejercicio: Relleno y alineación
// string input = "Pad this";
// System.Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// Uso de cadenas con relleno
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);

// // Adición del nombre del beneficiario a la salida
// formattedLine += payeeName.PadRight(24);

// // Adición del importe del pago a la salida
// formattedLine += paymentAmount.PadLeft(10);

// // Adición de una línea de números sobre la salida para confirmar más fácilmente el resultado
// Console.WriteLine("1234567890123456789012345678901234567890");
// System.Console.WriteLine(formattedLine);

// Ejercicio: Completar el desafío de aplicar la interpolación de cadenas a una carta de formulario

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
System.Console.WriteLine($"Dear {customerName},");

System.Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

System.Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");

System.Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here

Console.WriteLine(comparisonMessage);

