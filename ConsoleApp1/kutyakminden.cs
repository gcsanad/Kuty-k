using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kutyakminden
    {
        int vizsgaAzon;
        int fajAzon;
        int nevAzon;
        int kutyaEletkora;
        string vizsgalatIdeje;

        public kutyakminden(string adatok)
        {
            string[] felosztas = adatok.Split(';');
            this.vizsgaAzon = int.Parse(felosztas[0]);
            this.fajAzon = int.Parse(felosztas[1]);
            this.nevAzon = int.Parse(felosztas[2]);
            this.kutyaEletkora = int.Parse(felosztas[3]);
            this.vizsgalatIdeje = felosztas[4];
        }


        public int VizsgaAzon { get => vizsgaAzon;}
        public int FajAzon { get => fajAzon;}
        public int NevAzon { get => nevAzon;}
        public int KutyaEletkora { get => kutyaEletkora;}
        public string VizsgalatIdeje { get => vizsgalatIdeje;}
    }
}
