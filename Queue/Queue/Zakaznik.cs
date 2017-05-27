using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    sealed class Zakaznik
    {
            private static Random random = new Random();
            public string Jmeno { get; set; }

            public Zakaznik()
            {
                string[] jmena = {"David", "Adam", "Richard", "Martin", "Sam",
                                                  "Drahomír", "Vlastimil", "Michael", "Štěpán", "Petr"};
                Jmeno = jmena[random.Next(jmena.Length)];
            }

            public override string ToString()
            {
                return Jmeno;
            }
    }
}
