// See https://aka.ms/new-console-template for more information
/*using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Sockets;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;*/

// Console.WriteLine("Hello, World!");


// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
*/

// 1. Ask the user their name and print Hello, <name>.

/*string name;
Console.WriteLine("Enter your name");
name = Console.ReadLine();
Console.WriteLine($"Hello {name}");*/

// 2. Ask name and age together, print: <name> is <age> years old.

/*string name;
Console.WriteLine("Enter your name ");
name = Console.ReadLine();
 int age ;
Console.WriteLine("Enter your age");
age = int.Parse(Console.ReadLine());
Console.WriteLine($"Name {name}  Age {age}");*/

// 3. Take roll number (int) and section (string), print both.

/*int rollnumber;
Console.WriteLine("Enter your roll number");
rollnumber =int.Parse(Console.ReadLine());
string section;
Console.WriteLine("Enter your section");
section = Console.ReadLine();
Console.WriteLine($"Roll no. {rollnumber}, Section {section}");
*/

// 4. Ask for student name, roll number, and age — print an ID-card style output (3 lines).

/*string name;
Console.WriteLine("Enter your name ");
name = Console.ReadLine();
int rollnumber;
Console.WriteLine("Enter your roll number");
rollnumber =int.Parse(Console.ReadLine());
int age;
Console.WriteLine("Enter your age");
age =int.Parse(Console.ReadLine());

Console.WriteLine($"Name {name}");

Console.WriteLine($"Roll number {rollnumber}");

Console.WriteLine($"Age {age}");*/

// 5.Take product name (string) and price (int), print <product> costs <price> rupees.

/*string name;
Console.WriteLine("Enter Product Name");
name = Console.ReadLine();
int price;
Console.WriteLine("Enter price");
price = int.Parse(Console.ReadLine());
Console.WriteLine($"Product {name} Ruppes{price}");*/

// 6. Take book title (string) and number of pages (int), print both.

/*string name;
Console.WriteLine("Enter Book Title");
name = Console.ReadLine();
int page;
Console.WriteLine("Enter Page No.");
page = int.Parse(Console.ReadLine());
Console.WriteLine($"Book Title {name} No of Pages {page}");*/

//  7. Ask name, age, and city — print in this order: city, name, age.

/*string name;
Console.WriteLine("Enter your name");
name = Console.ReadLine();
int age;
Console.WriteLine("Enter your Age");
age = int.Parse(Console.ReadLine());

string city;
Console.WriteLine("Enter your City");
city = Console.ReadLine();

Console.WriteLine($"City {city}");

Console.WriteLine($"Name {name}");

Console.WriteLine($"Age {age}");

*/

// 8. Ask for day, month, year (three ints), print as <day>-<month>-<year>.

/*string day;
Console.WriteLine("Enter Day");
day = Console.ReadLine();

string month;
Console.WriteLine("Enter Month");
month = Console.ReadLine();

int year;
Console.WriteLine("Enter year");
year = int.Parse(Console.ReadLine());
Console.WriteLine($" <{day}> <{month}><{year}>");*/

// 9. Ask for a username (string) and a PIN (int), print a login confirmation line.

/*string username;
Console.WriteLine("Enter username");
username = Console.ReadLine();

int pin;
Console.WriteLine("Enter pin");
pin = int.Parse(Console.ReadLine());

Console.WriteLine("login successful");*/

// 10. Take school name (string), total students (int), total teachers (int) — print a 3-line summary.

/*using System.ComponentModel.Design;

string school;
Console.WriteLine("Enter school name");
school = Console.ReadLine();

int student;
Console.WriteLine(" Enter total student");
student = int.Parse(Console.ReadLine());

int teacher;
Console.WriteLine(" Total teacher");
teacher = int.Parse(Console.ReadLine());

Console.WriteLine($"school name {school}");
Console.WriteLine($"Total student {student}");
Console.WriteLine($"Total Teacher {teacher}");
*/


// partb 

// 1. Take two numbers and print their sum.

/*int value1, value2, result;
Console.WriteLine("enter value 1");
value1=int.Parse(Console.ReadLine());
Console.WriteLine("enter value 2");
value2 =int.Parse(Console.ReadLine());
result = value1 + value2;
Console.WriteLine($"result{result}");*/


// 2. Take two numbers and print their difference (first minus second).


/*
int value1, value2, result;
Console.WriteLine("enter value 1");
value1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter value 2");
value2 = int.Parse(Console.ReadLine());
result = value1 - value2;
Console.WriteLine($"result{result}");*/

// 3. Take two numbers and print their product (multiplication).

/*int value1, value2, result;
Console.WriteLine("enter value 1");
value1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter value 2");
value2 = int.Parse(Console.ReadLine());
result = value1 * value2;
Console.WriteLine($"result{result}");*/

// 4.Take two numbers and print the result of division (first divided by second).

/*int value1, value2, result;
Console.WriteLine("enter value 1");
value1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter value 2");
value2 = int.Parse(Console.ReadLine());
result = value1 / value2;
Console.WriteLine($"result{result}");*/

// 5. Take two numbers and print the remainder using %.

/*int value1, value2, result;
Console.WriteLine("enter value 1");
value1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter value 2");
value2 = int.Parse(Console.ReadLine());
result = value1 % value2;
Console.WriteLine($"result{result}");*/

// 6. Take a student's name and two subject marks, print the name and the total marks.

/*string name;
int marks1 ,marks2,total;
Console.WriteLine("Student Name");
name = Console.ReadLine();


Console.WriteLine("subject 1 marks");
marks1 =int.Parse(Console.ReadLine());
Console.WriteLine("subject 2 marks");
marks2=int.Parse(Console.ReadLine());

total = marks1 + marks2;

Console.WriteLine($"Name {name} total marks {total}");*/

// 7. Take three subject marks and print their sum.


/*int marks1, marks2,marks3, total;

Console.WriteLine("subject 1 marks");
marks1 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 2 marks");
marks2 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 3 marks");
marks3 = int.Parse(Console.ReadLine());

total = marks1 + marks2 + marks3;

Console.WriteLine($" total marks {total}");*/

// 8. Take a price (int) and a quantity (int), print the total cost (price × quantity).


/*int price, quantity, total;


Console.WriteLine("Price");
price = int.Parse(Console.ReadLine());
Console.WriteLine("Quantity");
quantity = int.Parse(Console.ReadLine());

total = price*quantity;

Console.WriteLine($"total  {total}");*/

// 9. Take the current year and a birth year, print the age (subtraction).

/*int currentyear, birthyear ,age;

Console.WriteLine("Enter current year");
currentyear = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Birth year");
birthyear = int.Parse(Console.ReadLine());

age = currentyear - birthyear;
Console.WriteLine($" Age{age}");*/


// 10. Take five subject marks, print the total, then print the average (total ÷ 5).

/*int marks1, marks2, marks3,marks4,marks5, total,average;

Console.WriteLine("subject 1 marks");
marks1 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 2 marks");
marks2 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 3 marks");
marks3 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 4 marks");
marks4 = int.Parse(Console.ReadLine());
Console.WriteLine("subject 5 marks");
marks5 = int.Parse(Console.ReadLine());



total = marks1 + marks2 + marks3 + marks4 + marks5 ;

Console.WriteLine($" total marks {total}");

average = total/5 ;

Console.WriteLine($" Average {average}");*/





//  1. Ask the user's height in feet (double) and print Your height is <height> feet.

/*double height;
Console.WriteLine("Height");
height = double.Parse(Console.ReadLine());
Console.WriteLine($"height {height} feet");*/


// 2. Ask name (string), age (int), and weight (double) — print all three lines.

/*string name;
int age;
double weight;
Console.WriteLine("Name"); 
name = Console.ReadLine();
Console.WriteLine("Age");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Weight");
weight = int.Parse(Console.ReadLine());
Console.WriteLine($"Name is {name}");
Console.WriteLine($"Age {age} ");
Console.WriteLine($"Weight {weight}"); */


// 3. Ask for a grade letter (char) and print Your grade is <grade>.

/*char grade;
Console.WriteLine("Grade");
grade = char.Parse(Console.ReadLine());
Console.WriteLine($"Grade Letter {grade}");
*/


// 4. Ask a yes-question stored in a bool (e.g. "Do you play cricket? type true or false") and print it back.

/*bool cricket;

Console.WriteLine("Do you play cricket? true or false");
cricket = bool.Parse(Console.ReadLine());
Console.WriteLine($"{cricket}");*/

// 5. Ask for the price of a pen (decimal) and print A pen costs <price> rupees.
/*
decimal price;
Console.WriteLine("Price of pen ?");
price =decimal.Parse(Console.ReadLine());
Console.WriteLine($"pen price Rs.{price}");*/

// 6. Store your country's population in a long (in code, no input) and print it.

/*long population = 1476625576;
Console.WriteLine($"india's population {population}");*/

// 7. Ask student name (string), grade (char), percentage (double) — print a 3-line report card.

/*
string name;
char grade;
double percentage;
Console.WriteLine("Name");
name = Console.ReadLine();
Console.WriteLine("Grade");
grade = char.Parse(Console.ReadLine());
Console.WriteLine("percentage");
percentage = double.Parse(Console.ReadLine());
Console.WriteLine($"Name {name}");
Console.WriteLine($"Grade {grade}");
Console.WriteLine($"Percentage {percentage}");*/


// 8. Ask for two double numbers and print their division result (check: is the decimal kept?).


// 9. Ask temperature (double) and print Today it is <temp> degrees.

/*double temperature;
Console.WriteLine("Today's temperature");
temperature = double.Parse(Console.ReadLine());
Console.WriteLine($"Today's temperature {temperature}");*/

// 10. Make an ID card: name (string), roll no (int), section (char), fee paid (bool) — print 4 lines.

/*
string name;
int rollno;
char section;
bool fee;
Console.WriteLine("Name");
name = Console.ReadLine();
Console.WriteLine("Roll no");
rollno = int.Parse(Console.ReadLine());
Console.WriteLine("Section");
section = char.Parse(Console.ReadLine());
Console.WriteLine("Fees TRUE OR FALSE");
fee = bool.Parse(Console.ReadLine());

Console.WriteLine($"Name {name}");
Console.WriteLine($"Roll no {rollno}");
Console.WriteLine($"Section {section}");
Console.WriteLine($"Fees {fee}");*/




// PART2



// 11. Take marks of 3 subjects (double) — print total and average (average must keep decimals).

/*double subject1, subject2, subject3 ,total;
decimal average;

Console.WriteLine("Subject 1 marks");
subject1 = double.Parse(Console.ReadLine());

Console.WriteLine("Subject 2 marks");
subject2 = double.Parse(Console.ReadLine());

Console.WriteLine("Subject 3 marks");
subject3 = double.Parse(Console.ReadLine());

total = subject1 + subject2 + subject3;

average = Convert.ToDecimal(total/3);
Console.WriteLine($"Total {total}");

Console.WriteLine($"Average {average}");*/




// 12. Take Celsius temperature (double) — convert to Fahrenheit: (c * 9 / 5) + 32.

/*double temperature;
double fahrenheit;

Console.WriteLine(" Celsius Temperature ");
temperature = double.Parse(Console.ReadLine());

temperature = Convert.ToDouble((temperature*9/5)+32);

Console.WriteLine($" Fahrenheit {temperature}");*/



// 13. Take radius of a circle (double) — print area: 3.14 * radius * radius.

