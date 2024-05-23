---
# Collections Practice

## Stacks

### Reverse Numbers with a Stack
Write a program that reads N integers from the console and reverses them using a stack. Use the `Stack<int>` class. Just put the input numbers in the stack and pop them. Read the input from a file.

| Input| Output |
|------|-----|
|1     |5    |
|2|4|
|3|3|
|4|2|
|5|1|
</details>

### Basic Queue Operations

Play around with a queue. You will be given an integer N representing the number of elements to enqueue **(add)**, an integer **S** representing the** number of elements** to **dequeue (remove)** from the queue and finally an integer **X**, an element that you should look for in the **queue**. If it is, print **true** on the console. If it’s not print the **smallest element** currently present in the queue. If there are **no elements** in the sequence, print **0** on the console.

| Input 1| Input 2| Output | Comments |
|--------|--------|--------|----------|
|5 2 32 |1 13 45 32 4 |true    | We have to **push 5** elements. Then we **pop 2** of them. Finally, we have to check whether 13 is present in the stack. Since it is we print **true**.| 
|4 1 123 |123 69 13 420 | 13||
|3 3 90 |90 90 90 | 0| |


## Dictionary and Sets

### Phonebook

Write a program that receives some info from the console about **people** and their **phone numbers**.
As input you will get the contacts in this form `{name}-{number}`. There will be no invalid input. The name can contain every asci character with exception of the separator `{-}`.

After filling this simple phonebook, upon receiving the command **"search"**, your program should be able to perform a search of a contact by name and print her details in format `"{name} -> {number}"` until the **“end”** command is given. In case the contact isn't found, print **"Contact {name} does not exist."** 

**Input**

Vasile-0888080808
search
Maria
Vasile
end

**Output**

Contact Maria does not exist.
Vasile -> 0888080808


**Input**

Vasile-+359888001122
RoYaL(Ivan)-666
Geo-5559393
Simo-02/987665544
search
Simo
simo
RoYaL
RoYaL(Ivan)
end


**Output**

Simo -> 02/987665544
Contact simo does not exist.
Contact RoYaL does not exist.
RoYaL(Ivan) -> 666

## External Resources
[Essential Collections in C#](https://medium.com/@fairushyn/essential-collections-in-c-4ec7e90598ff)

