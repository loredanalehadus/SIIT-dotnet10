//ctrl K + ctrl C -- comments out the selection using //
// ctrl + shift + / -- comments out using /**/

// declare variables;
int x;
int y;

// assign values;
x = 7;
y = x + 3;

// print value
Console.WriteLine(y);


/* The name game*/
Console.WriteLine("Care este numele tau?");
Console.WriteLine("Introdu prenumele: ");

string prenume;
prenume = Console.ReadLine();

string nume;
Console.Write("Introdu numele: ");
nume = Console.ReadLine();

Console.WriteLine("Buna, " + prenume + " " + nume);


/* Integer data types */
byte centuries = 12;    // Usually a small number
ushort years = 12345;
uint days = 123456789;
ulong hours = 123456789023456789; // May be a very big number
Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuries, years, days, hours);

// string interpolation
Console.WriteLine($"{centuries} centuries is {years} years, or {days} days, or {hours} hours.");


/* Float data type*/
float myFloat = 3.141592653589793238f;
double myDouble = 3.141592653589793238;
decimal myDecimal = 3.14159265358979323887432436574m;

double a = 0.66f;
double b = 0.34f;

if (a + b == 1)
{
    Console.WriteLine("equals 1");
}
else
{
    Console.WriteLine(a + b);
}


/* Boolean data type */
bool isRight = false;

if (isRight)
{
    Console.WriteLine("is right");
}

// implicit conversion
int myIntX = 5;
long myLongX = (long)myIntX;

// explicit conversion
myIntX = (int)myLongX;


/* Char data type */

Console.WriteLine('c' + '1' + '#');
Console.WriteLine("cdjd2319");

char myChar = '1';

int result;
//int myInt = Int32.Parse(myChar.ToString());
int myInt = (int)myChar;

Console.WriteLine($"myInt = {myInt}");

var myNumber = 5;
var myName = "Gigel";


Console.WriteLine();

// Nullable types

// not possible
//int age = null;
int? age = null;
//age = 0;
//age = 65;

Console.WriteLine("My age is " + age); // Result: My age is

double? weight = null;
weight = 70.5;

Console.WriteLine("My wight is " + weight + " kgs."); // Result: My wight is 70.5 kgs. 

bool? isMarried = null;
Console.WriteLine(isMarried);

string name = null;
string? surname = null;

// Var type
int myIntA;

var myObject = new Object();
myObject = 5;
myObject = "dog";
Console.WriteLine(myObject);

myObject = '*';
Console.WriteLine(myObject);


/* Expressions */

int c = 2 + 3; // compile time
int d = (c + 3) * (c - 4) + (2 * c + 7) / 4; // runtime 

Console.WriteLine(c);
Console.WriteLine(d);

if (c > d)
{
    Console.WriteLine("c is grater than d");
}

bool condition = (c > d) || ((c == 0) && (d == 0));

Console.WriteLine(condition); // should be False