/*double radius , area;


Console.WriteLine("Circle Radius");
radius = double.Parse(Console.ReadLine());

area = Convert.ToDouble(3.14*radius*radius);

Console.WriteLine($"Area {area}");*/



// 14. Take length and width of a room (double) — print the area.
/*
double length, width ,area;
Console.WriteLine("length");
length = double.Parse(Console.ReadLine());

Console.WriteLine("width");
width= double.Parse(Console.ReadLine());

area = Convert.ToDouble(length*width);

Console.WriteLine($"Area {area}");*/



// 15. Take a price (decimal) and quantity (int) — print a small bill 
/*
decimal price;
int quantity;

Console.WriteLine("Price");
price = decimal.Parse(Console.ReadLine());

Console.WriteLine("quantity");
quantity = int.Parse(Console.ReadLine());

Console.WriteLine($" Price {price} | Quantity {quantity}");
*/



// 16. Take a 2-digit number (int) — print the tens digit and ones digit using / and %.
/*
using System;

int number;
Console.WriteLine("Take a 2-digit number");
number = int.Parse(Console.ReadLine());

int tens = number / 10;   
int ones = number % 10;  

Console.WriteLine("Tens digit = " + tens);
Console.WriteLine("Ones digit = " + ones);
*/

// use chatgpt in 16 question



// 17. Take total minutes (int) — print as hours and minutes(130 → 2 hours 10 minutes). Hint: / 60 and % 60.
/*
int minutes;
Console.WriteLine("total minutes");
minutes = int.Parse(Console.ReadLine());

int  hours = minutes / 60 ;
int minute = minutes % 60 ;

Console.WriteLine($"{hours} {minute}");*/



// 18. Take an amount in rupees (int) — print how many 100-rupee notes and how much is left over.
/*
int amount;

Console.Write("Enter the amount in rupees: ");
amount = int.Parse(Console.ReadLine());

int notes = amount / 100;     
int remaining = amount % 100;  

Console.WriteLine("100-rupee notes = " + notes);
Console.WriteLine("Remaining amount = ₹" + remaining);
*/


// help chatgpt




// 19. Take principal, rate, and years (double) — print simple interest: (p * r * t) / 100.

/*
double principal, rate, years , interest;

Console.WriteLine(" Principle");
principal = double.Parse(Console.ReadLine());

Console.WriteLine("Rate");
rate = double.Parse(Console.ReadLine());

Console.WriteLine("Years");
years = double.Parse(Console.ReadLine());

interest = (principal*rate*years )/100;

Console.WriteLine($" Interest {interest}");   
*/



// 20. Take marks of 5 subjects (double) — print total, average, and percentage (out of 500).

/*
double subject1, subject2, subject3,subject4,subject5, total , average, percentage;

Console.WriteLine("Subject 1 marks");
subject1 = double.Parse(Console.ReadLine());

Console.WriteLine("Subject 2 marks");
subject2 = double.Parse(Console.ReadLine());

Console.WriteLine("Subject 3 marks");
subject3 = double.Parse(Console.ReadLine());


Console.WriteLine("Subject 4 marks");
subject4 = double.Parse(Console.ReadLine());


Console.WriteLine("Subject 5 marks");
subject5 = double.Parse(Console.ReadLine());


total = subject1 + subject2 + subject3 +subject4 + subject5;
average = total / 5;
percentage = total / 500;



Console.WriteLine($"Total {total}");
Console.WriteLine($"Average {average}");
Console.WriteLine($"Percentage {percentage}");

*/



// Part 1 Check if a number is positive  Input: 5  Output: Positive number


/*int marks;
Console.WriteLine("Please Enter Marks");
marks = Convert.ToInt32(Console.ReadLine());
if (marks >= 33)
{
    //true block
    Console.WriteLine("Pass");
    Console.WriteLine("Time to Start Party");
}
else
{
    //false block
    Console.WriteLine("Fail");
    Console.WriteLine("Time To Re Start");
}*/
/*
int number;
Console.WriteLine("Enter number");
number = int.Parse(Console.ReadLine());

if
    (number >=0)
{
    Console.WriteLine("positive number");
}*/

// 2. Check if a number is negative  

/*int number;
Console.WriteLine("Enter number");
number = int.Parse(Console.ReadLine());

if
    (number <= 0)
{
    Console.WriteLine("negative number");
}
*/


// 3. Check if a number is even  

/*int number;
Console.WriteLine("enter number");
number = int.Parse(Console.ReadLine());

if (number % 2 ==0)

{
    Console.WriteLine("even number");
}
*/

// 4. Check if a number is odd  
/*
int number;
Console.WriteLine("enter number");
number = int.Parse(Console.ReadLine());

if (number % 2 != 0)

{
    Console.WriteLine("odd number");
}*/


// 5. Check if a number is zero  
/*
int number;
Console.WriteLine("enter  zero number");
number = int.Parse(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine(" number is zero");
}
else if (number != 0)
{
    Console.WriteLine(" number is not zero");


}
*/


// 6. Check if a string is empty  

/*string str;
Console.WriteLine("enter a string");
str = Console.ReadLine();

if ( str == " " )
{
    Console.WriteLine(" string is empty");
}
else ( str != "")
{
    Console.WriteLine(" string is not empty");
}
*/


// 7, Check if an entered password is correct  

/*string password = "admin123";

Console.WriteLine("enter password");
password = Console.ReadLine();

if (password == "admin123")
{
    Console.WriteLine("access granted");
}
else if (password != "admin123")
{
    Console.WriteLine(" failed");
}*/

// 8. Check if a student passed (minimum 40 marks)  

/*int marks;
Console.WriteLine("Please Enter Marks");
marks = Convert.ToInt32(Console.ReadLine());
if (marks >= 40)
{
    Console.WriteLine("Pass");
}

if (marks < 40)
{
    Console.WriteLine("Fail");
}*/


// 9. Check if an employee worked overtime (more than 60 hours)  

/*int time;
Console.WriteLine(" enter work hours");
time = int.Parse(Console.ReadLine());

if (time >= 60)

{
    Console.WriteLine("Overtime Done");
}

else 
{
    Console.WriteLine("Overtime not Done");
}*/

// 10. Check if a number is greater than 100  
/*
int number;
Console.WriteLine("enter number");
number = int.Parse(Console.ReadLine());

if (number > 100)
{
    Console.WriteLine(" number is greater than 100  ");
}
else
{
    Console.WriteLine("number is not greater than 100  ");
}*/


// 12. Check if a number is less than 50  

/*
int number;
Console.WriteLine("enter number");
number = int.Parse(Console.ReadLine());

if (number < 50)
{
    Console.WriteLine(" number is less than 50  ");
}
else
{
    Console.WriteLine("number is  greater than 50  ");
}*/


// 13. Check if a person is eligible to vote (age 18 or above)  

/*
int age;
Console.WriteLine("enter your age");
age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine(" Eligible to Vote  ");
}
else
{
    Console.WriteLine(" Not Eligible to Vote  ");
}

*/


// 14. Check if a person is a minor (age below 18)  


/*
int age;
Console.WriteLine("enter your age");
age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine(" Minor  ");
}
else
{
    Console.WriteLine(" Adult  ");
}

*/


// 15. Check if a number is a multiple of 7  


/*
int number;
Console.WriteLine("enter number");
number = int.Parse(Console.ReadLine());

if (number %7 == 0)
{
    Console.WriteLine("  Multiple of 7  ");
}
else
{
    Console.WriteLine(" Not Multiple of 7 ");
}
*/


// 16. Check if a username is correct  
/*
string user;

Console.WriteLine("enter username");
user = Console.ReadLine();

if (user == "student")

{
    Console.WriteLine("Valid Username ");
}

else
{
    Console.WriteLine("Invalid Username ");
}



*/

// 17. Check if a temperature is above 37°C  
/*
int temp;
Console.WriteLine("enter temperature");
temp = int.Parse(Console.ReadLine());

if (temp >= 37 )

{
    Console.WriteLine("High Temperature");
}
else
{
    Console.WriteLine(" Below HIgh Temperature  ");
}

*/


// 18. Check if a shopping cart has at least one item  

/*int cart;
Console.WriteLine(" enter item in cart");
cart = int.Parse(Console.ReadLine());

if (cart > 0)
{
    Console.WriteLine(" Cart is not Empty  ");
}
else
{
    Console.WriteLine(" Cart is  Empty  ");
}*/


// 19. Check if a person's height is at least 150 cm  
/*
int height;
Console.WriteLine(" enter your height in cm");
height = int.Parse(Console.ReadLine());

if (height >= 150)
{
    Console.WriteLine("Eligible ");
}

else
{
    Console.WriteLine("Not Eligible");
}*/
























// Nested If Assignments 

// ✅ 1. Check if a person is eligible to vote. 

// Write a C# program to check if a person is eligible to vote. A person is eligible to vote if their age is 18 or above and they have a valid voter ID (hasID = true).
/*
Console.WriteLine("enter age");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" you have valid voter id : True or False");
Boolen hasID = Convert.ToBoolen(Console.ReadLine());

if (age >= 18)


{ if (hadID)
    {
        Console.WriteLine(" eligible to vote ")
    }
else
    {
        Console.Writeline(" not eligible to vote")
    }

}
else
{
    Console.WriteLine("not  eligible to vote")
}



*/



// ✅ 2.Verify login credentials. 

// Write a C# program to verify login credentials. The user is granted access only if the username is "admin" and the password is "1234".


/*

Console.Writeline("Enter your password")
    string username = Console.ReadLine();

Console.Writeline("Enter your password")
string password = Console.ReadLine();

if (username == "admin")
{
    if (password == "123")
    { Console.WriteLine("Access")}
    else
    {
        Console.WriteLine("wrong password");
    }

}
else
{
    Console.WriteLine("invalid username")
}

*/


// ✅ 3. Check if a number is positive and even. 

// Write a C# program to check if a number is both positive and even. 

/*
Console.Writeline("enter number")
    int number = Convert.ToInt32(Console.Readline());



if (number > 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("number is positive and even")
    }
    else
    {
        Console.Writeline(" number is positive and odd")
    }
}
else
{
    Console.WriteLine("number is not positive")
}
 

*/


//  4. Check if a student passed with excellence. 
//Write a C# program to check if a student has passed and scored above 90 marks. 

/*Console.Writeline("Student pass : True or false:-")
 Boolen passed   = Convert.InBoolen(Console.Readline());

Console.Writeline("enter your marks")
    int marks = Convert.ToInt32(Console.Readline());

if (passed)
{
    if ( marks > 90)
    {
        Console.WriteLine("Excellent result")

    }
    else
    {
        Console.Writeline("Passed, but not excellent.")
    }
}
*/

//  5. Check for government job eligibility. 


// Write a C# program to check if a person is eligible for a government job. The person must be a citizen (isCitizen = true) and at least 18 years old. 

/*Console.Writeline("Are you a citizen : True or false:-")
 Boolen isCitizen = Convert.InBoolen(Console.Readline());
{


    if (isCitizen)
    { 
        if (age >= 18)
    {
        { Console.WriteLine("Eligible for government job.")
                }
    else
        {
            Console.WriteLine(" Not eligible due to citizenship")
    }
    }
}
else
{
    Console.WriteLine("Not eligible due to citizenship")
}*/



//✅ 6. Check divisibility by 3 and 5. 

/*Console.Writeline("enter a number ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 3 ==0)
{
    if (number  % 5 == 0)
    {
        Console.WriteLine("Divisible by both 3 and 5.")
    }
    else
    {
        Console.Writeline("Not divisible by both 3 and 5.")
    }
}

*/


