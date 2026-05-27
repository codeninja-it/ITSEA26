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

// chiedo all'utente il testo da convertire
Console.WriteLine("Testo da cifrare:");
string testo = Console.ReadLine();
// lo passo alla mia funzione
string cifrato = Cifra(testo, 150);
// ne mostro il risultato
Console.Write(cifrato);
Console.Write( (char)13 );
// e lo decifro
string decifrato = Cifra(cifrato, -150);
Console.WriteLine(decifrato);