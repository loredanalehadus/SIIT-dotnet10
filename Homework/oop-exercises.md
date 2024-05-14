# OOP

:::tip
These problems have as a goal to model the requested functionality, but also to provide the simplest and cleanest implementations. Keep an eye on naming and data types.
:::

##  Encapsulation:	Class Box

You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: http://www.mathwords.com/r/rectangular_parallelepiped.htm).

On the first three lines you will get the length, width and height. On the next three lines print the surface area, lateral surface area and the volume of the box:

Examples

|Input	| Output |
|-------|--------|
|2      | Surface Area – 52.00 |
|3      |   Lateral Surface Area – 40.00 |
|4      |	Volume – 24.00 |

|Input	| Output |
|-------|--------|
|1.3   | Surface Area - 30.20 |
|1     | Lateral Surface Area - 27.60 |
|6	   | Volume - 7.80 |

## Interface and Abstraction: Ferrari

### Instructions
Model an application which contains a class Ferrari and an interface. 
Your task is simple, you have a car - Ferrari, its model is "488-Spider" and it has a driver. Your Ferrari should have functionality to use brakes and push the gas pedal. When the brakes are pushed down print "Brakes!", and when the gas pedal is pushed down - "Zadu6avam sA!". 

As you may have guessed this functionality is typical for all cars, so you should implement an interface to describe it. 

Your task is to create a Ferrari and set the driver's name to the passed one in the input. After that, print the info. Take a look at the Examples to understand the task better.

**Input**
On the single input line, you will be given the driver's name.

**Output**
On the single output line, print the model, the messages from the brakes and gas pedal methods and the driver's name. In the following format:
```
<model>/<brakes>/<gas pedal>/<driver's name>
```
Example
```
488-Spider/Brakes!/Zadu6avam sA!/Carlos Saintz
```


## Polymorphism: Vehicles

### Abstract class: Vehicles

Write a program that models 2 vehicles (`Car` and `Truck`) and simulates driving and refueling them. Car and truck both have **fuel quantity**, **fuel consumption** in liters per km and **can be driven a given distance** and **refueled with a given amount of fuel**. 

It’s summer, so both vehicles use air conditioners and their fuel consumption per km is **increased by 0.9 liters for the car** and with **1.6 liters for the truck**. Also, the truck has a tiny hole in its tank and when **its refueled it keeps only 95%** of the given fuel. The car has no problems and adds all the given fuel to its tank. If a vehicle cannot travel the given distance, its fuel does not change.

**Input**
* On the first line – information about the car in the format: `"Car {fuel quantity} {liters per km}"`
* On the second line – info about the truck in the format: `"Truck {fuel quantity} {liters per km}"`
* On the third line – the number of commands N that will be given on the next N lines
* On the next N lines – commands in the format:
    * `"Drive Car {distance}"`
    * `"Drive Truck {distance}"`
    * `"Refuel Car {liters}"`
    * `"Refuel Truck {liters}"`


**Output**
* After each Drive command, if there was enough fuel, print on the console a message in the format:
  * `"Car/Truck travelled {distance} km" `  
* If there was not enough fuel, print: `"Car/Truck needs refueling"`
* After the End command, print the remaining fuel for both the car and the truck, rounded to 2 digits after the floating point in the format:
  * `Car: {liters}" `
  * `"Truck: {liters}"`


**Examples**

**Input1**
```
Car 15 0.3
Truck 100 0.9
4
Drive Car 9
Drive Car 30
Refuel Car 50
Drive Truck 10
```

**Output1**
```
Car travelled 9 km
Car needs refueling
Truck travelled 10 km
Car: 54.20
Truck: 75.00
```

**Input 2**
```
Car 30.4 0.4
Truck 99.34 0.9
5
Drive Car 500
Drive Car 13.5
Refuel Truck 10.300
Drive Truck 56.2
Refuel Car 100.2
```

**Output2**
```
Car needs refueling
Car travelled 13.5 km
Truck needs refueling
Car: 113.05
Truck: 109.13
```

## Inheritance exercise: Person
<details>
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
</details>

## 1.
Make an application where to model a animals keeping in mind that:

any kind you model is an animal
any animal has a name
there are multiple animal categories like : mammals, fish, birds, reptile, insects
no matter the category, animal are : flying, walking, swim or crawl.
depending on the way they move, they have a maximum speed.
there are animals that can swim and walk (Platypus)
there are animals that can swim, fly and walk (Wild Duck)
Not any animal that can fly is a bird, the bat is a mammal that flys, and not evey bird flys - the ostrich is a bird but doesn't fly

## 2. 

Model the Product class knowing that:

* a product has a weight
* has a name
* a production date
* an expiration date
* it has a producer
* and it can be in one of categories : Dairy, Fruit, Beverages, Bread
* we also knoow that it expires differently based on the category it belongs to:
    * fruits expire in 2 days
    * beverages expire in 3 years
    * dairy expire in 1 week
    * bread expires in 4 days

## BankAccount
Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.

It should be possible to close an account; operations against a closed account must fail.

Remember you are working with money so you should use an appropriate data type for it.

Now you're asked to implement an economy account. We know that an economy account is similar to a normal bank account, but on each deposit gives you 0.01% extra to the deposited sum, and on withdrawals takes 0.02% from the withdrawed amount.

* Now you want to have a secret account from where you are buying wine or purses. When you make deposits , the deposit is made in an normal account. You can't make withdrawals in october.
* Now you need to introduce a new account called GameAccount, that you will use online. This account can't make withdrawals, only deposits
-Since you have so many types of accounts, with different purposes, you need to find a way to extract the common behavior