// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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
