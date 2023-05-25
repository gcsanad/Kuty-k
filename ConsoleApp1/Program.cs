using ConsoleApp1;

//2.Feladat
List<kutyak> kutyak = new List<kutyak>(File.ReadAllLines("F:\\Us\\Csanád\\prog\\kutyák\\ConsoleApp1\\ConsoleApp1\\Adatok").Select(x => new kutyak(x)).Skip(1).ToList());

//3.Feladat
Console.WriteLine($"3.Feladat: {kutyak.Count()}");

//4.Feladat
