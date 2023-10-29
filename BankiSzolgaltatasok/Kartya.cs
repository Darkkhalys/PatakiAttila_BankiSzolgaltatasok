using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Kartya : BankiSzolgaltatas
    {
        private Szamla szamla;
        private string kartyaSzam;

        public Kartya(Szamla szamla, string kartyaSzam,Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.szamla = szamla;
            this.kartyaSzam = kartyaSzam;
        }

        public string KartyaSzam { get => kartyaSzam; }
    }
}
