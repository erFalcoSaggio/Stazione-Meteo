namespace Stazione_Meteo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StazioneMeteo stazioneMeteo = new StazioneMeteo();
            stazioneMeteo.barometro = 1300;
            Console.WriteLine(stazioneMeteo.barometro);
            stazioneMeteo.termometro = new int[] { 12, 88, 12, 12 };
            Console.WriteLine(stazioneMeteo.termometro[3]);
            stazioneMeteo.pluviometro = 1;
            Console.WriteLine(stazioneMeteo.pluviometro);
            stazioneMeteo.igrometro = 99;
            Console.WriteLine(stazioneMeteo.igrometro);
            stazioneMeteo.anemometro = 50;
            Console.WriteLine(stazioneMeteo.anemometro);
            Console.WriteLine(stazioneMeteo.reportTestuale());
            Console.WriteLine(stazioneMeteo.haPiovuto());
            stazioneMeteo.reset();
            Console.WriteLine(stazioneMeteo.reportTestuale());
        }
    }
}