// ✅ 7. Check admin delete permissions. 

// Write a C# program to check if a user is an admin and has permission to delete records

/*
Console.WriteLine("enter role ");
string role = Console.ReadLine();

Console.WriteLine("Can delete? (true/false): ");
Boolean canDelete = Convert.ToBoolean(Console.ReadLine());

if (role == "admin" && canDelete) 
{
    Console.WriteLine("You can delete records.");
}
else if (role == "admin" && !canDelete)
{
    Console.WriteLine("You are admin, but deletion is not allowed");
}
else
{
    Console.WriteLine("You are not authorized to delete records.");
}
*/


// ✅ 8. Check subscription access. 

// Write a C# program to check if a user is registered and has a paid subscription. Access is granted only if both conditions are true. isRegistered = true, hasPaid = true → Output: "Access granted to premium content." 

//Example 1: Input → 

//Example 2: Input → isRegistered = true, hasPaid = false → Output: 1 "Please complete your subscription."
/*
Boolean isRegistered ,hasPaid;

Console.WriteLine("is registered?  (true/false)");
isRegistered = Boolean.Parse(Console.ReadLine());

Console.WriteLine("has paid subscription ");
hasPaid = Boolean.Parse(Console.ReadLine());

if (isRegistered & hasPaid) 
{
    Console.WriteLine("acces granted to premium content");
}
else if (isRegistered && !hasPaid) 
{
    Console.WriteLine("please complete your subscription");
}
else
{
    Console.WriteLine("please register first");
}*/

//✅ 9.Find the largest of three numbers. 

//Write a C# program to find the largest number among four given numbers. 

//Example 1: Input → a = 10, b = 25, c = 15, d = 5 → Output: "Largest number is 25."

//Example 2: Input → a = 40, b = 12, c = 8, d = 18 → Output: "Largest number is 40." 

/*
int a,b,c,d;

Console.WriteLine("enter first number");
a = int.Parse(Console.ReadLine());

Console.WriteLine("enter second number");
b = int.Parse(Console.ReadLine());

Console.WriteLine("enter third number");
c = int.Parse(Console.ReadLine());

Console.WriteLine("enter fourth number");
d = int.Parse(Console.ReadLine());

if (a >= b && a >= c && a >= d) 
{
    Console.WriteLine($"largest number is {a}");
}


else if (b >= a && b >= c && b >= d) 
{
    Console.WriteLine($"largest number is {b}");
}


else if (c >= b && c >= a && c >= d) 
{
    Console.WriteLine($"largest number is {c}");
}


else if (d >= b && d >= c && d >= a) 
{
    Console.WriteLine($"largest number is {d}");
}
*/


// ✅ 10. Check if a year is a leap year and divisible by 400. 

//Write a C# program to check if a year is a leap year and also divisible by 400. 

//Example 1: Input → year = 2000 → Output: "Leap year and divisible by 400."

//Example 2: Input → year = 2020 → Output: "Leap year but not divisible by 400."
//

/*
int year;

Console.WriteLine("enter year");
year = int.Parse(Console.ReadLine());

if (year % 400 == 0 && year % 4 == 0)
{
    if (year % 400 == 0)
    {
        Console.WriteLine("Leap year and divisible by 400. ");
    }
    else if(year %4==0)
    {
        Console.WriteLine("Leap year but not divisible by 400");
    }
}
else
{
    Console.WriteLine("not leap year");

}*/

// not working




/*✅ 11.Check if a person can apply for a driver's license. 

A person can apply if they are 18 or older and have passed the learner’s test. 

Example 1: Input → age = 19, passedTest = true → Output: "You can apply for a license."

Example 2: Input → age = 17, passedTest = true → Output: "You are not old enough." */


/*int age;
Boolean passedTest;

Console.WriteLine("enter your age");
age = int.Parse(Console.ReadLine());

Console.WriteLine("test passed (true/false)");
passedTest = Boolean.Parse(Console.ReadLine());

if (age >=18 &&  passedTest == true)
{
    Console.WriteLine("You can apply for a license.");
}
else if (age <18 && passedTest == true)
{
    Console.WriteLine("You are not old enough.");
}
else
{
    Console.WriteLine(" not eligible");
}*/

/*
✅ 12.Check if a triangle is equilateral.

Write a program that checks if all three sides of a triangle are equal. 

Example 1: Input → a = 5, b = 5, c = 5 → Output: "Equilateral triangle."

Example 2: Input → a = 5, b = 5, c = 6 → Output: "Not an equilateral triangle." */
/*

int a, b, c;

Console.WriteLine("enter a of triangle");
a = int.Parse(Console.ReadLine());


Console.WriteLine("enter b of triangle");
b = int.Parse(Console.ReadLine());


Console.WriteLine("enter c of triangle");
c = int.Parse(Console.ReadLine());

if (a == b && b == c && a==c)
{
    Console.WriteLine("Equilateral triangle.");
}

else
{
    Console.WriteLine("Not an equilateral triangle.");
}*/
/*

✅ 13.Check if a person qualifies for a scholarship. 

A person qualifies if their percentage is 85 or more and they come from a rural area.

Example 1: Input → percentage = 90, isRural = true → Output: "Scholarship granted."

Example 2: Input → percentage = 90, isRural = false → Output: "No scholarship due to location."*/


/*

int percentage;
Boolean rural;

Console.WriteLine("enter your percentage");
percentage = int.Parse(Console.ReadLine());

Console.WriteLine("from rural area (true/false)");
rural = Boolean.Parse(Console.ReadLine());

if (percentage >=90 &&  rural == true)
{
    Console.WriteLine("Scholarship granted.");
}
else if (percentage >= 90 && rural == false)
{
    Console.WriteLine("No scholarship due to location.");
}
else
{
    Console.WriteLine(" not eligible");
}*/

/*

✅ 14.Check if a number is a three - digit even number. 

Write a program that checks if a number is three digits and even. 

Example 1: Input → num = 128 → Output: "Three-digit even number."

Example 2: Input → num = 12 → Output: "not three-digit and not even."

Example 3: Input à num = 1237 → Output: "Not Three-digit and not even."

*/

/*
int num;

Console.Write("Enter a number: ");
num = int.Parse(Console.ReadLine());

if (num >= 100 && num <= 999 && num % 2 == 0)
{
    Console.WriteLine("Three-digit even number.");
}
else
{
    Console.WriteLine("Not three-digit and not even.");
}
*/






















// four question by vikas sir

// 1
/*
Gaming Level Unlock — Read player score and boss-defeated flag (y/n).
Score ≥ 1000: boss defeated → "Level 3 unlocked", else "Defeat the boss first". Score < 1000 → "Score too low"*/
/*
int score;
Boolean boss;


Console.WriteLine("enter score");
score = int.Parse(Console.ReadLine());

Console.WriteLine(" boss-defeated flag (true/false)");
boss = bool.Parse(Console.ReadLine());

if ( score >= 1000 && boss == true)
{
    Console.WriteLine("Level 3 unlocked");
}
else if ( score < 1000 && boss == true)
{

    Console.WriteLine("score is low");
}
*/


//2
/*
AC Auto Mode — Read room temperature and humidity. Temp > 30: humidity > 70 → "Cool + Dry mode",
    else → "Cool mode".Temp 24–30 → "Fan mode".Below 24 → "AC off".*/
/*
int temp, humidity;


Console.WriteLine("enter temperature");
temp = int.Parse(Console.ReadLine());

Console.WriteLine("enter humidity");
humidity= int.Parse(Console.ReadLine());

if (temp > 30 && humidity > 70)
{
    Console.WriteLine("Cool + Dry mode");
}
else if ( temp >=24  && temp <=30 )
{
    Console.WriteLine("Fan mode");
}
else if ( temp < 24 )
{
    Console.WriteLine(" ac off");
}
else
{
    Console.WriteLine(" cool mode");
}*/



//3


/*
Traffic Fine — Read the vehicle's speed and whether the driver is a repeat offender (y/n).
    Limit is 60. Over the limit by more than 20: repeat → ₹5000, first-time → ₹2000. 
    Over by up to 20: ₹1000. Within limit → no fine.*/

/*
int speed;
char repeat;

Console.Write("Enter vehicle speed: ");
speed= int.Parse(Console.ReadLine());

Console.Write("Is the driver a repeat offender? (y/n): ");
repeat = char.Parse(Console.ReadLine());

if (speed <= 60)
{
    Console.WriteLine("No fine.");
}
else if (speed > 80)
{
    if (repeat == 'y' || repeat == 'Y')
    {
        Console.WriteLine("Fine = ₹5000");
    }
    else
    {
        Console.WriteLine("Fine = ₹2000");
    }
}
else
{
    Console.WriteLine("Fine = ₹1000");
}
    */



/*// 4
Movie Ticket Kiosk — Read age and show time (hour, 0–23). If age< 18: show after 22 → "Not allowed",
else child price ₹120. If age ≥ 60 → senior price ₹100. Everyone else → ₹200.*/


/*int age, showTime;


Console.Write("Enter age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Enter show time (0-23): ");
showTime = int.Parse(Console.ReadLine());


if (age < 18)
{
    if (showTime > 22)
    {
        Console.WriteLine("Not allowed.");
    }
    else
    {
        Console.WriteLine("Child ticket price = ₹120");
    }
}
else if (age >= 60)
{
    Console.WriteLine("Senior ticket price = ₹100");
}
else
{
    Console.WriteLine("Ticket price = ₹200");
}*/


























/*  1 

Elevator Overload — Read the number of people and total weight (kg). 
If weight > 680, print "Overload! Please step out.", otherwise "Doors closing."*/

/*
int weight;

Console.WriteLine("Enter Total Weight:");
weight = int.Parse(Console.ReadLine()); 

if ( weight >= 680)
{
    Console.WriteLine("Overload! Please step out.");
}
else
{
    Console.Writeline("Doors closing.");
}
*/




/* 2
Parking Fee — Read minutes parked. First 30 minutes are free; anything beyond that
costs a flat ₹50. Print the amount to pay.*/
/*
int time;
Console.WriteLine("Read minutes parked:");
time = int.Parse(Console.ReadLine());


if (time < 30)
{
    Console.WriteLine("Free");
}  
else
{
    Console.WriteLine("costs  ruppee 50");
}*/




// 3
//Battery Warning — Read battery percentage. If it's below 20, print
//"Enable power saving mode", else print "Battery OK".

/*
int percentage;

Console.WriteLine("Enter battery percentage:");
percentage = int.Parse(Console.ReadLine());

if (percentage < 20)
{
    Console.WriteLine("Enable power saving mode");
}
else
{
    Console.WriteLine("Battery OK");
}*/



// 4
//Typing Speed — Read words typed and minutes taken. If speed (words/minutes) is 40 or more,
//print "Fast typist", else "Keep practicing".

/*
int words, minutes  ;

Console.WriteLine("Enter words typed:");
words = int.Parse(Console.ReadLine());

Console.WriteLine("Enter minutes taken:");
minutes = int.Parse(Console.ReadLine());

int speed = words / minutes;

if (speed >=40)
{
    Console.WriteLine("Fast typist");
}
else
{
    Console.WriteLine("Keep practicing");
}*/




// 5
//Pizza Delivery Zone — Read the delivery distance in km. Delivery is free within 5 km;
//beyond that, the charge is ₹10 per extra km. Print the delivery charge.

