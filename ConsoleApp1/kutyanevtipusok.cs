using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kutyanevtipusok
    {
        int azonosito;
        string magyarNev;
        string eredetiNev;

        public kutyanevtipusok(string tipusok)
        {
            string[] felosztas = tipusok.Split(';');
            this.azonosito = int.Parse(felosztas[0]);
            this.magyarNev = felosztas[1];
            this.eredetiNev = felosztas[2];
        }


        public string MagyarNev { get => magyarNev;}
        public string EredetiNev { get => eredetiNev;}
        public int Azonosito { get => azonosito;}
    }
}
