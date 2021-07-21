
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partita
{

    class Atleti
    {
        public static void Main(string[] args) { }


        public string Nome { set; get; }
        public string Cognome { set; get; }
        public string Età { set; get; }
        public string Ruolo { set; get; }
        public int NumeroMaglia { set; get; }
        public string Squadra { set; get; }
      

        public Atleti(string nome, string cognome, string eta, string ruolo, int numeromag)
        {


            Nome = nome;
            Cognome = cognome;
            Età = eta;
            Ruolo = ruolo;
            NumeroMaglia = numeromag;

        }

        
    }

    }