/*
int distance;

Console.WriteLine("Enter delivery distance");
distance = int.Parse(Console.ReadLine());

int charge;

if (distance <= 5)
{
    charge = 0;
}
else
{
    charge = (distance - 5) *10;
}
Console.WriteLine($"Delivery charge = {charge}");
*/





//6
/*Password Space Check — Read a password string. If it contains a space character, print "Invalid: spaces not allowed", 
else "Password accepted". (Hint: password.Contains(' '))
*/

/*
string pass;

Console.WriteLine("Enter Password:");
pass = Console.ReadLine();

if (pass.Contains(' '))
{
    Console.WriteLine("Invalid");
}
else
{
    Console.WriteLine("Password Accepted");
}*/


//7
//Water Tank Alert — Read tank capacity and current water level in litres. 
//If the level is below 10% of capacity, print "Pump ON", else "Pump OFF".




// 8
//Screen Time — Read today's screen time in minutes. If it exceeds 360, print "Take a break!" along with how many minutes over the limit,
//else print "Healthy usage"
/*
int screenTime;

Console.Write("Enter today's screen time (minutes): ");
screenTime = int.Parse(Console.ReadLine());

if (screenTime > 360)
{
    int extra = screenTime - 360;
    Console.WriteLine("Take a break!");
    Console.WriteLine("You are " + extra + " minutes over the limit.");
}
else
{
    Console.WriteLine("Healthy usage");
}
*/

// 9
//Train Waiting List — Read a waiting-list number. If it is 10 or less, print "High chance of confirmation", else "Consider another train".
/*
int waitingList;

Console.Write("Enter waiting list number: ");
waitingList = int.Parse(Console.ReadLine());


if (waitingList <= 10)
{
    Console.WriteLine("High chance of confirmation");
}
else
{
    Console.WriteLine("Consider another train");
}*/





//10
//Refund Window — Read the number of days since purchase. Refund is allowed only within 7 days. Print "Refund approved" or "Refund window closed".
/*
int days;

Console.Write("Enter number of days since purchase: ");
days = int.Parse(Console.ReadLine());   


if (days <= 7)
{
    Console.WriteLine("Refund approved");
}
else
{
    Console.WriteLine("Refund window closed");
}

*/

// part b
//1

//Cab Surge Pricing — Read the hour (0–23) and base fare. If it is
//peak time (8–10 or 17–20): if it's also raining (read y/n), fare doubles,
//else fare increases 1.5×. Otherwise fare stays the same. Print the final fare.


//2

//Baggage Fee — Read travel class (E for economy, B for business) and bag weight.
//Economy: up to 15 kg free, else ₹500 per extra kg.
//Business: up to 30 kg free, else ₹300 per extra kg.
/*
char travelClass;
int weight;

Console.Write("Enter travel class (E/B): ");
travelClass = char.Parse(Console.ReadLine());

Console.Write("Enter bag weight (kg): ");
weight = int.Parse(Console.ReadLine());
int fee = 0;

if (travelClass == 'E' )
{
    if (weight > 15)
    {
        fee = (weight - 15) * 500;
    }
}
else if (travelClass == 'B' || travelClass == 'b')
{
    if (weight > 30)
    {
        fee = (weight - 30) * 300;
    }
}

Console.WriteLine("Baggage Fee = ₹" + fee);
    */



//3

//Blood Donation Eligibility — Read age, weight, and months since last donation.
//Eligible only if age is 18–60; inside that, weight must be ≥ 50; inside that,
//last donation must be ≥ 3 months ago. Print the exact reason for rejection at each level.

/*
int age, weight, months;

Console.Write("Enter age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Enter weight (kg): ");
weight = int.Parse(Console.ReadLine());

Console.Write("Enter months since last donation: ");
months = int.Parse(Console.ReadLine());

if (age >= 18 && age <= 60)
{
    if (weight >= 50)
    {
        if (months >= 3)
        {
            Console.WriteLine("Eligible to donate blood.");
        }
        else
        {
            Console.WriteLine("Rejected: Last donation was less than 3 months ago.");
        }
    }
    else
    {
        Console.WriteLine("Rejected: Weight must be at least 50 kg.");
    }
}
else
{
    Console.WriteLine("Rejected: Age must be between 18 and 60 years.");
}*/




// 4

//Warranty Claim — Read months since purchase and whether there is
//physical damage (y/n). If within 12 months: no damage → "Free repair",
//damage → "Paid repair". If beyond 12 months → "Warranty expired".
/*
int months;
char damage;


Console.Write("Enter months since purchase: ");
months = int.Parse(Console.ReadLine());


Console.Write("Is there physical damage? (y/n): ");
damage = char.Parse(Console.ReadLine());


if (months <= 12)
{
    if (damage == 'n' || damage == 'N')
    {
        Console.WriteLine("Free repair");
    }
    else
    {
        Console.WriteLine("Paid repair");
    }
}
else
{
    Console.WriteLine("Warranty expired");
}*/


// 5

// Video Quality Selector — Read internet speed (Mbps) and data-saver mode
// (on/off). Speed ≥ 25: data saver on → 720p, off → 4K. Speed 5–24: 480p.
// Below 5: "Audio only".

/*
int speed;
string dataSaver;

Console.Write("Enter internet speed (Mbps): ");
speed = int.Parse(Console.ReadLine());

Console.Write("Is Data Saver ON? (on/off): ");
 dataSaver = Console.ReadLine();

if (speed >= 25)
{
    if (dataSaver == "on")
    {
        Console.WriteLine("Video Quality: 720p");
    }
    else
    {
        Console.WriteLine("Video Quality: 4K");
    }
}
else if (speed >= 5 && speed <= 24)
{
    Console.WriteLine("Video Quality: 480p");
}
else
{
    Console.WriteLine("Audio only");
}*/


// 6

// Hostel Mess Rebate — Read days absent in a month. If > 15: full rebate.
// Else if > 7: check if a leave application was submitted (y/n) — yes → half
// rebate, no → no rebate. Else → no rebate.



//7
//Gaming Level Unlock — Read player score and boss-defeated flag (y/n). Score ≥ 1000:
//boss defeated → "Level 3 unlocked", else "Defeat the boss first". Score < 1000 →
//"Score too low".

/*

int score;
Boolean boss;


Console.WriteLine("enter score");
score = int.Parse(Console.ReadLine());

Console.WriteLine(" boss-defeated flag (true/false)");
boss = bool.Parse(Console.ReadLine());

if (score >= 1000 && boss == true)
{
    Console.WriteLine("Level 3 unlocked");
}
else if (score < 1000 && boss == true)
{

    Console.WriteLine("score is low");
}*/


// 8

//AC Auto Mode — Read room temperature and humidity. Temp > 30:
//humidity > 70 → "Cool + Dry mode", else → "Cool mode".Temp 24–30 → "Fan mode".
//Below 24 → "AC off".


/*
int temp, humidity;


Console.WriteLine("enter temperature");
temp = int.Parse(Console.ReadLine());

Console.WriteLine("enter humidity");
humidity= int.Parse(Console.ReadLine());

if (temp > 30 && humidity > 70)
{
    Console.WriteLine("Cool + Dry mode");
}
else if ( temp >=24  && temp <=30 )
{
    Console.WriteLine("Fan mode");
}
else if ( temp < 24 )
{
    Console.WriteLine(" ac off");
}
else
{
    Console.WriteLine(" cool mode");
}*/


//9
//Traffic Fine — Read the vehicle's speed and whether the driver is a repeat offender (y/n). Limit is 60.
//Over the limit by more than 20: repeat → ₹5000, first-time → ₹2000. Over by up to 20: ₹1000. Within limit → no fine.


/*
int speed;
char repeat;

Console.Write("Enter vehicle speed: ");
speed= int.Parse(Console.ReadLine());

Console.Write("Is the driver a repeat offender? (y/n): ");
repeat = char.Parse(Console.ReadLine());

if (speed <= 60)
{
    Console.WriteLine("No fine.");
}
else if (speed > 80)
{
    if (repeat == 'y' || repeat == 'Y')
    {
        Console.WriteLine("Fine = ₹5000");
    }
    else
    {
        Console.WriteLine("Fine = ₹2000");
    }
}
else
{
    Console.WriteLine("Fine = ₹1000");
}
    */


// 10

//Movie Ticket Kiosk — Read age and show time (hour, 0–23). If age< 18: show after 22 →
//"Not allowed", else child price ₹120. If age ≥ 60 → senior price ₹100. Everyone else → ₹200.


/*int age, showTime;


Console.Write("Enter age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Enter show time (0-23): ");
showTime = int.Parse(Console.ReadLine());


if (age < 18)
{
    if (showTime > 22)
    {
        Console.WriteLine("Not allowed.");
    }
    else
    {
        Console.WriteLine("Child ticket price = ₹120");
    }
}
else if (age >= 60)
{
    Console.WriteLine("Senior ticket price = ₹100");
}
else
{
    Console.WriteLine("Ticket price = ₹200");
}*/
























// 15/07/2026

// set1

//1. Number Sign
//Take a number from the user. Print "Positive" if it is greater than zero,
//"Negative" if it is less than zero, and "Zero" if it is zero.
/*
int num;

Console.WriteLine(" Enter a number:");
num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Positive");
}
else if (num < 0)
{
    Console.WriteLine("Negative");
}
else if (num ==0)
{
    Console.WriteLine("Zero");
}*/


//2. Pass or Fail
//Take marks(0 to 100). If marks are 40 or more, print "Pass".
//If marks are between 33 and 39, print "Just Pass". Below 33, print "Fail".

/*
int marks;

Console.WriteLine("Enter marks(0 to 100):");
marks = int.Parse(Console.ReadLine());

if (marks >40)
{
    Console.WriteLine("Pass");
}
else if (marks >33 &&  marks <39)
{
    Console.WriteLine("Just Pass");
}
else
{
    Console.WriteLine("Fail");
}*/


//3. Age Group
//Take the age of a person. Print "Child" for below 13,
//"Teenager" for 13 to 19, "Adult" for 20 to 59, and "Senior" for 60 and above.
/*
int age;

Console.WriteLine("Enter your Age:");
age =int.Parse(Console.ReadLine());

if (age <13)
{
    Console.WriteLine("Child");
}
else if  (age >13 && age <19)
{
    Console.WriteLine("Teenager");
}
else if (age >19 && age <59)


{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Semior");
}*/



//4.Day Name
//Take a number from 1 to 7. Print the day name (1 = Monday, 2 = Tuesday ... 7 = Sunday). For any other number, print "Invalid".

/*
int num;

Console.WriteLine("Enter number b/w (1 to 7):");
num = int.Parse(Console.ReadLine());

if  (num == 1)
{
    Console.WriteLine("Monday");
}
else if  (num == 2)
{
    Console.WriteLine("Tuesday");
}
else if (num ==3)
{
    Console.WriteLine("Wednesday");
}

else if (num == 4)
{
    Console.WriteLine("Thursday");
}

else if (num == 5)
{
    Console.WriteLine("Friday");
}

else if (num == 6)
{
    Console.WriteLine("Saturday");
}

else if (num == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Invalid");
}*/


//5. Vowel or Consonant
//Take one letter from the user. If it is a, e, i, o, or u, print "Vowel". Otherwise print "Consonant".

/*
char letter;

Console.WriteLine("Enter a letter:");
letter = char.Parse(Console.ReadLine().ToUpper());

if (letter == 'A')
{
    Console.WriteLine("Vowel");
}
else if (letter == 'E')
{
    Console.WriteLine("Vowel");
}

else if (letter == 'I')
{
    Console.WriteLine("Vowel");
}

else if (letter == 'O')
{
    Console.WriteLine("Vowel");
}

else if (letter == 'U')
{
    Console.WriteLine("Vowel");
}

else
{
    Console.WriteLine("Consonant");
}*/


