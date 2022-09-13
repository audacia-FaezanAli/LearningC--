// See https://aka.ms/new-console-template for more information

using LearningC__.Models;
using LearningC__.Operators;

//VARIABLES TUTORIAL

//var testString = "Hello World";
//var testInt = 6;
//var testBool = false;
//var testDecimal = 1.5;
//var testChar = 't';

//Console.WriteLine(testString);
//Console.WriteLine(testInt);
//Console.WriteLine(testBool);
//Console.WriteLine(testDecimal);
//Console.WriteLine(testChar);

//testString = "Goodbye World";
//testInt = 21;
//testBool = true;
//testDecimal = 27.25;
//testChar = '-';

//Console.WriteLine(testString);
//Console.WriteLine(testInt);
//Console.WriteLine(testBool);
//Console.WriteLine(testDecimal);
//Console.WriteLine(testChar);

//const string testString2 = "Hello there";
//const int testInt2 = 36;
//const bool testBool2 = true;
//const double testDouble = 1.34234;
//const char testChar2 = 'r';

//Console.WriteLine(testString2);
//Console.WriteLine(testInt2);
//Console.WriteLine(testBool2);
//Console.WriteLine(testDouble);
//Console.WriteLine(testChar2);

////testString2 = "updated string";

//var newUser = new User("Faezan", "Ali", "faezan.ali", "08/01/1995", "faezan.ali@audacia.co.uk");

//Console.WriteLine(newUser.firstName);
//Console.WriteLine(newUser.lastName);
//Console.WriteLine(newUser.userName);
//Console.WriteLine(newUser.dateOfBirth);
//Console.WriteLine(newUser.email);

//Console.WriteLine(newUser.LogUserDetails());

//OPERATORS ARITHMETIC TUTORIAL

var aritmeticVar= new Arithmetic();
const int num1 = 7;
const int num2 = 32;
const decimal num3 = 238.27m;
const int num4 = 9854;
const double num5 = 2.324;

var addition = aritmeticVar.Add(num1, num2);
Console.WriteLine(addition);

var subtraction = aritmeticVar.Subtract(num3, num1);
Console.WriteLine(subtraction);

var multiplication = aritmeticVar.Multiply(num2, num4);
Console.WriteLine(multiplication);

var division = aritmeticVar.Divide(num4, (decimal)num5);
Console.WriteLine(division);

var exponential = aritmeticVar.Exponentiation(num1, num5);
Console.WriteLine(exponential);

var modulus = aritmeticVar.Modulus(num2, num1);
Console.WriteLine(modulus);

var increment = aritmeticVar.Increment(67.2);
Console.WriteLine(increment);

var decrement = aritmeticVar.Increment(564.435);
Console.WriteLine(decrement);

aritmeticVar.FibonacciCalc();

Console.WriteLine(aritmeticVar.Mod(54, 7));

Console.WriteLine(aritmeticVar.PerfectSquare(25));
Console.WriteLine(aritmeticVar.PerfectSquare(14));