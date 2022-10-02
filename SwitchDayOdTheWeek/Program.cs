// päring arvuti kellale, E-L on numbrid 1-6 ja pühapäev on number 0
int nädalapäev = Convert.ToInt32(DateTime.Now.DayOfWeek); // Convert.ToInt32 käsuga muudab nädalapäeva numbriks 0-6
switch (nädalapäev) // väärtus mida kontrollitakse on "nädalapäev"
{
    case 0: // see võrdne, kui kirjutada: if (nädalapäev == 0)
        Console.WriteLine("Täna on pühapäev");
        break;
    case 1:
        Console.WriteLine("Täna on esmaspäev");
        break;
    case 2:
        Console.WriteLine("Täna on teisipäev");
        break;
    case 3:
        Console.WriteLine("Täna on kolmapäev");
        break;
    case 4:
        Console.WriteLine("Täna on neljapäev");
        break;
    case 5:
        Console.WriteLine("Täna on reedepäev");
        break;
    case 6:
        Console.WriteLine("Täna on laupäev");
        break; // "break;" kasutatakse selleks, et hallata juhtumeid, kui väärtus ei ole võrdne ühegi pakutud väärtusega.
        default:
        Console.WriteLine("Oops. Teie kaldender on peab olema katki!");
        break; // ka siin tuleb kasutada "break;" lõpetamiseks
}
Console.WriteLine("Ilusat päeva");
