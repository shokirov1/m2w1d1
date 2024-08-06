using m2w1d1.Task1;
using m2w1d1.Task2;
using m2w1d1.Task3;
using m2w1d1.Task4;
using m2w1d1.Task5;



//Task-1
Console.WriteLine();
Console.WriteLine("--------------Task-1--------------");
Console.WriteLine();

Counter.Increment();
Counter.Increment();
Counter.Reset();
Console.WriteLine(Counter.count);
Console.WriteLine();

//Task-2
Console.WriteLine();
Console.WriteLine("--------------Task-2--------------");
Console.WriteLine();

DatabaseManager.OpenConnection();
DatabaseManager.CloseConnection();
Console.WriteLine();

//Task-3
Console.WriteLine();
Console.WriteLine("--------------Task-3--------------");
Console.WriteLine();

double a = 10;
double b = 5;

Console.WriteLine($"{Calculator.Add(a,b)}");
Console.WriteLine($"{Calculator.Subtract(a, b)}");
Console.WriteLine($"{Calculator.Multiply(a, b)}");
Console.WriteLine($"{Calculator.Divide(a, b)}");
Console.WriteLine();

//Task-4
Console.WriteLine();
Console.WriteLine("--------------Task-4--------------");
Console.WriteLine();

double? c = 20;
double? f = 50;
Console.WriteLine($"{TemperatureConverter.CelsiusToFahrenheit(a)}");
Console.WriteLine($"{TemperatureConverter.FahrenheitToCelsius(f)}");
Console.WriteLine($"{TemperatureConverter.CelsiusToKelvin(c)}");
Console.WriteLine();

//Task-5
Console.WriteLine();
Console.WriteLine("--------------Task-5--------------");
Console.WriteLine();

double meters = 500;
double kilometers = 2;
double decimeters = 50;

Console.WriteLine($"Meters to Kilometers: {Calculator2.MetersToKilometers(meters)} km");
Console.WriteLine($"Kilometers to Meters: {Calculator2.KilometersToMeters(kilometers)} m");
Console.WriteLine($"Meters to Decimeters: {Calculator2.MetersToDecimeters(meters)} dm");
Console.WriteLine($"Decimeters to Centimeters: {Calculator2.DecimetersToCentimeters(decimeters)} cm");
Console.WriteLine();
Console.WriteLine("----------------------------------");
Console.ReadKey();









