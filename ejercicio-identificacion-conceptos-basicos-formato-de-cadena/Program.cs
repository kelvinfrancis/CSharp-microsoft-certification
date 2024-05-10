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

