using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class MegtakaritasiSzamla : Szamla
    {
        static public double alapKamat = 1.1;
        private double kamat;

        public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.kamat = alapKamat;
        }

        public double Kamat { get => kamat; set => kamat = value; }

        public override bool Kivesz(int osszeg)
        {
            if (osszeg > this.aktualisEgyenleg)
            {
                return false;
            }
            else
            {
                this.aktualisEgyenleg = this.aktualisEgyenleg - osszeg;
                return true;
            }


        }

        public void KamatJovairas()
        {
            this.aktualisEgyenleg = Convert.ToInt32(this.aktualisEgyenleg * this.kamat);
        }
    }
}
