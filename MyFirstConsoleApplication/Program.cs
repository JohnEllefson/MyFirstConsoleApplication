
/**************************************************************************
*  This was written for CSE 325 for the Week 1 Assignment by John Ellefson
***************************************************************************/

string name = "John Ellefson";
string location = "Texas";
DateOnly date = DateOnly.FromDateTime(DateTime.Now);
DateTime christmasDay = new DateTime(2023, 12, 25);
int daysTilChristmas = (christmasDay - DateTime.Now).Days;

// Print information
Console.WriteLine($"My name is {name}.");
Console.WriteLine($"I am from {location}.");
Console.WriteLine($"The date is {date}.");
Console.WriteLine($"There are {daysTilChristmas} days left until Christmas!");



// Add space between sections
Console.Write("\n\n\n");


 /***********************************************************************
 *  Edited example code from section 2.1 of "C# Programming Yellow Book"
 ************************************************************************/

double width, height, woodLength, glassArea;
string widthString, heightString;

Console.WriteLine("This is a Window Glazer Calculator");
Console.WriteLine("-----------------------------------\n");

// Request input from the user
Console.Write("Enter the width of the window: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.Write("Enter the height of the window: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

// Calculates the size of wood and glass necessary to make a window with given paramaters
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);

// Print the necessary wood and glass
Console.WriteLine("\nThe length of the wood is " +
woodLength + " feet");
Console.WriteLine("The area of the glass is " +
glassArea + " square metres");


// Prevent console from closing automatically
Console.ReadKey();