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
    if (dataSaver.ToLower() == "on")
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
using System.Reflection.Metadata;

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




