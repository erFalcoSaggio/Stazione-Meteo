using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stazione_Meteo
{
    internal class StazioneMeteo
    {
        // variabili
        int mid;
        static int cont = 0;
        int mbarometro; // serve per evitare l'overflow
        public int barometro {
            get
            {
                return mbarometro;
            }
            set 
            {
                if (value > 870 && value < 1085)
                {
                    mbarometro = value;
                }
            }
        }
        int[] mtermometro = new int[4];
        public int[] termometro {
            get 
            {
                return mtermometro; 
            } 
            set 
            {
                for (int i = 0; i < mtermometro.Length; i++)
                {
                    if (value[i] > -50 && value[i] < 60)
                    {
                        mtermometro[i] = value[i];
                    }
                }
            }
        }
        int mpluviometro;
        public int pluviometro
        {
            get 
            { 
                return mpluviometro; 
            } 
            set 
            { 
                if (value >= 0 && value <= 1000)
                {
                    mpluviometro = value;
                }
            }
        }
        int migrometro;
        public int igrometro
        {
            get 
            {
                return migrometro;
            }
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    migrometro = value;
                }
            }
        }
        int manemometro;
        public int anemometro
        {
            get
            {
                return manemometro;
            }
            set
            {
                if (value >= 0 && value <= 300)
                {
                    manemometro = value;
                }
            }
        }


        // costruttore di def
        public StazioneMeteo() {
            mid = cont;
            cont++;
            barometro = 1013; // hPa                             
            termometro = new int[] { 15, 13, 18, 17 }; // °C     
            pluviometro = 0; // mm (nessuna pioggia)             
            igrometro = 60; // %                                 
            anemometro = 10; // km/h                             
        }                                                        

        public string reportTestuale() {
            return mbarometro.ToString() + " "
                   + mtermometro[0].ToString() + " "
                   + mtermometro[1].ToString() + " "
                   + mtermometro[2].ToString() + " "
                   + mtermometro[3].ToString() + " "
                   + mpluviometro.ToString() + " "
                   + migrometro.ToString() + " "
                   + manemometro.ToString();
        }

        public bool haPiovuto()
        {
            if (mpluviometro == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void reset()
        {
            StazioneMeteo stazione = new StazioneMeteo();

            this.id = stazione.id;
            this.barometro = stazione.barometro;
            this.termometro = stazione.termometro;
            this.pluviometro = stazione.pluviometro;
            this.igrometro = stazione.igrometro;
            this.anemometro = stazione.anemometro;
        }
    }
}
