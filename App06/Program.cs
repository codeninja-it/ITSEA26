// creo una mia funzione riutilizzabile
string Cifra(string daCifrare, int quantoSpostare) {
    // e lo voglio cifrare
    string testoCifrato = "";
    // scorrendo ogni lettera del mio testo
    for (int i = 0; i < daCifrare.Length; i++)
    {
        // posso recuperare ogni carattere
        char lettera = daCifrare[i];
        // convertirlo a numero (su base ASCII)
        int numero = (int)lettera;
        // e spostarlo
        numero = numero + quantoSpostare;
        // per poi appenderlo nel nuovo testo
        testoCifrato = testoCifrato + (char)numero;
    }
    return testoCifrato;
}

// fatto ciò posso vedere entroambi i testi
Console.WriteLine("Testo da cifrare:");
string testo = Console.ReadLine();
string cifrato = Cifra(testo, 1);
Console.WriteLine(testo);
Console.WriteLine(cifrato);