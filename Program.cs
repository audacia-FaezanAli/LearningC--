// See https://aka.ms/new-console-template for more information

using LearningC__.Models;

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