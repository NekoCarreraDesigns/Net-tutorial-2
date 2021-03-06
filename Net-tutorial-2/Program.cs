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
// Console.WriteLine("");
// Console.WriteLine("Floating point types");
// Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// reference types 
// int[] data = new int[3];
// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

// data type casting and conversion
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// casting
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// sorting arrays
// string[] boxes = { "A123", "B456", "A124", "B678" };

// Console.WriteLine("Sorted...");
// Array.Sort(boxes);
// foreach (var box in boxes)
// {
//     Console.WriteLine($"-- {box}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(boxes);
// foreach (var box in boxes)
// {
//     Console.WriteLine($"-- {box}");
// }

// Console.WriteLine("");

// Console.WriteLine($"Before: {boxes[0]}");
// Array.Clear(boxes, 0, 2);
// Console.WriteLine($"After: {boxes[0]}");
// Console.WriteLine($"Clearing 2 ... count: {boxes.Length}");
// foreach (var box in boxes)
// {
//     Console.WriteLine($"-- {box}");
// }

// Console.WriteLine("");
// Array.Resize(ref boxes, 6);
// Console.WriteLine($"Resizing 6 ... count: {boxes.Length}");

// boxes[4] = "C100";
// boxes[5] = "C101";

// foreach (var box in boxes)
// {
//     Console.WriteLine($"-- {box}");
// }

// Console.WriteLine("");
// Array.Resize(ref boxes, 3);
// Console.WriteLine($"Resizing 3 ... count: {boxes.Length}");

// foreach (var box in boxes)
// {
//     Console.WriteLine($"-- {box}");
// }

// string value = "this is the way";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// composite formatting
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// using format tokens
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// using interpolation
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save{discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// int invoiceNumber = 1201;
// decimal productMeasurement = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
// Console.WriteLine($"     Sub total: {subtotal:C}");
// Console.WriteLine($"         Tax percentage:  {taxPercentage:P2}");
// Console.WriteLine($"     Total due: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769";
// string payeeName = "Mrs. Candace Heckstall";
// string paymentAmount = "$1,000,000,000";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine(formattedLine);


// pulling values from a string
// string message = "Find what is (inside the parentheses)";
// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(what if) there are {different symbols} [needs a close] (more than) one set of (Parens)";

// char[] openSymbols = { '[', '{', '(' };

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;

//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

// }

// replace remove helper methods
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--an--exa-mp-le--of--replace";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);