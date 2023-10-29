namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tulajdonos tulajdonos1 = new Tulajdonos("Lajkós Titanilla");
            Tulajdonos tulajdonos2 = new Tulajdonos("Dermina Cleopátra");
            Tulajdonos tulajdonos3 = new Tulajdonos("Asztrál Vas");

            Bank bank = new Bank();

            try
            {
                bank.SzamlaNyitas(tulajdonos1, -1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Szamla szamla1 = bank.SzamlaNyitas(tulajdonos1, 0);
            szamla1.Befizet(13000);

            Szamla szamla2 = bank.SzamlaNyitas(tulajdonos2, 6000);
            szamla2.Befizet(6000);

            Szamla szamla3 = bank.SzamlaNyitas(tulajdonos3, 1500);
            szamla3.Befizet(8500);
            szamla3.Befizet(3000);

            Szamla szamla4 = bank.SzamlaNyitas(tulajdonos3, 1500);
            szamla4.Befizet(2000);



            Console.WriteLine("Új kártya igénylése");
            Kartya kartya1 = szamla1.UjKartya("6666 6666 6666 6666");
            Console.WriteLine($"Kártyaszám: {kartya1.KartyaSzam} Tulajdonos: {kartya1.Tulajdonos.Nev}");
            Console.WriteLine("Vásárlás");
            Console.WriteLine($"Egyenleg vásárlás előtt: {szamla1.AktualisEgyenleg} ft");
            if (kartya1.Vasarlas(20000))
            {
                Console.WriteLine("Sikeres vásárlás");
                Console.WriteLine($"Egyenleg vásárlás után: {szamla1.AktualisEgyenleg} ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen vásárlás\n");
            }




            MegtakaritasiSzamla sz = (MegtakaritasiSzamla)szamla1;
            Console.WriteLine("Kamatjóváírás");
            Console.WriteLine($"Egyenleg kamatjóváírás előtt: {sz.AktualisEgyenleg} Ft");
            sz.KamatJovairas();
            sz.KamatJovairas();
            Console.WriteLine($"Egyenleg kamatjóváírás után: {sz.AktualisEgyenleg} Ft\n");




            Console.WriteLine("Pénz kivétel hitelszámláról");
            Console.WriteLine($"Egyenleg pénzkivétel előtt: {szamla2.AktualisEgyenleg} Ft");
            if (szamla2.Kivesz(2000))
            {
                Console.WriteLine("Sikeres pénzkivétel");
                Console.WriteLine($"Egyenleg pénzkivétel után: {szamla2.AktualisEgyenleg} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel\n");
            }




            Console.WriteLine("Pénz kivétel megtakarításszámláról");
            Console.WriteLine($"Egyenleg pénzkivétel előtt: {szamla1.AktualisEgyenleg} Ft");
            if (szamla1.Kivesz(600))
            {
                Console.WriteLine("Sikeres pénzkivétel");
                Console.WriteLine($"Egyenleg pénzkivétel után: {szamla1.AktualisEgyenleg} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel\n");
            }


            Console.WriteLine($"Bank által kiosztott hitelkeret összege: {bank.OsszHitelkeret} Ft\n");

            Console.WriteLine($"{tulajdonos3.Nev} összegyenlege: {bank.GetOsszEgyenleg(tulajdonos3)} Ft\n");

            Console.WriteLine($"{tulajdonos3.Nev} legnagyobb egyenlege: {bank.GetLegnagyobbEgyenleguSzamla(tulajdonos3).AktualisEgyenleg} Ft\n");
        }
    }
}