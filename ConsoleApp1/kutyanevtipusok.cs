using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kutyanevtipusok
    {
        string magyarNev;
        string eredetiNev;

        public kutyanevtipusok(string tipusok)
        {
            string[] felosztas = tipusok.Split(';');
            this.magyarNev = felosztas[0];
            this.eredetiNev = felosztas[1];
        }


        public string MagyarNev { get => magyarNev;}
        public string EredetiNev { get => eredetiNev;}
    }
}
