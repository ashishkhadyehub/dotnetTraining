
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter you Name: ");
//Console.WriteLine("---------");
////to get input from user
//string name = Console.ReadLine();
//Console.WriteLine($"Hello {name}");



////let, const, var
//int a = 10;
//int b = 80;
//Console.WriteLine(a + b);



using ConsoleApp;
using System.Collections;
using System.Reflection.Emit;

int myInt = 9;
double myDouble = myInt;



Console.WriteLine(myInt);
Console.WriteLine(myDouble);


double myDouble1 = 10.78;
int myInt1 = (int)myDouble1;
Console.WriteLine(myInt1);

//string username = Console.ReadLine();
//Console.WriteLine("Welcome " + username);

int num1 = 90;
int num2 = 200;
Console.WriteLine(num1 > num2);
Console.WriteLine(Math.Min(num1, num2));
Console.WriteLine(Math.Max(num1, num2));
Console.WriteLine("Square root of 625 is: " + Math.Sqrt(625));
Console.WriteLine(Math.Abs(-78));
Console.WriteLine(Math.Round(69.7888877777,2));

string company = "Microsoft";
Console.WriteLine(company.Length);
Console.WriteLine(company.ToUpper());
Console.WriteLine(company.ToLower());

string technology = "C# .NET";
Console.WriteLine(company+":"+technology);
Console.WriteLine($"{company}:{technology}");


int age = 19;
if (age >= 18)
{
    Console.WriteLine("You are eligible to vote");
}
else if(age == 17)
{
    Console.WriteLine("You will be eligible to vote next year");
}
else
{
    Console.WriteLine("You are not eligible to vote");
}

int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

int day = 10;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("No Match");
        break;
}
// Outputs "Thursday" (day 4)



//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

int i = 9;
do
{
    Console.WriteLine(i);
    i++;
}
while (i < 5);

// let arr = [20,30,90]


string[] cars = {"Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars.Length);
Console.WriteLine(cars[0]);
Array.Sort(cars);
foreach (string car in cars)
{
    Console.WriteLine(car);
}

int[] myNumbers = { 5, 1, 8, 9,90,100 };
Console.WriteLine(myNumbers.Max());  // returns the largest value
Console.WriteLine(myNumbers.Min());  // returns the smallest value
Console.WriteLine(myNumbers.Sum());  // returns the sum of elements


void Mymethod()
{
    Console.WriteLine("I just got executed!");
}

Mymethod();

void greeting(string name)
{
    Console.WriteLine($"Hello, {name}");
    //Console.WriteLine("Hello, " + name);
}

greeting("Shree");
greeting("Test");

Method_Overloading obj = new Method_Overloading();
Console.WriteLine(obj.PlusMethod(2,8));
Console.WriteLine(obj.PlusMethod(20.90,89.90));

//object initialization
Car mycar = new Car();

Console.WriteLine(mycar.Color);
Console.WriteLine(mycar.maxSpeed);
Console.WriteLine(mycar.model);
mycar.fullThrottle();

Car1 mycar1= new Car1();
mycar1.honk();
Console.WriteLine(mycar1.brand + "-" + mycar1.modelName);

Animal myanimal = new Animal();
Dog mydog = new Dog();
Pig pig = new Pig();

myanimal.animalSound();
mydog.animalSound();
pig.animalSound();

Tiger tiger = new Tiger();
tiger.animalSound();
tiger.sleep();

Lion lion = new Lion();
lion.animalSound();


Levels myVar = Levels.Medium;
Console.WriteLine($"{myVar}= " + (int)myVar);

string writeText = "Hello Students!";  // Create a text string
File.WriteAllText("demo.txt", writeText);  // Create a file and write the contents of writeText to it

string readText = File.ReadAllText("demo.txt"); // Read the contents of the file
Console.WriteLine(readText); // Output the content

try
{
    int[] myNumbers1 = { 1, 2, 3 };
    Console.WriteLine(myNumbers1[2]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//value type
int i1 = 1;

//reference type
object o = i1; // boxing 
int j = (int)o; // unboxing  


Console.WriteLine(Vehicle.AreEqual<double>(10.69,10.69));


ArrayList al = new ArrayList();
string str = "test";
int x = 7;
DateTime d = DateTime.Parse("8-oct-1985");
al.Add(str);
al.Add(x);
al.Add(d);

foreach (object o1 in al)
{
    Console.WriteLine(o1);

}

List<int> lst = new List<int>();
lst.Add(100);
lst.Add(200);
lst.Add(300);
lst.Add(400);
foreach (int item in lst)
{
    Console.WriteLine(item);

}

Vehicle v1 = new Vehicle();
v1.del("Testing delegate");



//test question answers


int number = 1234;
int reverse = 0;

while (number > 0)
{
    int digit = number % 10;      // get last digit
    Console.WriteLine(digit);
    reverse = (reverse * 10) + digit; // add digit to reverse number
    Console.WriteLine(reverse);
    number = number / 10;         // remove last digit 123.4
    Console.WriteLine("--------");
}

Console.WriteLine("Reversed Number: " + reverse);

int[] numbers = { 10, 20, 5, 15, 30 };
int max = numbers[0];
int index = 0;

for (int f = 1; f < numbers.Length; f++)
{
    if (numbers[f] > max)
    {
        max = numbers[f];
        index = f;
    }
}

Console.WriteLine("Maximum Number: " + max);
Console.WriteLine("Position (Index): " + index);

Console.Write("Enter a string: ");
string str1 = Console.ReadLine();

foreach (char ch in str1)
{
    Console.WriteLine(ch);
}