//6.Biggest of Three
//Take three numbers. Find and print the biggest one using ladder if.
/*
int a, b, c;


Console.WriteLine("Enter number one:");
a = int.Parse(Console.ReadLine());


Console.WriteLine(" Enter number secon:");
b = int.Parse(Console.ReadLine());


Console.WriteLine("Enter number third:");
c = int.Parse(Console.ReadLine());


if (a >= b && a >= c)
{
    Console.WriteLine($"Biggest number is {a}");
}
else if (b >= a && b >= c)
{
    Console.WriteLine($"Biggest number is {b}");
}
else
{
    Console.WriteLine($"Biggest number is {c}");
}*/

//7. Temperature Report
//Take temperature in Celsius. Print "Cold" for below 15, "Pleasant" for 15 to 25, "Warm" for 26 to 35, and "Hot" for above 35.

/*
int temp;

Console.WriteLine("Enter temperature in Celsius:");
temp = int.Parse(Console.ReadLine());

if (temp < 15)
{
    Console.WriteLine("Cold");
}
else if (temp >15 && temp <25)
{
    Console.WriteLine("Pleasant");
}

else if (temp > 26 && temp < 35)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Hot");
}*/

//8. Sign and Even or Odd
//Take a number. First check if it is zero, positive, or negative. If it is not zero, also print whether it is even or odd.
/*
using System.ComponentModel.Design;

int num;

Console.WriteLine("Enter a number:");
num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Zero");
}
else if (num > 0 && num % 2 == 0) 
    {
        Console.WriteLine("Positive and Even ");
    }
     if ( num >0 && num % 2 != 0) 
    {
        Console.WriteLine("Positive but Odd");
    }

else if (num<0 && num % 2 == 0)
{
    Console.WriteLine("Negative but Even");
}
 if ( num <0  && num %2 != 0)
    {
            Console.WriteLine("Negative and Odd");
        }*/



//Set 2
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

//1.Grade from Five Subjects
// Take the marks of 5 subjects. Find the average. Then print the grade: A(90 and above),
// B(80 to 89), C(70 to 79), D(60 to 69), and F(below 60). If any mark is below 0 or above 100, print "Invalid Input"

/*

int s1, s2, s3, s4, s5;
double average;

Console.Write("Enter marks of Subject 1: ");
s1 = int.Parse(Console.ReadLine());

Console.Write("Enter marks of Subject 2: ");
s2 = int.Parse(Console.ReadLine());

Console.Write("Enter marks of Subject 3: ");
s3 = int.Parse(Console.ReadLine());

Console.Write("Enter marks of Subject 4: ");
s4 = int.Parse(Console.ReadLine());

Console.Write("Enter marks of Subject 5: ");
s5 = int.Parse(Console.ReadLine());

if (s1 < 0 || s1 > 100 || s2 < 0 || s2 > 100 || s3 < 0 || s3 > 100 || s4 < 0 || s4 > 100 || s5 < 0 || s5 > 100)
{
Console.WriteLine("Invalid Input");
}
else
{
average = (s1 + s2 + s3 + s4 + s5) / 5.0;

if (average >= 90)
{
Console.WriteLine("Grade A");
}
else if (average >= 80)
{
Console.WriteLine("Grade B");
}
else if (average >= 70)
{
Console.WriteLine("Grade C");
}
else if (average >= 60)
{
Console.WriteLine("Grade D");
}
else
{
Console.WriteLine("Grade F");
}
}*/



//2.Electricity Bill
//Take the number of units used. The first 100 units cost 5 rupees each,
//the next 100 units cost 7 rupees each, and units above 200 cost 10 rupees each. Calculate and print the total bill.

/*
int units;

Console.Write("Enter units consumed: ");
units = int.Parse(Console.ReadLine());

int bill;


if (units <= 100)
{
bill = units * 5;
}
else if (units <= 200)
{
bill = (100 * 5) + ((units - 100) * 7);
}
else
{
bill = (100 * 5) + (100 * 7) + ((units - 200) * 10);
}

Console.WriteLine($"Total Electricity Bill = ₹ {bill}" );*/


//3.Income Tax
//Take yearly income. Tax rules: up to 2,50,000 no tax; 2,50,001 to 5,00,000
//is 5%; 5,00,001 to 10,00,000 is 20%; above 10,00,000 is 30%.
//Calculate the tax slab by slab and print the total tax.

/*
double income ;

Console.WriteLine("Enter yearly income:");
income = double.Parse(Console.ReadLine());  

double tax;


if (income <= 250000)
{
tax = 0;
}
else if (income <= 500000)
{
tax = (income - 250000) * 0.05;
}
else if (income <= 1000000)
{
tax = (250000 * 0.05) + ((income - 500000) * 0.20);
}
else
{
tax = (250000 * 0.05) + (500000 * 0.20) + ((income - 1000000) * 0.30);
}

Console.WriteLine("Total Tax = ₹" + tax);
*/



//4. Triangle Type
//Take the three sides of a triangle. First check if a triangle is possible
//(the sum of any two sides must be greater than the third side).
//If possible, print "Equilateral" (all sides equal), "Isosceles"(two sides equal), or
//"Scalene" (all sides different). If not possible, print "Not a Triangle".
/*
int a, b, c;

Console.Write("Enter first side: ");
a = int.Parse(Console.ReadLine());

Console.Write("Enter second side: ");
b = int.Parse(Console.ReadLine());

Console.Write("Enter third side: ");
c = int.Parse(Console.ReadLine());

if (a + b <= c || a + c <= b || b + c <= a)
{
Console.WriteLine("Not a Triangle");
}
else if (a == b && b == c)
{
Console.WriteLine("Equilateral Triangle");
}
else if (a == b || b == c || a == c)
{
Console.WriteLine("Isosceles Triangle");
}
else
{
Console.WriteLine("Scalene Triangle");
}
*/


//5.Login Check with Attempts
//Take a username and password. If both are correct, print "Welcome".
//If the username is correct but the password is wrong, print "Wrong Password".
//If the username is wrong, print "User Not Found". Allow only 3 tries, and
//after 3 wrong tries print "Account Locked".



//6.Calculator Menu
//Show a menu: 1 Add, 2 Subtract, 3 Multiply, 4 Divide. Take the user's choice and two numbers.
//Use ladder if to do the correct operation. For divide, also check that the second number is not zero,
//else print "Cannot divide by zero".




//7. Water Bill by Slab
//Take water units used. First 10 units are free, 11 to 30 units cost 2 rupees each, 31 to 60 units cost 4 rupees each,
//and above 60 units cost 6 rupees each. Also add a fixed line charge of 50 rupees. Print the total bill.


//8. Roots of a Quadratic Equation
//Take the values a, b, and c for the equation ax² + bx + c = 0. Find the discriminant d = b² - 4ac. If d is greater than 0,
//print "Two Real Roots" and show both roots. If d is 0, print "One Real Root" and show it. If d is less than 0, print
//"No Real Roots".


























// 16/07/2026

//  && or assignment


//   1           Write a program to check if a number lies between 10 and 20. 
// Example: Input → 15 → Output: "Number is between 10 and 20"

/*
int num;

Console.WriteLine("Enter a number:");
num = int.Parse(Console.ReadLine());

if (num >= 10 && num <= 20)
{
Console.WriteLine("Number is between 10 and 20");
}

*/


// 2 Write a program to take two numbers and print "Valid" only if both are even. 
//Example: Input → 4 and 6 → Output: "Valid"Write 
/*
int a, b;
Console.WriteLine("Enter number 1:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number 2:");
b = int.Parse(Console.ReadLine());

if ( a %2 == 0  && b %2 ==0)
{
Console.WriteLine("Both number is Even.");
}
else
{
Console.WriteLine("Not Even.");
}*/


// 3 Write a program to check if a character is a vowel (a, e, i, o, u). 
//Example: Input → 'i' → Output: "Vowel 


/*
char letter;

Console.WriteLine("Enter a letter:");
letter = char.Parse(Console.ReadLine().ToUpper());


if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U'  )
{
Console.WriteLine("Vowel");
}
else
{
Console.WriteLine("Consonant");
}
*/

//  5  Write a program to check if the age is more than 18 and less than 60. 
// Example: Input → 25 → Output: "Eligible" 

/*
int age;

Console.WriteLine("Enter your Age:");
age = int.Parse(Console.ReadLine());

if (age >= 18 && age <= 60)
{
Console.WriteLine("Eligible");
}*/


// 6 Write a program that takes three subject marks and prints "Pass" only if all are above 33. 
// Example: Input → 45, 67, 89 → Output: "Pass" 
/*
double subject1, subject2, subject3;

Console.WriteLine("Enter marks of Subject 1:");
subject1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter marks of Subject 2:");
subject2 = double.Parse(Console.ReadLine());


Console.WriteLine("Enter marks of Subject 3:");
subject3 = double.Parse(Console.ReadLine());

if ( subject1 >= 33 && subject2 >=33 && subject3 >=33)
{
Console.WriteLine("Pass");
}
else
{
Console.WriteLine("Fail");
}*/

// 7 Write a program to check if a number is either divisible by 3 or divisible by 5. 
// Example: Input → 15 → Output: "Divisible"   
/*
int num;

Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

if (num %3 == 0  || num %5 == 0)
{
Console.WriteLine("Divisible ");
}
else
{
Console.WriteLine("Not Divisible");
}*/


// 8 allowedWrite a program to check if a number is less than 0 or greater than 100. 
//Example: Input → -5 → Output: "Number is out of range" 

/*
int num;


Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

if  (num <0 || num > 100)
{
Console.WriteLine("Number is out of Range.");
}*/


// 9 Write a program to check if a person is allowed entry only if their age is between 21 and 60. 
//Example: Input → 30 → Output: "Entry allowed" 
/*

int age;

Console.WriteLine("Enter your Age:");
age = int.Parse(Console.ReadLine());

if ( age >=21 || age <=60)
{
Console.WriteLine("Entry allowed.");
}
else
{
Console.WriteLine("Entry not allowed.");
}*/


// 10 Write a program to check if a person is eligible for a senior citizen scheme (age should be 60 or income less than 2 lakhs). 
//Example: Input → Age 65, Income 5 lakhs → Output: "Eligible" 

/*
int age;
double income;

Console.WriteLine("Enter your age:");
age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your income,in lakhs:");
income = double.Parse(Console.ReadLine());


if (age >=60 && income >= 200000)
{
Console.WriteLine("Eligible");

}
else
{
Console.WriteLine("Not Eligible");
}*/


// 11 Write a program to accept marks in English and Math and print "Scholarship Granted" if both are above 90. 
// Example: Input → English 92, Math 95 → Output: "Scholarship Granted" 


/*
double eng, mth;

Console.WriteLine("Enter Maths marks:");
mth = double.Parse(Console.ReadLine());


Console.WriteLine("Enter English marks:");
eng = double.Parse(Console.ReadLine());

if (eng > 90 && mth >90)
{
Console.WriteLine("Scholarship Granted");
}
else
{
Console.WriteLine("Scholarship not Granted.");
}*/

























