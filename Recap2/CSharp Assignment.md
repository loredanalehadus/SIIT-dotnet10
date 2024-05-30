# C# Workshop Assignment

## Project Overview

Create a **Student Management System** where students can be enrolled in courses and assigned to teachers. The system should demonstrate the use of:
- primitive data types
- working with strings
- OOP concepts (inheritance, encapsulation, interfaces, abstract classes and polymorphism)
- generic classes and methods
- exception handling
- validation
- using anonymous types
- defining extension methods
- working with collections
- building queries using lambda expressions and LINQ.

## Duration
2 hours

## Instructions

### Part 1, individual work, 30 min

1. **Project Setup**: Create a new Console Application project in Visual Studio named `StudentManagementSystem`.

2. **Define Classes and Interfaces:**

a.  **Person Class (Abstract):**
- Properties: `Name` (string), `Age` (int) with validation 
  - Name should **not be null**
  - Age should be **between 18 and 99**
- Constructor to initialize `Name` and `Age` 
- Abstract method: `GetDetails()`
  
b. **Student Class (Inherits Person):**
- Additional Properties: `Grade` (int), `Address` (string)
- Constructor to initialize `Name`, `Age`, `Grade`, and `Address`
- Override `GetDetails()` to return student details

c. **Teacher Class (Inherits Person):**

- Additional Properties: `Email` (string), `PhoneNumber` (string)
- Constructor to initialize `Name`, `Age`, `Email`, and `PhoneNumber`
- Override `GetDetails()` to return teacher details

d. **IEnrollable Interface:**

- Method: `Enroll(Student student)`

e. **Course Class:**

- Implements `IEnrollable` interface
- Properties: `CourseID` (int), `Name` (string), `Duration` (int), `Teacher` (Teacher), `EnrolledStudents` (`List<Student>`)
- Constructor to initialize `CourseID`, `Name`, `Duration`, and `Teacher`
- Method: `Enroll(Student student)` to enroll a student
  
### Part 2, teamwork in teams of 2-3 people, 45 min

3. **Implement Generic Classes and Methods:**

a. Generic `Repository<T>` class
- Create a generic class called `Repository<T>` to manage collections of students, teachers, and courses.
- Should implement `IEnumerable<T>` with the constraint that T should be `IComparable<T>`
- fields: items (`List<T>`)
- methods: `Add(T item)` to add items to the list, `GetAll()` to return all items from the list, `Contains(T item)` to return if an item exists in the collection, `Remove(int index)` to remove an item from collection

b. **StudentManagement Class:**

- Methods to add students, teachers, courses, and enroll students
- Method to display students in a course
- Method to display courses for a student
- Methods to find students, courses, and teachers using LINQ queries

4. **Exception Handling and Validation:**

- Add validation to properties in `Person` class.
- Implement custom exceptions for validation failures.

5. **Extension Methods:**

- Create an extension method for `List<Student>` to filter students by grade.
- Create an extension method for `List<Student>` to filter students by age.
- Create an extension method for `List<Student>` to find a student by name.

6. **Anonymous Types:**

- Use anonymous types to create a report of students with their course names.