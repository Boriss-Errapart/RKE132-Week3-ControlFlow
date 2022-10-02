// küsime kasutaja käest sisestada mingisugune arv

Console.WriteLine("Sisesta lemmik arv:");
int lemmikarv = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris või paaritu

int tulemus = lemmikarv % 2;
Console.WriteLine(tulemus);

if (tulemus != 0) // hüümärk tähendab, ei võrdu == tähendab, et on võrdsed
    Console.WriteLine("Valitud number on paaritu"); // Sulge {} ei pea tingimata kasutama 
else
    Console.WriteLine("Valitud number on paarisarv");