// 17/07/2026
/*
1.Print numbers from 1 to 10.
2. Print even numbers from 2 to 20.
3. Print the squares of numbers from 1 to 10.
4. Print the numbers from 10 to 1 in reverse order.
5. Print the first 10 multiples of 5.
6. Print all odd numbers between 1 and 30.
7. Print the table of 7 (i.e., 7, 14, 21, ..., up to 70).
8.Print numbers from 50 to 100 with a step of 5.
9. Print the sum of numbers from 1 to 100.

*/



//  1.Print numbers from 1 to 10.
/*
for (int i = 1;  i <= 10; i++)
{
Console.WriteLine( $"{i}");
}*/


// 2. Print even numbers from 2 to 20.
/*

for (int i = 2; i <= 20; i++)
{
if (i %2 == 0)
{
Console.WriteLine($"{i}");
}
}*/


// 3. Print the squares of numbers from 1 to 10.
/*
for (int i = 1; i <= 10; i++)
{
int square=i*i;
Console.WriteLine("Square numbers:");
Console.WriteLine($"{i}={square}");
}
*/


// 4. Print the numbers from 10 to 1 in reverse order.
/*
for (int i = 10; i >= 1; i--)
{
Console.WriteLine($"{i}");
}
*/

// 5. Print the first 10 multiples of 5.

/*
for (int i = 1; i <= 10; i++)
{
Console.WriteLine($"{i *5}");
}*/


//6. Print all odd numbers between 1 and 30.

/*
for (int i = 1; i <=30; i++)
{
if (i %2 !=0)
Console.WriteLine($"{i }");
}
*/


// 7. Print the table of 7 (i.e., 7, 14, 21, ..., up to 70).
/*

for (int i = 1; i <= 10; i++)
{
Console.WriteLine($"{i * 7}");
}
*/

//8.Print numbers from 50 to 100 with a step of 5.


/*
for (int i = 50; i <= 100; i+=5)
{
Console.WriteLine($"{i}");
}
*/

//9. Print the sum of numbers from 1 to 100.
































// 20/07/2026

// while loop

//1. Print all even numbers from 8 to 20 using a while loop 
//Input: None
//Output: 8 10 12 14 16 18 20
//Explanation: Even numbers are those that can be divided by 2 without a remainder.
//This program starts from 8 and prints every even number up to 20 using a while loop. 
/*

int number = 8;
while (number <=20)
{
    Console.WriteLine(number + " ");
    number += 2;
}

*/


//2. Find and display the sum of digits of a given number using a while loop 
//Input: 345
//Output: Sum of digits = 12
//Explanation: The digits of 345 are 3, 4, and 5. When we add them: 3 + 4 + 5 = 12.This is called the sum of digits.	


/*
int num;
Console.WriteLine("Enter a number:");
num = int.Parse(Console.ReadLine());
int digit;
int sum = 0;

while (num> 0)
{
    digit = num %10;
    sum = sum + digit;
    num = num /10;
}
Console.WriteLine($" Sum of digit: {sum}");
*/


//3. Reverse a given number using a while loop 
//Input: 1234
//Output: Reversed number = 4321
//Explanation: Reversing a number means writing its digits in the opposite order. 1234 becomes 4321. 
/*
int number = 1234;
int reminder;
int newnumber = 0;

while ( number != 0 )
{
    reminder = number%10;
    newnumber = newnumber * 10 + reminder;
    number = number/10;
}
Console.WriteLine(newnumber);*/




//4. Check whether a given number is a palindrome using a while loop 
//Input: 121
//Output: 121 is a palindrome 


//Input: 123 
//Output: 123 is not a palindrome
//Explanation: A palindrome number reads the same forward and backward.
//For example, 121 reversed is still 121, so it’s a palindrome. But 123 becomes 321, so it is not. 

/*
int input;

Console.WriteLine("Enter number:");
input = int.Parse(Console.ReadLine());


*/




/*
5.Print the multiplication table of a number up to 10 using a while loop
Input: 7
Output:
7 x 1 = 7 
7 x 2 = 14 
7 x 3 = 21 
7 x 4 = 28 
7 x 5 = 35 
7 x 6 = 42 
7 x 7 = 49 
7 x 8 = 56 
7 x 9 = 63 
7 x 10 = 70 

Explanation: This prints the multiplication table of the number entered by the user. 
The loop runs 10 times, multiplying the number by 1 to 10.

*/
/*
int number;
Console.WriteLine("Enter which table you want");
number = int.Parse(Console.ReadLine());
int i=1;


while (i <=10)
{
    Console.WriteLine($" {number} * {i} = {number * i}");
    i++;
}
*/







//6. Find the sum of the first N natural numbers using a while loop 
//Input: N = 5
//Output: Sum = 15
//Explanation: Natural numbers are positive whole numbers.
//The first 5 natural numbers are 1, 2, 3, 4, 5. Their sum is 1+2+3+4+5 = 15. 
/*
int num, sum = 0, count = 1;
Console.WriteLine("Enter number to  find the sum of the natural numbers");
num = int.Parse(Console.ReadLine());

while ( count <= num )
{
    sum = sum + count;
    count++;
}
Console.WriteLine($"Sum = {sum}");


*/



/*
7.Find the largest digit in a given number using a while loop
Input: 4963
Output: Largest digit = 9
Explanation: The digits in 4963 are 4, 9, 6, 3. The largest one is 9. 

 */
/*

int num;
Console.WriteLine("Enter number");
num = int.Parse(Console.ReadLine());
int digit;
int largest = 0;

while (num > 0)
{
    digit = num % 10;
    if (digit > largest)
    {
        largest = digit;
    }

    num = num / 10;
}
Console.WriteLine($"Largest digit {largest}");

*/








/*
8. Print all numbers between 1 and 100 that are divisible by both 3 and 5 using a while loop
Input: None
Output: 15 30 45 60 75 90
Explanation: A number divisible by both 3 and 5 is a multiple of 15. This program finds and prints those numbers from 1 to 100. 
*/
/*
int number = 1;

while (number <=100)
{
    if (number %3 ==0 && number %5 ==0)
        Console.WriteLine(number);
    number++;
}


*/




/* 

9. Calculate the power of a number (base^exponent) using a while loop
Input: Base = 2, Exponent = 5
Output: 2 ^ 5 = 32
Explanation: 2 to the power of 5 means multiplying 2 by itself 5 times: 2×2×2×2×2 = 32.
*/
/*
int bas, expo,result=1,count=0;

Console.WriteLine("Enter Base number:");
bas = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Exponent for number:");
expo = int.Parse(Console.ReadLine());

while (count<expo)
{
    result = result * bas;
    count++;

}
Console.WriteLine($"{bas} ^ {expo} = {result}");
*/


/*
10.Calculate the power of a number (base^exponent) using a while loop
Input: 48261
Output: Sum of even digits = 16 
Explanation: The even digits in 48261 are 4, 8, 2, and 2 (from the 6). Sum = 4 + 8 + 2 + 2 = 16.
*/







/*

11.Find the product of all digits in a number using a while loop
Input: 1234
Output: Product of digits = 24
Explanation: The digits are 1, 2, 3, 4. Their product means 1 × 2 × 3 × 4 = 24. "Product" means multiplying all the digits together. 

 */


/*
int num,digit,product=1;

Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

while (num > 0)
{
    digit=num%10;
    product= product*digit;
    num = num/10;


}
Console.WriteLine(product);
*/


/*
12. Display the first N odd numbers using a while loop
Input: N = 5
Output: 1 3 5 7 9
Explanation: Odd numbers are numbers that are not divisible by 2. The first 5 odd numbers are 1, 3, 5, 7, 9. 
*/

/*
int input , number=1, count=0;

Console.WriteLine("Enter how many  display the first  odd numbers:");
input = int.Parse(Console.ReadLine());

while (count < input)
{
    Console.WriteLine(number);
    number = number + 2;
    count++;

}
*/










//      Do While Questions 


/*
1. Keep asking the user to enter a password until the correct one is entered using a do -while loop
Input: (User enters: 1234, then admin123) 
Output:
Wrong password. Try again. 
Correct password entered! 
Explanation: This program keeps asking for the password until the user enters the correct one (like "admin123"). The loop runs at least once and checks every time if the entered password is correct. 
*/
/*
string password;

do
{
    Console.WriteLine("enter password");
    password = Console.ReadLine();
    if (password == "admin123")
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("wrong pass try again");
    }

} while (password != "admin123");*/





/*
2. Keep adding numbers entered by the user until the user enters 0 using a do -while loop
Input: 5, 3, 2, 0
Output: Total sum = 10
Explanation: The user keeps entering numbers, and the program adds them. When the user types 0, the loop ends and shows the final sum. 
*/


/*
int num;
Console.WriteLine("Enter a number:");
num = int.Parse(Console.ReadLine());
int digit;
int sum = 0;

while (num > 0)
{
    digit = num % 10;
    sum = sum + digit;
    num = num / 10;
}
Console.WriteLine($" Sum of digit: {sum}");
*/


/*
int number;
int sum = 0;
do
{
    Console.WriteLine("Enter number:");
    number =int.Parse(Console.ReadLine());
    
    
      sum = sum + number;

    


}while (number != 0);

Console.WriteLine(sum);
*/



/*
3. Take a number from the user and keep asking until a positive number is entered using a do -while loop
Input: -5, 0, -1, 7
Output: You entered a positive number: 7
Explanation: This loop keeps asking for input until the user finally gives a number greater than 0. Negative and zero values are not accepted. 
*/
/*
int num;

do
{
    Console.WriteLine("Enter number:");
    num = int.Parse(Console.ReadLine());
} while (num <= 0);
Console.WriteLine($"Positive number {num}");


*/



/*
4. Calculate the sum of squares of numbers from 1 to N using a do -while loop
Input: N = 4
Output: Sum of squares = 30
Explanation: The squares are: 1² = 1, 2² = 4, 3² = 9, 4² = 16
Total = 1 + 4 + 9 + 16 = 30
*/


/*
int number;
Console.WriteLine("Enter Number:");
number = int.Parse(Console.ReadLine());

int i = 1;
int sum = 0;
do
{ 
    sum = sum + (i * i);
    i++;
}while (i <= number);
Console.WriteLine($"Sum is: {sum}");*/



/*
5.Find the average of numbers entered by the user until they enter -1 using a do -while loop
Input: 10, 20, 30, -1
Output: Average = 20.0
Explanation: The loop keeps collecting numbers and calculates the average at the end. -1 is used to stop the loop and is not included in the average. 
*/
/*
int num,numcount=0,totalnum=0;

do
{
    Console.WriteLine("Enter any number:");
    num = int.Parse(Console.ReadLine());
    totalnum = totalnum + num;
    numcount =  numcount+1;

    if (num == -1)
    {
        Console.WriteLine($"avarage is {totalnum/numcount}");
    }

    

}
while (num != -1);

*/
/*
6. Simulate a simple login system that gives the user 3 attempts using a do -while loop
Input: (Wrong password 2 times, then correct password) 
Output:
Attempt 1: Wrong password 
Attempt 2: Wrong password 
Attempt 3: Login successful 
Explanation: This program allows the user to enter the password 3 times. If the correct password is entered, it exits early. 
*/
/*
string password = "admin123",userpass="";

int attempt=0;

Console.WriteLine("Enter Password:");
userpass = Console.ReadLine();
do
{
   
    attempt = attempt + 1;

    if (password != userpass)
    {
        Console.WriteLine($"Attempt: {attempt} Try again.");
        userpass = Console.ReadLine();
    }
    if (userpass == password)
    {
        Console.WriteLine("Login successful.");
    }
    if (attempt == 3 )
    {
        Console.WriteLine("attempt full");
        break;
    }


} while (userpass != "admin123");

*/



