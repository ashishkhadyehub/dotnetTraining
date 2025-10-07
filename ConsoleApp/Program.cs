
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