
using System;
    
Func<double, string> areaMessage = r => $"Aria cercului cu raza {r} este {Math.PI * r * r:F3}.";

Console.Write("Introduceți raza cercului: ");
if (double.TryParse(Console.ReadLine(), out var radius) && radius >= 0)
{
    Console.WriteLine(areaMessage(radius));
}
else
{
    Console.WriteLine("Valoare invalidă pentru rază.");
}
