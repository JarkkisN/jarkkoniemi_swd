// Jarkko Niemi - INTIP21A6
// 15.01.2022
// Ohjelma, joka kysyy "Yhteen- vai vähennyslasku (+/-)", kysyy 2 lukua, laskee valitun toiminnan ja tulostaa lopputuloksen


// ohjelma on while loopissa, kun syöttää virheen, ohjelma toistuu
while (true)
{
    // muuttujat
    string plussa = "+";
    string miinus = "-";
    string userInput;
    double numero1;
    double numero2;
    double result;

    Console.WriteLine("Kahden luvun yhteen- tai vähennyslasku");
    Console.WriteLine("Kirjoita + tai -");
    userInput = Console.ReadLine();

    if (userInput == plussa)
    {
        Console.WriteLine("Yhteenlasku");
        Console.WriteLine("Anna 1.numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Anna 2.numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        result = numero1 + numero2;
        Console.WriteLine("Summa on: " + result);
        break; // katkaisee loopin - tässä tapauksessa ohjelma päättyy
    }

    if (userInput == miinus)
    {
        Console.WriteLine("Vähennyslasku");
        Console.WriteLine("Anna 1.numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Anna 2.numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        result = numero1 - numero2;
        Console.WriteLine("Erotus on: " + result);
        break; // katkaisee loopin - tässä tapauksessa ohjelma päättyy
    }

    else
    {
        Console.WriteLine("Syötit jotain väärin.... Otetaan uudestaan.");
        continue; // loop jatkuu - ohjelma alkaa alusta tässä tapauksessa
    }
}