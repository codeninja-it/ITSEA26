using App06;

Utili mieFunzioni = new Utili();

// chiedo all'utente il testo da convertire
Console.WriteLine("Testo da cifrare:");
string testo = Console.ReadLine();
// lo passo alla mia funzione
string cifrato = mieFunzioni.Cifra(testo, 150);
// ne mostro il risultato
Console.Write(cifrato);
Console.Write( (char)13 );
// e lo decifro
string decifrato = mieFunzioni.Cifra(cifrato, -150);
Console.WriteLine(decifrato);