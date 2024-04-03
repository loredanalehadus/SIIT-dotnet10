/*Create a new C# project and create a program that assigns integer values to variables.
 * Be sure that each value is stored in the correct variable type 
 * (try to find the most suitable variable type in order to save memory). 
 * Finally you need to print all variables to the console.
```
Values
-100
128
-3540
64876
2147483648
- 1141583228
- 1223372036854775808
```*/

sbyte mySbyte = -100;
byte myByte = 128;
short myShort = -3540;
ushort myUShort = 64876;
uint myUInt = 2147483648;
int myInt = -1141583228;
long myLong = -1223372036854775808;

Console.WriteLine(mySbyte);
Console.WriteLine(myByte);
Console.WriteLine("the short value is:{0},{1},{2}", myShort, myUShort, myUInt);
Console.WriteLine($"the long value {myLong}");