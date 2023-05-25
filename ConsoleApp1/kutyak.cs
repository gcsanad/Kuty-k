using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kutyak
    {
        int azonosito;
        string kutyaNeve;

        public kutyak(string sor)
        {
            string[] felosztas = sor.Split(';');
            this.azonosito = int.Parse(felosztas[0]);
            this.kutyaNeve = felosztas[1];
        }

        public int Azonosito { get => azonosito;}
        public string KutyaNeve { get => kutyaNeve;}
    }
}
