// this is how you comment in C#

// This is how to declare a variable in C#, You must declare what datatype the variable is.
int x;
x = 5;
Console.WriteLine(x); //prints the value in the parnethesis with a new line afterwards (same as a python print)

int x = 5; //This method also works
Console.Write(x); //prints the value in the parenthesis without a new line afterward

Console.ReadLine(); //This is how to get input from the user. returns a string and does not allow for text to be provided to prompt
Console.Write("What is your favorite color?");
string color = Console.ReadLine();


//  if statements
if (x > y)
{
    Console.WriteLine("Greater Than"); //it does matter in C# when to use single and double quotes
}
// if statements and functions in C# use curly braces as the means to declare the body of said item


"""
in C# statements end in a semicolon ';'. 
The rule to end statements with semicolons applies to statements 
such as calling a function, declaring a variable, setting a variable, 
and so forth. You do not put a semicolon between the condition of an 
if statement and its body, or the name of a function and its body.
"""


// String Interpolation
string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");
// to begin start with the dollar sign '$', similar to the f in python


//
// loops
//

// while loops
string response == "yes";

while (respone == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}
// typical while loop

//Do-While loops
string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");
// these are exactly like a while loop except
// they do the body of the function at least once

// for loops
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
// they are made more like for x in range loops in python
// the opening statement has three semicolon separated values
// 1. initializes the value
// 2. the condition to check
// 3. an increment step
// basically it does 3 to 1 until 1 is 2

// foreach loops
foreach (string color in colors)
{
    Console.WriteLine(color);
}
// more like a typical for loop in python


// how to get random numbers
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);



// 
// collections
//

// lists
List<int> numbers = new List<int>();
List<string> words = new List<string>();



