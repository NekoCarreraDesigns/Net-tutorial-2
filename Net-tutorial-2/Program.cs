// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);
// Console.WriteLine('a');
// Console.WriteLine(123);
// Console.WriteLine(12.3m);
// Console.WriteLine(true);
// Console.WriteLine(false);

// string firstName;
// firstName = "Candace";
// Console.WriteLine(firstName);
// firstName = "Nick";
// Console.WriteLine(firstName);
// firstName = "Terrick";
// Console.WriteLine(firstName);

// var message = "Hello and welcome to C#";
// Console.WriteLine(message);

// var integer = 123;
// Console.WriteLine(integer);

// var decimalNumber = 34.4;
// Console.WriteLine(decimalNumber);

//escape
// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");
// Console.WriteLine("hello \"World\"!");
// Console.WriteLine("c:\\source\\repos");

//escape and verbatim
// Console.WriteLine("Generating invoices for customer \"Hextasy Art\" ...\n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.WriteLine("\nOutput Directory:\t");
// Console.WriteLine(@"c:\invoices");

// concatenation
// string firstName = "Bob";
// string greeting = "hello";
// Console.WriteLine(greeting + " " + firstName + "!");

// string interpolation
// string firstName = "Bob";
// string message = "Hello";
// Console.WriteLine($"{message}  {firstName}");

// // verbatim and string interpolation
// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

// using mathematic operators
// int firstNumber = 31;
// int secondNumber = 47;
// Console.WriteLine(firstNumber + secondNumber);

// string firstName = "Candace";
// int artPiecesSold = 10;
// Console.WriteLine(firstName + " Sold " + (artPiecesSold + 7) + " pieces of art");

// int sum = 7 + 5;
// int difference = 7 - 5;
// int product = 7 * 5;
// int quotient = 8 / 4;
// decimal decimalQuotient = 7.0m / 5;

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Difference: " + difference);
// Console.WriteLine("Product: " + product);
// Console.WriteLine("Quotient: " + quotient);
// Console.WriteLine("Decimal Quotient: " + decimalQuotient);

// int first = 7;
// int second = 5;
// decimal secondDecimalQuotient = (decimal)first / (decimal)second;
// Console.WriteLine(secondDecimalQuotient);

// Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
// Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

// int value1 = 3 + 4 * 5;
// int value2 = (3 + 4) * 5;
// Console.WriteLine(value1);
// Console.WriteLine(value2);

// increment and decrement 
// int value = 1;

// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value++;
// Console.WriteLine("Third increment: " + value);

// value = value - 1;
// Console.WriteLine("First Decrement: " + value);

// value -= 1;
// Console.WriteLine("Second Decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32m) * (5m / 9m);
// Console.WriteLine($"The temperature is {celsius} celsius");

// Methods in .NET library
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"first roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 100;
// int secondValue = 500;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// Booleans and branching
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Arrays and data types
// string[] placesIWantToGo = new string[5];

// placesIWantToGo[0] = "Spain";
// placesIWantToGo[1] = "Portugal";
// placesIWantToGo[2] = "Germany";
// placesIWantToGo[3] = "Netherlands";
// placesIWantToGo[4] = "Czechia";

// string[] placesIWantToGo = { "Spain", "Portugal", "Germany", "Netherlands", "Czechia" };

// Console.WriteLine($"First: {placesIWantToGo[0]}");
// Console.WriteLine($"Second: {placesIWantToGo[1]}");
// Console.WriteLine($"Third: {placesIWantToGo[2]}");
// Console.WriteLine($"Fourth: {placesIWantToGo[3]}");
// Console.WriteLine($"Fifth: {placesIWantToGo[4]}");

// placesIWantToGo[0] = "Costa Rica";

// Console.WriteLine($"First reassign: {placesIWantToGo[0]}");
// Console.WriteLine($"There are {placesIWantToGo.Length} places I want to go");

// foreach statement to loop through an array
// string[] names = { "Candace", "Nick", "Lolo" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = { 100, 200, 300, 400, 500 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} (running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// boolean operators
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue1 = "a";
// Console.WriteLine(myValue1 != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 2);

// string message = "The bagels are onion and shmeared with cream cheese";
// Console.WriteLine(!message.Contains("cheese"));
// Console.WriteLine(!message.Contains("spread"));

// Code blocks and variable scope

// bool cool = true;
// if (cool)
// {
//     int value = 10;
//     Console.WriteLine($"indie rock: {value}");
// }

// Switch statement
// int awesomenessLevel = 400;
// string awesomePerson = "Candace";

// string title = "";

// switch (awesomenessLevel)
// {
//     case 100:
//         title = "Their okay";
//         break;
//     case 200:
//         title = "Their likeable";
//         break;
//     case 300:
//         title = "Their Cool";
//         break;
//     case 400:
//         title = "Is so Amazing!";
//         break;
//     default:
//         title = "lame";
//         break;
// }

// Console.WriteLine($"{awesomePerson}, {title}");

// for statement for iteration through a loop
// loop forward 
// for (int i = 0; i < 20; i++)
// {
//     Console.WriteLine(i);
// }
// // loop backwards
// for (int i = 20; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }
// // skipping elements in the loop
// for (int i = 0; i < 20; i += 2)
// {
//     Console.WriteLine(i);
// }
// adding break keyword to stop iteration
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 6) break;
// }
// Looping through an array
// string[] names = { "Candace", "Nick", "Brandy", "Lolo", "Terrick" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "Terrick") names[i] = "Amanda";
// foreach (var name in names) Console.WriteLine(name);

// do while loops
// Random dice = new Random();
// int hero = 10;
// int monster = 10;

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} and now has {monster} health");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} and now has {hero} health");


// } while (hero > 0 && monster > 0);
// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// integral types 
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types");
// Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

// floating point types
Console.WriteLine("");
Console.WriteLine("Floating point types");
Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");