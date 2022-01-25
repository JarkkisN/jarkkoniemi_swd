// Jarkko Niemi - INTIP21A6
// 15.01.2022
// Ohjelma, joka kysyy "Montako lukua", kysyy luvut ("Anna luku") ja laskee niistä keskiarvon ja näytetään se.

// muuttujat

int count;
int i = 1;
double userInput;
double average, sum = 0;

// kysytään käyttäjältä lukujen määrä
Console.WriteLine("Montako lukua?: ");
count = Convert.ToInt32(Console.ReadLine());

// while looppi
while (i <= count)
{
    // kysytään luvut yksitellen
    Console.WriteLine("Anna " + i + ".luku: ");
    userInput = Convert.ToInt32(Console.ReadLine());
    sum += userInput;
    i++;
}

// lopputulos - lukujen summa jaetaan lukujen määrällä - sillä saadaan lukujen keskiarvo
average = sum / count;
Console.WriteLine("Lukujen keskiarvo on: " + average);
Console.WriteLine("Ratkaisun tarjosi: Jarkko Niemi");