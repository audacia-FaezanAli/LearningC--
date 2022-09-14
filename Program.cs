// See https://aka.ms/new-console-template for more information

using LearningC__.Models;
using LearningC__.Operators;

/**VARIABLES TUTORIAL
 * 
**/
var testString = "Hello World";
var testInt = 6;
var testBool = false;
var testDecimal = 1.5;
var testChar = 't';

Console.WriteLine(testString);
Console.WriteLine(testInt);
Console.WriteLine(testBool);
Console.WriteLine(testDecimal);
Console.WriteLine(testChar);

testString = "Goodbye World";
testInt = 21;
testBool = true;
testDecimal = 27.25;
testChar = '-';

Console.WriteLine(testString);
Console.WriteLine(testInt);
Console.WriteLine(testBool);
Console.WriteLine(testDecimal);
Console.WriteLine(testChar);

const string testString2 = "Hello there";
const int testInt2 = 36;
const bool testBool2 = true;
const double testDouble = 1.34234;
const char testChar2 = 'r';

Console.WriteLine(testString2);
Console.WriteLine(testInt2);
Console.WriteLine(testBool2);
Console.WriteLine(testDouble);
Console.WriteLine(testChar2);

//testString2 = "updated string";

var newUser = new User("Faezan", "Ali", "faezan.ali", "08/01/1995", "faezan.ali@audacia.co.uk");

Console.WriteLine(newUser.firstName);
Console.WriteLine(newUser.lastName);
Console.WriteLine(newUser.userName);
Console.WriteLine(newUser.dateOfBirth);
Console.WriteLine(newUser.email);

Console.WriteLine(newUser.LogUserDetails());


//OPERATORS ARITHMETIC TUTORIAL

var aritmeticVar = new Arithmetic();
const int num1 = 7;
const int num2 = 32;
const decimal num3 = 238.27m;
const int num4 = 9854;
const double num5 = 2.324;

var addition = aritmeticVar.Add(num1, num2); //answer = 39
Console.WriteLine(addition);

var subtraction = aritmeticVar.Subtract(num3, num1); //answer = 231.27
Console.WriteLine(subtraction);

var multiplication = aritmeticVar.Multiply(num2, num4); //answer = 315328
Console.WriteLine(multiplication);

var division = aritmeticVar.Divide(num4, (decimal)num5); //answer = 4240.10
Console.WriteLine(division);

var exponential = aritmeticVar.Exponentiation(num1, num5); //answer = 92.04
Console.WriteLine(exponential);

var modulus = aritmeticVar.Modulus(num2, num1); //answer = 4
Console.WriteLine(modulus);

var increment = aritmeticVar.Increment(67.2); //answer = 68.2
Console.WriteLine(increment);

var decrement = aritmeticVar.Decrement((float)564.435); //answer = 563.435
Console.WriteLine(decrement);

aritmeticVar.FibonacciCalc();

Console.WriteLine(aritmeticVar.Mod(54, 7)); //answer = 7, 5

Console.WriteLine(aritmeticVar.PerfectSquare(25)); //answer = true
Console.WriteLine(aritmeticVar.PerfectSquare(14)); //answer = false


//COMPARISON OPERATORS TUTORIAL

var comparisonVar = new Comparison();

const int num6 = 7;
const int num7 = 32;
const int num8 = 0;
const int num9 = -3454;
const float num10 = -0.5f;

var greaterThanCheck = comparisonVar.GreaterThan(num6, num7); //answer = false
Console.WriteLine(greaterThanCheck);

var greaterThanOrEqualCheck = comparisonVar.GreaterThanOrEqual(num6, 7); //answer = true
Console.WriteLine(greaterThanOrEqualCheck);

var lessThanCheck = comparisonVar.LessThan(num9, num8); //answer = true
Console.WriteLine(lessThanCheck);

var lessThanOrEqualCheck = comparisonVar.LessThanOrEqual(num7, 9); //answer = false 
Console.WriteLine(lessThanOrEqualCheck);

var betweenTwoNumbersCheck = comparisonVar.BetweenTwoNumbers(5, num8, num7); //answer = true
Console.WriteLine(betweenTwoNumbersCheck);

var signCheck1 = comparisonVar.PositiveOrNegative(num8); //answer = zero
var signCheck2 = comparisonVar.PositiveOrNegative(num10); //answer = negative
var signCheck3 = comparisonVar.PositiveOrNegative(num6); //answer = positive

Console.WriteLine(signCheck1);
Console.WriteLine(signCheck2);
Console.WriteLine(signCheck3);

var greaterThanCheck2 = comparisonVar.GreaterThan((int)aritmeticVar.Add(64, 9), (int)aritmeticVar.Multiply(12, 3)); //answer = true
Console.WriteLine(greaterThanCheck2); 


//BOOLEAN LOGICAL OPERATORS TUTORIAL

var booleanLogicVar = new BooleanLogical();

var andCheck = booleanLogicVar.AndLogic(greaterThanCheck, lessThanCheck); //answer = false
Console.WriteLine(andCheck);

var orCheck = booleanLogicVar.OrLogic(greaterThanCheck, lessThanCheck); //answer = true
Console.WriteLine(orCheck);

var notCheck = booleanLogicVar.NotLogic(lessThanOrEqualCheck); // answer = true
Console.WriteLine(notCheck);


//ASSIGNMENT OPERATORS TUTORIAL

var assignmentVar = new Assignment();

var addAssignment = assignmentVar.AddAndAssignment(num1, num2); // answer = 39
Console.WriteLine(addAssignment);

var subtractAssignment = assignmentVar.SubtractAndAssignment(num1, num2); // answer = -25
Console.WriteLine(subtractAssignment);

var multiplyAssignment = assignmentVar.MultiplyAndAssignment(num1, num2); // answer = 224
Console.WriteLine(multiplyAssignment);

var divideAssignment = assignmentVar.DivideAndAssignment(num2, num1); // answer = 4.57
Console.WriteLine(divideAssignment);

var modAssignment = assignmentVar.ModAssignment(54, -7);
Console.WriteLine(modAssignment);