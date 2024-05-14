## Inheritance exercise: Person

You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person. Your task is to model the application. The only constraints are:
-	People should not be able to have negative age
-	Children should not be able to have age more than 15.

* Person – represents the base class by which all others are implemented
* Child - represents a class which is derived by the Person.

Note
Your class’s names MUST be the same as the names shown above!!!
Sample Main()
```csharp
static void Main()
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    try
    {
        Child child = new Child(name, age);
        Console.WriteLine(child);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}
```

Create a new empty class and name it Person. Set its access modifier to public so it can be instantiated from any project. Every person has a name, and age.
Sample Code
```csharp
public class Person
{
   // 1. Add Fields

   // 2. Add Constructor

   // 3. Add Properties

   // 4. Add Methods
}
```
Step 2 – Define the fields
Define a field for each property the class should have (e.g. Name, Age) 
Step 3 - Define the Properties of a Person
Define the Name and Age properties of a Person. Ensure that they can only be changed by the class itself or its descendants (pick the most appropriate access modifier). 
Sample Code
```csharp
public virtual string Name
{
    get
    {
        //TODO
    }
    set
    {
        //TODO
    }
}

public virtual int Age
{
    get
    {
        //TODO
    }
    set
    {
        //TODO
    }
}
```
Step 4 - Define a Constructor
Define a constructor that accepts name and age.
Sample Code
```csharp
public Person(string name, int age)
{
    this.Name = name;
    this.Age = age;
}
```
Step 5 - Perform Validations
After you have created a field for each property (e.g. Name and Age). Next step is to perform validations for each one. The getter should return the corresponding field’s value and the setter should validate the input data before setting it. Do this for each property.
Sample Code
```csharp
public virtual int Age
{
    get
    {
         return this.age;
    }
    set
    {
        if (value < 0)
        {
            throw new ArgumentException("Age must be positive!");
        }

        //TODO set field age with value
    }
}
```
Constraints
•	If the age of a person is negative – exception’s message is: "Age must be positive!"
•	If the age of a child is bigger than 15 – exception’s message is: "Child's age must be less than 15!"
•	If the name of a child or a person is no longer than 3 symbols – exception’s message is: "Name's length should not be less than 3 symbols!"
Step 6 - Override ToString()
As you probably already know, all classes in C# inherit the Object class and therefore have all its public members (ToString(), Equals() and GetHashCode() methods). ToString() serves to return information about an instance as string. Let's override (change) its behavior for our Person class.
Sample Code
```csharp
public override string ToString()
{
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                         this.Name,
                         this.Age));

    return stringBuilder.ToString();
}
```
And voila! If everything is correct, we can now create Person objects and display information about them.
Step 7 – Create a Child
Create a Child class that inherits Person and has the same constructor definition. However, do not copy the code from the Person class - reuse the Person class’s constructor.
Sample Code
```csharp
public Child(string name, int age)
    : base(name, age)
{
}
```
There is no need to rewrite the Name and Age properties since Child inherits Person and by default has them.

Step 8 – Validate the Child’s setter
Sample Code
```csharp
public override int Age
{
    get
    {
        return base.Age;
    }

    set
    {
        //TODO validate childs age
        base.Age = value;
    }
}
```