/*
7. Keep multiplying a number by 2 until it becomes greater than 1000 using a do -while loop
Input: Start = 5
Output: 5 10 20 40 80 160 320 640 1280
Explanation: Starting from 5, the number is doubled each time. The loop stops when the number becomes more than 1000. 
*/

/*
int num;


Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

do
{
    Console.Write(num + " " );
    num = num * 2;

}while(num <= 1000);
Console.WriteLine(num);
*/


/*
8. Keep asking the user to input a character until they input “exit” and check if it is a vowel or consonant using a do -while loop
Input: a, b, e, exit 
Output: 
'a' is a vowel
'b' is a consonant
'e' is a vowel
Explanation: The loop continues until the user types "exit". For each letter, the program checks if it is a vowel (a, e, i, o, u) or a consonant. 
*/

/*
string alpha;

do
{
    Console.WriteLine("Enter any word, or type 'exit' to stop");
    alpha = Console.ReadLine();

    if (alpha != "Exit")
    {
        char ch = alpha[0];

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("'" + ch + "' is a vowel");
        }
        else
        {
            Console.WriteLine("'" + ch + "' is a consonant");
        }

    }
}
while (alpha != "exit");*/

/*
9. Ask the user to enter 5 numbers one by one using a do -while loop
Input: 3, 6, 2, 9, 4
Output: You entered: 3 6 2 9 4
Explanation: The program uses a do-while loop to collect exactly 5 numbers from the user and then displays them. 
*/
/*
int num ,count=1;
string output = "you entered";
Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

do
{

        Console.WriteLine("Enter number:");
         num = int.Parse(Console.ReadLine());
    output = output + " " + num;
   
    count++;
   
} while (count != 6);

Console.WriteLine($" You Entered: {output}" );
*/
/*
10. Keep asking the user to enter an even number. If odd, ask again using a do -while loop
Input: 3, 7, 10
Output:
3 is odd.Try again. 
7 is odd.Try again. 
10 is even.Thank you!
Explanation: The loop continues until the user enters a number that is divisible by 2 (even number). */
/*
int num;

do
{
    Console.WriteLine("Enter number:");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} is Even, Thank you!");
    }
    else if(num % 2 != 0)
    {
       
        Console.WriteLine($"{num} id odd. Try again.");
    }
   

}while (num %2 != 0);
*/






/*

        int units;
        double bill = 0, finalBill;

        Console.WriteLine("Enter electricity units: ");
        units = int.Parse(Console.ReadLine());
        if (units <= 100)
        {
            bill = units * 2;
        }
        else if (units <= 200)
        {
            bill = (100 * 2) + ((units - 100) * 4);
        }
        else if (units <= 500)
        {
            bill = (100 * 2) + (100 * 4) + ((units - 200) * 8);
        }
        else if (units <= 1000)
        {
            bill = (100 * 2) + (100 * 4) + (300 * 8) + ((units - 500) * 10);
        }
        else
        {
            bill = (100 * 2) + (100 * 4) + (300 * 8) + (500 * 10) + ((units - 1000) * 10);
        }

        
        finalBill = bill + (bill * 0.10);

        Console.WriteLine($"Bill before subsidy = {bill}" );
        Console.WriteLine($"Bill after 10% subsidy = {finalBill}");
 */
/*

int num, orginal, reverse = 0, reminder;

Console.WriteLine("Enter number:");
num = int.Parse(Console.ReadLine());

orginal = num;


while ( num > 0 )
{
    reminder = num % 10;
    reverse = reverse * 10 + reminder;
    num = num / 10;
}
if ( orginal == reverse)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}*/

//Find the absolute value of a number.
/*
int num;
Console.WriteLine("Enter number :");
num = int.Parse(Console.ReadLine());

if (num < 0)
{
    num = -num;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine(num);
}*/


//Print numbers from 1 to 10.
// using while loop
/*
int num=1;

while(num <10)
{
    Console.WriteLine(num);
    num++;

}
*/
/*
int num=1;

while( num <=100)
{
    if( num % 2 == 0)
    Console.WriteLine(num);
    num++;
}

*/




// 23/07/2026

/*
int unit ;
Console.WriteLine("Enter bill unit:");
unit = int.Parse(Console.ReadLine());

double bill = 0;

if (unit <=100)
{
    bill = 100 * 2;
}
else if (unit <=200)
{
    bill = (100 * 2) + ((unit - 100) * 4);
}
else if (unit <=500)
{
    bill = (100 * 2) + (100 * 4) + ((unit - 200) * 8);
}
else  
{
    bill = (100 * 2) + (100 * 4) +(300 * 8)+ ((unit - 500) *10);
}
 if (bill >1000)
{
    bill = bill + (bill * 0.10);
}

Console.WriteLine(bill);*/


/*
Input:
Units Consumed
Customer Type: Domestic / Commercial
Payment Status: OnTime / Late


Unit Slabs:
1–100 = ₹2 / unit
101–200 = ₹4 / unit
201–500 = ₹8 / unit
Above 500   = ₹10/unit
 
Rules:
Domestic:
Fixed charge = ₹100


Commercial:
Fixed charge = ₹250
  Add 20% commercial charge
 
If bill > ₹1000:
  Add 10% surcharge
 
If bill > ₹5000:
  Add 15% surcharge instead of 10%
 
If payment is Late:
  Add ₹200 late fee
 
Output:
Unit Bill
Fixed Charge
Surcharge
Commercial Charge
Late Fee
Final Bill*/



/*
int unit;

Console.WriteLine("Units Consumed:");
unit = int.Parse(Console.ReadLine());

string customertype, paymentstatus;

Console.WriteLine("Domestic or Commercial");
customertype = Console.ReadLine();

Console.WriteLine("Bill pay ontime or late");
paymentstatus = Console.ReadLine();

double bill = 0,fixcharge = 0,surcharge=0,late=0,finalbill;


if (unit <= 100)
{
    bill = 100 * 2;
}
else if (unit <= 200)
{
    bill = (100 * 2) + ((unit - 100) * 4);
}
else if (unit <= 500)
{
    bill = (100 * 2) + (100 * 4) + ((unit - 200) * 8);
}
else
{
    bill = (100 * 2) + (100 * 4) + (300 * 8) + ((unit - 500) * 10);
}

if ( customertype == "domestic")
{
    fixcharge = 100;
}
else if (customertype == "commercial")
{
    fixcharge = 250;
}
if (bill > 1000)
{
    surcharge = bill * 0.10;
    if (bill > 5000)
    {
        surcharge = surcharge + (bill * 0.15);
    }

}

if (paymentstatus == "late")
{
    late = 200 ;
}

finalbill = bill + surcharge + late + fixcharge ;

Console.WriteLine($"Your unit = {unit}");
Console.WriteLine($"Late fees = {late}");
Console.WriteLine($"Fixcharge = {fixcharge}");
Console.WriteLine($"Surcharge = {surcharge}");
Console.WriteLine($"Final bill = {finalbill}");
*/



/*
2nd is this Input:
Basic Salary
Performance Rating: 1–5
Years of Service
HRA:
Basic <= 25000 = 20 %
25001–50000 = 25 %
Above 50000 = 30 %
DA = 10 % of Basic
Bonus:
Rating 5 = 15% of Basic
Rating 4 = 10%
Rating 3 = 5%
Below 3  = No Bonus
Extra Loyalty Bonus:
Service >= 5 years = ₹5000
PF = 12 % of Basic
If Gross Salary > ₹80000:
Tax = 10 %
Calculate:
Basic
HRA
DA
Bonus
Loyalty Bonus
Gross Salary
PF
Tax
Net Salary*/

/*
double basicsalary,hra,da,bonus,extrabonus=0,pf,grosssalary,tax=0,netsalary;

int rating, yearofservice;

Console.WriteLine("Enter your Basic Salary:");
basicsalary = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Performance rating 1 to 5:");
rating = int.Parse(Console.ReadLine());

Console.WriteLine("Enter year of Service:");
yearofservice = int.Parse(Console.ReadLine());

//hra

if (basicsalary <= 25000)
{
    hra = 0.2 * basicsalary;
}
else if (basicsalary >=25001 || basicsalary <=50000)
{
    hra = 0.25* basicsalary;
}
else
{
    hra =0.30* basicsalary;
}

//da

da = 0.10* basicsalary;

// bonus

if (rating == 5)
{ 
    bonus = 0.15 * basicsalary;
}
else if (rating == 4)
{
    bonus = 0.10 * basicsalary;
}
else if(rating == 3)
{
    bonus = 0.5 * basicsalary;
}
else
{
    bonus = 0;
}

// extrabonus

if (yearofservice >= 5)
{
    extrabonus = 5000;
}

//pf

pf = 0.12 * basicsalary;

// grosssalary

grosssalary = basicsalary + bonus + extrabonus + da +hra;

// tax
if (grosssalary > 80000)
{
    tax = 0.10* grosssalary;
}

//netsalary

netsalary = grosssalary - pf - tax;


Console.WriteLine($"Basic Salary = {basicsalary}");
Console.WriteLine($"HRA = {hra}");
Console.WriteLine($"DA = {da}");
Console.WriteLine($"Bonus = {bonus}");
Console.WriteLine($"Loyalty Bonus = {extrabonus}");
Console.WriteLine($"Gross Salary = {grosssalary}");
Console.WriteLine($"PF = {pf}");
Console.WriteLine($"Tax = {tax}");
Console.WriteLine($"Net Salary = {netsalary}");

*/






// array 
/*
int[] marks = {88,99,66,77,55,44,33,22,11 };
Array.Sort(marks);
foreach (int i in marks)
{
    Console.WriteLine(i);
}*/

/*
int[] marks = { 88, 99, 66, 77, 55, 44, 33, 22, 11 };
Console.WriteLine($" Minimum marks = {marks.Min()}");
Console.WriteLine($" Maximum marks = {marks.Max()}");
Console.WriteLine($" Total = {marks.Sum()}");
Console.WriteLine($" Average = {marks.Average()}");
*/

/*
int[] marks = { 88, 99, 66, 77, 55, 44, 33, 22, 11 };
foreach (int mark in marks)
{
    Console.Write(","+ mark );
}
bool found;
int search;


Console.WriteLine("Enter element which you find:");
search = int.Parse(Console.ReadLine());

found = false;

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] == search)
    {
        Console.WriteLine($" your element at index = {i}");
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Element not found");
}*/








// 24/07/26

// star pattern


/*
 

1
12
123
1234
12345


*/


/*
for  (int outer = 1; outer <= 5; outer++)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner); 
    }

    Console.WriteLine();
}*/


/*
  
  
 
*
**
***
****
*****



*/



/*

for (int outer = 1; outer <= 5; outer++)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
*/


/*
12345
1234
123
12
1
*/
/*
for (int outer = 5; outer >= 1; outer--)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner);
    }

    Console.WriteLine();
}*/


/*
  
 
*****
****
***
**
*


*/

/*
for (int outer = 5; outer >= 1; outer--)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
*/


/*
  
 
    *
   **
  ***
 ****
*****


*/

/*
for (int row=1;  row<=5;  row++)
{ 
    for ( int space=1; space<=5-row; space++)
    {
        Console.Write(" ");
    }
    for ( int input=1; input<=row; input++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}*/


/*
    1
   12
  123
 1234
12345

 */

/*
for (int row=1; row<=5;  row++)
{
    for (int space=1; space<=5-row; space++)
    {
        Console.Write(" ");
    }
    for (int input=1; input<=row; input++)
    {
        Console.Write(input);
    }
    Console.WriteLine();
}*/

