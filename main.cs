using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("What Speed is the Hurricane?");
    string Speed = Console.ReadLine();
   double windSpeed;
    
    while (!double.TryParse(Speed, out windSpeed) || windSpeed < 0)
    {
        Console.WriteLine("Please enter a valid positive integer for the wind speed:");
       
    }
    if (windSpeed >= 157)
    Console.WriteLine("The Hurricane is a Category 5");
    else if (windSpeed >= 130)
    Console.WriteLine("The Hurricane is a Category 4");
    else if (windSpeed >= 111)
    Console.WriteLine("The Hurricane is a Category 3");
    else if (windSpeed >= 96)
    Console.WriteLine("The Hurricane is a Category 2");
    else if (windSpeed >= 74)
    Console.WriteLine("The Hurricane is a Category 1");
    else
    Console.WriteLine("The Hurricane is not a hurricane");
  }
}