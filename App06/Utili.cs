using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06
{
    public class Utili
    {
        // creo una mia funzione riutilizzabile
        public string Cifra(string daCifrare, int quantoSpostare)
        {
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
    }
}
