string frase;
char carattere;
int i = 0;
bool found = false;

Console.WriteLine("Inserire la frase");
frase = Console.ReadLine();
Console.WriteLine("inserire il carattere da ricercare");
carattere = Convert.ToChar(Console.ReadLine());

for (i = 0; i < frase.Length; i++)
{
    char carattere2 = frase[i];
    if (carattere == carattere2)
    {
        found = true;
        break;
    }
}
if (found == true)
{
    Console.WriteLine($"La lettera compare in posizione {i}");
}
else
{
    Console.WriteLine("La lettera compare in posizione -1");
}