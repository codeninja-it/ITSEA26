// test per gli array
// campo minato

int grigliaDa = 6;
int celle = grigliaDa * grigliaDa;
float difficoltà = 0.2f;

int vite = 3;
int daTrovare = 0;

char[] campoDiBattaglia = new char[celle];

for (int i = 0; i < campoDiBattaglia.Length; i++)
{
    float seme = Random.Shared.NextSingle();
    bool mina = seme < difficoltà;
    if (mina)
        campoDiBattaglia[i] = 'X';
    else
    {
        campoDiBattaglia[i] = '_';
        daTrovare++;
    }
}

Console.WriteLine("Devi trovare " + daTrovare + " posizioni.");
for (int i = 0; i < campoDiBattaglia.Length; i++)
{
    int resto = (i+1) % grigliaDa;
    if(resto == 0)
        Console.WriteLine(campoDiBattaglia[i]);
    else
        Console.Write(campoDiBattaglia[i]);
}

while (vite > 0 && daTrovare > 0)
{
    Console.WriteLine("Hai " + vite + " vite rimaste.");
    Console.WriteLine("Devi trovare " + daTrovare + " posizioni.");
    // chiedo al giocatore di dormi la X e la Y
    Console.Write("Dimmi la X: ");
    int X = int.Parse( Console.ReadLine() );
    Console.Write("Dimmi la Y:");
    int Y = int.Parse( Console.ReadLine() );
    int casella = (Y * grigliaDa) + X;
    if(campoDiBattaglia[casella] == 'X')
    {
        Console.WriteLine("Hai trovato una mina!");
        vite--;
    }
    else
    {
        Console.WriteLine("Posizione sicura.");
        daTrovare--;
        campoDiBattaglia[casella] = 'O';
    }

    Console.ReadLine();
    Console.Clear();
}

if(vite == 0)
    Console.WriteLine("Sei morto!");
else
    Console.WriteLine("Hai vinto!");