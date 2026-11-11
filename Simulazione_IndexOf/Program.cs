string frase;
char carattere;

Console.WriteLine("Inserire la frase");
frase = Console.ReadLine();
Console.WriteLine("inserire il carattere da ricercare");
carattere = Convert.ToChar(Console.ReadLine());

for (int i = 0;  i < frase.Length; i++)
{
    char carattere2 = frase[i];
    if(carattere2 == carattere2)
    {
        Console.WriteLine($"La lettera {carattere} compare in posizione {i}");
        break;
    }
    if (i == frase.Length - 1)
    {
        Console.WriteLine("La lettera non compare nella frase");
    }
}

