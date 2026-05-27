using System.Net;
using System.Text;

// faccio un test per vedere se su console posso scrivere
string URL = "http://localhost:12345/";
// informando l'utente che il server è online
Console.WriteLine("il server è online all'indirizzo " + URL);


// cosrtuisco il mio telefono
HttpListener telefono = new HttpListener();
// lo attesto al numero
telefono.Prefixes.Add(URL);
// e lo accendo
telefono.Start();
// creo un contatore per le chiamate
int visite = 0;

do
{
    // attendo la chiamata
    HttpListenerContext chiamata = telefono.GetContext();
    // mi segno la nuova chimata come presa
    visite = visite + 1;
    // quando arriva, avverto l'amministratore
    Console.WriteLine("è arrivata una chiamata!");
    string cosaMiChiede = chiamata.Request.RawUrl;
    // scrivo il messaggio di risposta usando la sua domanda
    string messaggio = "Benvenuto su questo server! <b>Sei</b> il visitatore numero " + visite;
    messaggio = messaggio + "<br>Hai chiesto: " + cosaMiChiede;
    messaggio = messaggio + "<br>Se vuoi andare su <a href='https://www.google.com'>google</a> clicca qui.";
    messaggio = messaggio + "<br>Se vuoi cambiare <a href='/avvia/programma/3'>comando</a> clicca qui.";
    // la traduco in impulsi
    byte[] impulsi = Encoding.UTF8.GetBytes(messaggio);
    // imposto il tipo di contenuto della lettera
    chiamata.Response.Headers.Add("Content-Type: text/html");
    // la invio al destinatario
    chiamata.Response.OutputStream.Write(impulsi);
    // e alla fine riattacco.
    chiamata.Response.Close();

} while (true);