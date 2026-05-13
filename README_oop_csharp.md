# 🖥️ Object-Oriented Programming – C# Console Applications

Academic project developed as part of the **Certificate IV in Information Technology (Programming)** at **TAFE NSW** (Sydney, Australia).

Five C# console applications demonstrating core object-oriented programming concepts including inheritance, polymorphism, arrays, file I/O and control structures.

---

## 📋 Project Overview

**Units assessed:**
- ICTPRG430 – Apply Introductory Object-Oriented Language Skills
- ICTPRG433 – Test Software Developments
- ICTPRG439 – Use Pre-Existing Components
- ICTPRG441 – Apply Skills in Object-Oriented Design

---

## 📁 Project Structure

```
OOProgramming/
├── OOProgramming.sln
├── Task1/
│   └── Program.cs         ← Mathematical expression calculator
├── Task2/
│   └── Program.cs         ← Hotel room booking cost calculator
├── Task3/
│   ├── Program.cs         ← Inheritance and polymorphism demo
│   ├── Person.cs          ← Abstract base class
│   ├── Student.cs         ← Derived class
│   └── Teacher.cs         ← Derived class
├── Task4/
│   └── Program.cs         ← File I/O character counter
└── Task5/
    └── Program.cs         ← Loop with multiple conditions
```

---

## 🔍 Tasks Overview

### Task 1 – Mathematical Expression Calculator
Console app that takes two integers and an operator from the user and displays the result in words.

```
Enter an integer value: 10
Enter an operator [Subtract - , Plus + , Multiply * or Division /]: -
Enter another integer value: 5
10 minus 5 equals 5
```

**Concepts:** `int.Parse`, `Console.ReadLine`, string interpolation, `if/else if`

---

### Task 2 – Hotel Room Booking Calculator
Uses **parallel arrays** to store room names and prices. User selects a room type and number of nights to calculate total cost.

```
1. Single $45.50 per night
2. Double $99.99 per night
3. Luxury $165.25 per night
4. Penthouse $1,095.50 per night

Please select a room type: 2
Please enter the number of nights: 3
Thank you, the total cost for staying in the Double room for 3 nights is $299.97
```

**Concepts:** Parallel arrays, `for` loop, currency formatting (`:c`)

---

### Task 3 – Inheritance and Polymorphism
Implements an inheritance hierarchy with an abstract `Person` base class and two derived classes: `Student` and `Teacher`.

```
Hi my name is Sue and I am studying Math,Science,English
Hi my name is Tim and I teach in Computer Science faculty
```

**Concepts:** Abstract classes, inheritance (`: base`), constructor overloading, polymorphism (`override`), `List<T>`, `foreach`

**Class diagram:**
```
Person (abstract)
├── Student  → PrintDetails() → name + subjects
└── Teacher  → PrintDetails() → name + faculty
```

---

### Task 4 – File I/O Character Counter
Reads a text file, counts occurrences of each alphabetic character using a `SortedDictionary`, and writes the results to an output file.

```
A 12
B 5
C 23
...
```

**Concepts:** `StreamReader`, `StreamWriter`, `SortedDictionary<char, int>`, `KeyValuePair`, `try/catch/finally`, exception handling

---

### Task 5 – Loop with Multiple Conditions
Displays numbers from 50 down to 25, labelling multiples of 3, 5, or both — using a single loop and a maximum of 4 `Console.WriteLine` calls.

```
50 [5]
49
48 [3]
47
46
45 [3 & 5]
...
```

**Concepts:** `for` loop (descending), modulo operator (`%`), nested conditions

---

## 🛠️ Technologies

- **C# (.NET Framework)**
- Visual Studio (Console Application)
- OOP principles: abstraction, inheritance, polymorphism, encapsulation
- File I/O: `StreamReader`, `StreamWriter`
- Collections: `List<T>`, `SortedDictionary<char, int>`

---

## 🎓 Context

Completed as Assessment Event 1 of 4 for OOP units of the **Certificate IV in Information Technology (Programming)** at **TAFE NSW**, Sydney, Australia (2024).

---

*Julio Cesar da Silva Filho | [LinkedIn](https://www.linkedin.com/in/julio-cesar-filho-84241842/)*
