// päring arvuti kellale, E-L on numbrid 1-6 ja pühapäev on number 0
int nädalapäev = Convert.ToInt32(DateTime.Now.DayOfWeek); // Convert.ToInt32 käsuga muudab nädalapäeva numbriks 0-6
if (nädalapäev == 0)
    Console.WriteLine("Täna on pühapäev");
else if (nädalapäev == 1)
    Console.WriteLine("Täna on esmaspäev");
else if (nädalapäev == 2)
    Console.WriteLine("Täna on teisipäev");
else if (nädalapäev == 3)
    Console.WriteLine("Täna on kolmapäev");
else if (nädalapäev == 4)
    Console.WriteLine("Täna on neljapäev");
else if (nädalapäev == 5)
    Console.WriteLine("Täna on reedepäev");
else if (nädalapäev == 6)
    Console.WriteLine("Täna on laupäev");
Console.WriteLine("Ilusat päeva");
