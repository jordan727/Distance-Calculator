// Distance Calculator by Jordan A
#nullable disable
Console.Clear();

// Welcome
Console.WriteLine("Welcome to the Distance Calculator");

// Input
Console.Write("Enter x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// Output
double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine($"Distance between points is {distance}.");