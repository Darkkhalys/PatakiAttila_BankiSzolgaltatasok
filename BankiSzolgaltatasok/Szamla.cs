using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class Szamla : BankiSzolgaltatas
    {
        private int aktualisEgyenleg;

        protected Szamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
        }

        protected int AktualisEgyenleg { get => aktualisEgyenleg;}
    }
}
