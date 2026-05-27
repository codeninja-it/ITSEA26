// File Server
// 1) dovrà attendere una richiesta dell'utente (a.k.a. client)
// 2) dovrà capire quale file vuole
// 3) dovrà controllare se esiste
// 4) se esiste, dovrà inviarlo al client
// NOTA IMPORTANTE: quando l'utente mi chiede un file io lo chiudo
// in una cartella specifica e non lo faccio uscire di lì

using System.Net;
using System.Text;
using System.IO;

string indirizzo = "http://localhost:12345/";
string cartella = "c:\\test";

HttpListener telefono = new HttpListener();
telefono.Prefixes.Add(indirizzo);
telefono.Start();

do
{
    HttpListenerContext chiamata = telefono.GetContext();
    string richiesta = chiamata.Request.RawUrl;
    Console.WriteLine(richiesta);
    richiesta = richiesta.Replace("/", "");
    string percorso = Path.Combine(cartella, richiesta);
    Console.WriteLine(percorso);
    if (File.Exists(percorso))
    {
        // sì, il file esiste
        byte[] impulsi = File.ReadAllBytes(percorso);
        chiamata.Response.StatusCode = 200;
        if (percorso.EndsWith(".htm"))
            chiamata.Response.Headers.Add("Content-Type: text/html");

        chiamata.Response.OutputStream.Write(impulsi);
        chiamata.Response.Close();
    }
    else
    {
        // no, il file non esiste
        string messaggio = "File non trovato";
        byte[] impulsi = Encoding.UTF8.GetBytes(messaggio);
        chiamata.Response.StatusCode = 404;
        chiamata.Response.OutputStream.Write(impulsi);
        chiamata.Response.Close();
    }

} while (true);