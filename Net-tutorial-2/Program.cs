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
// Console.WriteLine("First Decremnt: " + value);

// value -= 1;
// Console.WriteLine("Second Decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celsius} celsius");


