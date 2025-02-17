// Integer and string operations  
int num1 = 2;
int num2 = 5;
string name1 = "1";
string name2 = "1";

Console.WriteLine(num1 + num2); // Sum of integers  
Console.WriteLine(name1 + name2); // String concatenation  

// User input and greeting  
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "! :)");

// Integer addition from user input  
Console.WriteLine("Addition - Enter two integer values: ");
int val1 = int.Parse(Console.ReadLine());
int val2 = int.Parse(Console.ReadLine());
Console.WriteLine(val1 + val2);

// Age verification  
Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

// For loop counting from 0 to 9  
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Array iteration using for loop  
string[] names = { "Milly", "Lines", "Julis" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// While loop counting from 1 to 10  
int counter = 1;
while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

// Day of the week selection using switch case  
Console.WriteLine("Enter the day of the week (1-7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

// Wait for user input before closing  
Console.ReadKey();
