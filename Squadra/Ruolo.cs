using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squadra
{
    interface IRuolo{
        public class Atleti : IRuolo {
            public static void Goal(string Ruolo, int goalsubiti, int goalsegnati, int assist, int recuperopalla)
            {
                Console.Write("Ruolo giocatore: ");
                Ruolo = Console.ReadLine();


                if (Ruolo == "Portiere")
                {
                    Console.Write("Inserisci i goal subiti: ");
                    goalsubiti = Console.Read();
                }

                if (Ruolo == "Attaccante")
                {
                    Console.Write("Inserisci i goal effettuati: ");
                    goalsegnati = Console.Read();
                }

                if (Ruolo == "Difensore")
                {
                    Console.Write("Inserisci i recuperi palla: ");
                    recuperopalla = Console.Read();
                }

                if (Ruolo == "CentroCampista")
                {
                    Console.Write("Inserisci gli assist: ");
                    assist = Console.Read();
                }
            }
        }

    }
}
