// creo la variabile numero che contiene 2
int numero = 2;
// creo anche la variabile rep(etitions) e dentro ci metto 10
int rep = 100000;
// definisco una variabile per ricordarmi a che punto sto
int esecuzioni = 1;

// "altGr + shift + é" o "altGr + shift + *"
do
{
    // scrivo all'utente il risultato
    Console.WriteLine(numero * esecuzioni);
    // e incremento il numero di esecuzioni già svolte
    esecuzioni = esecuzioni + 1;
    // e ripeto "fino a che" rimango entro il mio limite
} while (esecuzioni < rep);
