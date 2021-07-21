using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partita
{
    class Partita : Atleti{

        public string Arbitro { set; get; }


        public Partita (string nome, string cognome, string eta, string ruolo, int numeromag, string arbitro)
           : base(nome, cognome, eta, ruolo, numeromag){
            Arbitro = arbitro;

            if (ruolo == "Portiere") { IReadOnlyDictionary NumeroMaglia = 1; }
        }


        
    }
}