/*

*****1*****
****1*2****
***1*2*3***
**1*2*3*4**
*1*2*3*4*5*


*/


/*

1
12
123
1234
12345
1234
123
12
1

*/

/*
for  (int outer = 1; outer <= 5; outer++)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner); 
    }

    Console.WriteLine();
}

for (int outer = 4; outer >= 1; outer--)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner);
    }

    Console.WriteLine();
}*/

/*
for (int row = 1; row <= 5; row++)
{
    for (int space = 1; space <= 5 - row; space++)
    {
        Console.Write(" ");
    }
    for (int input = 1; input <= row; input++)
    {
        Console.Write(input);
    }
    for (int input = 4; input <= row-1; input--)
    { Console.Write(input); }
  

    Console.WriteLine();
    
}*/



/*
1
22
333
4444
55555
*/

/*
for (int outer=1; outer<=5;  outer++)
{
    for (int inner=1; inner<=outer; inner++)
    {
        Console.Write(outer);
    }
    Console.WriteLine();
}*/

/*
1
121
12321
1234321
123454321
*/



/*
    for (int outer=1; outer<=5;  outer++)
{
    for (int inner=1; inner<=outer; inner++)
    {
        Console.Write(inner);

    }
    for ( int inner =outer-1; inner>=1; inner--)
    {
        Console.Write(inner);
    }
    Console.WriteLine();

}
*/



/*
    1
   121
  12321
 1234321
123454321
*/


/*
for (int outer = 1; outer <= 5; outer++)
{
    for (int space = 1; space <= 5 - outer; space++)
    {
        Console.Write(" ");
    }
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner);

    }
    for (int inner = outer - 1; inner >= 1; inner--)
    {
        Console.Write(inner);
    }
    Console.WriteLine();

}
*/

/*
1
21
321
4321
54321
*/
/*
for (int outer=1;  outer<=5;  outer++)
{
    for (int inner=outer; inner>=1; inner--)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}*/

/*
A
AB
ABC
ABCD
ABCDE
*/

/*
for  (int outer=1; outer<=5;  outer++)
{
    char ch ='A';
    for (int inner=1; inner<=outer; inner++)
    {
        Console.Write(ch);
        ch++;
    }
    Console.WriteLine();

}
*/



/*
543212345
 4321234
  32123
   212
    1

*/

/*
for (int outer = 5; outer >=1; outer--)
{

    for ( int space = 5-outer; space >=1; space--)
    {
        Console.Write(" ");
    }
    for (int inner = outer; inner >= 1; inner--)
    {
        Console.Write(inner);
    }
    for (int inner = 2; inner <=outer; inner++)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}
*/

/*
A
AB
ABC
ABCD
ABCDE
*/


/*
for ( int outer=1; outer<=5; outer++ )
{
    for ( int inner=1; inner<=outer; inner++ )
    {
        Console.Write(Convert.ToChar(64+inner));

    }
    Console.WriteLine();
}
*/
/*
    A
   AB
  ABC
 ABCD
ABCDE

*/

/*
for (int outer = 1; outer <= 5; outer++)
{ 
    for ( int space=1; space <= 5-outer; space++)
    {
        Console.Write(" ");
    }
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(Convert.ToChar(64 + inner));

    }
    Console.WriteLine();
}
*/
/*
    A
   ABA
  ABCAB
 ABCDABC
ABCDEABCD

*/


/*
for (int outer = 1; outer <= 5; outer++)
{
    for (int space = 1; space <= 5 - outer; space++)
    {
        Console.Write(" ");
    }
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(Convert.ToChar(64 + inner));

    }
    for (int inner = 1; inner <= outer-1; inner++)
    {
        Console.Write(Convert.ToChar(64 + inner));

    }
    Console.WriteLine();
}
*/

/*
54321
 4321
  321
   21
    1
*/


/*
for (int outer=5; outer>=1; outer--)
{
    for (int space=5; space>outer; space--)
    {
        Console.Write(" ");
    }
    for (int inner=outer; inner>=1; inner--)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}
*/

/*
543212345
 4321234
  32123
   212
    1
*/


/*
for (int outer = 5; outer >= 1; outer--)
{
    for (int space = 5; space > outer; space--)
    {
        Console.Write(" ");
    }
    for (int inner = outer; inner >= 1; inner--)
    {
        Console.Write(inner);
    }
    for (int inner=2; inner <= outer; inner++)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}
*/



/*
1
23
456
78910
*/
/*
int num = 1;

for (int outer = 1; outer <= 4; outer++)
{
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(num+"");
        num++;
    }
    Console.WriteLine();
}*/

/*
1234
 123
  12
   1
*/
/*
for ( int outer=4; outer>=1; outer--)
{
    for ( int space=4-outer; space>=1; space--)
    {
        Console.Write(" ");
    }
    for ( int inner=1; inner<=outer; inner++)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}*/

/*
1234
 123
  12
   1
*/


/*
for (int outer = 4; outer >= 1; outer--)
{
    for (int space = 4 - outer; space >= 1; space--)
    {
        Console.Write(" ");
    }
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}*/
/*
   1
  21
 321
4321
*/



/*
for ( int outer=1;  outer<=4;  outer++)
{
    for ( int space=1; space>=outer-2; space--)
    {
        Console.Write(" ");
    }
    for ( int inner=outer; inner>=1;  inner--)
    {
        Console.Write(inner);
    }
    Console.WriteLine();
}*/
/*
   A
  BAB
 CBABC
DCBABCD
*/


/*
for (int outer = 1; outer <= 4; outer++)
{
    for (int space = 1; space >= outer - 2; space--)
    {
        Console.Write(" ");
    }
    for (int inner = outer; inner >= 1; inner--)
    {
        Console.Write(Convert.ToChar(64+inner));
    }
    for ( int inner = 2; inner <=outer; inner++)
    {
        Console.Write(Convert.ToChar(64+inner));
    }
    Console.WriteLine();
}*/



/*
for (int outer = 6; outer >= 1; outer--)
{
   *//* for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write(inner);
    }*//*
   for (int inner = 1; inner <=5; inner++)
    {
        Console.Write(inner);
    }


*//*    for ( int inner = 1; inner < 6-outer; inner++)
    {
        Console.Write(" ");
    }*/
/*    for (int inner = outer; inner >= 1; inner--)
    {
        Console.Write(inner);
    }*//*
   // Console.WriteLine();
}*/

/*
int length = 6;

for (int i = 1; i <= length; i++)
{
    for (int j = 1; j <= (length + 1) - i; j++)
    {
        Console.Write(j);
    }
    for (int j = 1; j <= i-1; j++)
    {
        Console.Write("-");
    }
    for (int  j = 1;  j<= i-2; j++)
    {
        Console.Write("-");

    }
    for ( int j=(length+1)-i;  j>=1; j--)
    {
        if (j == length)
        {
            continue;
        }
        Console.Write(j);
        
    }
    
    Console.WriteLine();
}
*/
/*
12345654321
12345 54321
1234   4321
123     321
12       21
1         1

*/


/*
int row=6;

for ( int outer=1; outer<=row; outer++)
{
    for (int inner=1; inner<=(row+1)-outer; inner++)
    {
        Console.Write(inner);
    }

    for (int space=1;  space<=outer-1; space++)
    { 
        Console.Write(" "); 
    }
    for ( int space=2; space<=outer-1; space++)
    {
        Console.Write(" ");
    }
    for ( int inner=(row+1)-outer; inner>=1;  inner--)
    {
        if (inner==row)
        {
            continue;
        }
        Console.Write(inner);
    }

    Console.WriteLine();

}
*/

/*

*        *
**      **
***    ***
****  ****
**********
****  ****
***    ***
**      **
*        *

*/


/*
int row = 5;

for ( int outer=1; outer<=row; outer++ )
{
    for ( int inner=1; inner<=outer; inner++ )
    {
        Console.Write("*");
    }
    for (int space=1; space<=row-outer; space++)
    {
        Console.Write(" ");
    }
    for (int space=1 ; space<=row-outer ; space++)
    {
        Console.Write(" ");
    }
    for (int inner=1 ; inner<=outer ; inner++)
    {
        Console.Write("*");
    }
        
        Console.WriteLine();
}
int row2 = 4;
for (int outer=row2; outer>=1; outer--)
{
    for (int inner=outer ; inner>=1 ; inner--)
    {
        Console.Write("*");
    }
    for (int space=1; space<=row-outer; space++)
    {
        Console.Write(" ");
    }
    for ( int space=1 ; space<=row-outer ;space++)
    {
        Console.Write(" ");
    }
    for (int inner = 1; inner <= outer; inner++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/



/*
int row = 4;

for (int outer=1; outer<=row; outer++)
{
    for (int inner=row-2; inner<=outer; inner++)
    {
        Console.Write("-");
    }
    for ( int inner=row; inner<=4; inner++)
    {
        Console.Write("*");
    }
    for ( int space=1; space<=row-outer; space++)
    {
        Console.Write("-"); 
    }
    for ( int space=2; space<=row-outer; space++)
    {
        Console.Write("-");
    }
    for ( int inner=1; inner<=row-3 ; inner++)
    {
        
        Console.Write("*");
    }

    Console.WriteLine();
}*/


/*

*     *
 *   *
  * *
   *
  * *
 *   *
*     *

*/


/*
for ( int outer=1;  outer<=4;  outer++ )
{
    for ( int space=2;  space<=outer; space++ )
    {
        Console.Write(" ");
    }
    Console.Write("*");

    for ( int space=2*outer; space<=6;  space++ )
    {
        Console.Write(" ");
    }
    
        if ( outer==4 )
        {
        Console.WriteLine();
        break;
        }
        Console.Write("*"); 
    
    Console.WriteLine();
}
for ( int outer=1; outer<=3; outer++)
{ 
    for ( int space=1; space<=3-outer; space++ )
    {
        Console.Write(" ");
    }
    Console.Write("*");

    for ( int space=1; space<=outer; space++ )
    {
        Console.Write(" ");
    }

    for ( int space=1; space<=outer-1; space++ )
    {
        Console.Write(" ");
    }
    Console.Write("*");
    Console.WriteLine();
}*/



/*

for (int row = 1; row <= 5; row++)

{

    Console.Write("*");


    for (int inner = 1; inner <= row - 2; inner++)

    {

        Console.Write(" ");

    }


    if (row != 1)

    {

        Console.Write("*");

    }


    for (int inner = 1; inner <= (5 - row) * 2; inner++)

    {

        Console.Write(" ");

    }

    Console.Write("*");


    for (int inner = 1; inner <= row - 2; inner++)

    {

        Console.Write(" ");

    }

    if (row != 1)

    {

        Console.Write("*");

    }


    Console.WriteLine();
}*/

/*


**********
*        *
*        *
*        *
*        *
*        *
*        *
*        *
*        *
**********


*/
/*
int row = 10;

for ( int i = 1; i <= row; i++ )
{
    for (int j = 1; j <= row; j++)
    {
        if (i == 1 || i == row || j == 1 || j == row)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}*/


//Hollow Pyramid

/*
int rows = 5;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= rows - i; j++)
        Console.Write(" ");

    for (int j = 1; j <= 2 * i - 1; j++)
    {
        if (j == 1 || j == 2 * i - 1 || i == rows)
            Console.Write("*");
        else
            Console.Write(" ");
    }

    Console.WriteLine();
}*/

