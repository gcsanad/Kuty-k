using ConsoleApp1;

//2.Feladat
List<kutyak> kutyakNeve = new List<kutyak>(File.ReadAllLines("F:\\Us\\Csanád\\prog\\kutyák\\ConsoleApp1\\ConsoleApp1\\Adatok\\KutyaNevek.csv").Skip(1).Select(x => new kutyak(x)).ToList());

//3.Feladat
Console.WriteLine($"3.Feladat: {kutyakNeve.Count()}");

//4.Feladat
List<kutyanevtipusok> kutyaNevTipusok = new List<kutyanevtipusok>(File.ReadAllLines("F:\\Us\\Csanád\\prog\\kutyák\\ConsoleApp1\\ConsoleApp1\\Adatok\\KutyaFajtak.csv").Skip(1).Select(x => new kutyanevtipusok(x)).ToList());

//5.Feladat
List<kutyakminden> kutyaAdatok = new List<kutyakminden>(File.ReadAllLines("F:\\Us\\Csanád\\prog\\kutyák\\ConsoleApp1\\ConsoleApp1\\Adatok\\Kutyak.csv").Skip(1).Select(x => new kutyakminden(x)).ToList());

//6.Feladat
Console.WriteLine($"6.Feladat: {Math.Round(kutyaAdatok.Average(x => x.KutyaEletkora), 2)}");