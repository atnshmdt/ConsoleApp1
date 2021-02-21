using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto
    {

        // Attribute
        private string form;
        private string hupton;
        private int preis;
        private int geschwindigkeit;
        private readonly int schrittgeschwindigkeit = 7;
        // gangschaltung

        // Konstruktor
        public Auto(string form, int preis)
        {
            this.form = form;
            this.preis = preis;
        }

        public Auto(int preis)
        {
            this.form = "SUV";
            this.preis = preis;
        }

        // Methoden
        public void Fahr()
        {
            Console.WriteLine("Ich fahre gerade:" + geschwindigkeit);
        }

        public void Hupe()
        {
            Console.WriteLine("Ich hupe: " + hupton);
        }

        public void Schrittgeschwindigkeit()
        {
            Console.WriteLine("Ich fahre jetzt Schrittgeschwindigkeit.");

            int bremsung = geschwindigkeit - schrittgeschwindigkeit;

            Console.WriteLine("Bremsung: " + bremsung + "km/h");

            SetGeschwindigkeit(schrittgeschwindigkeit);
        }

        public int GetPreis()
        {
            return this.preis;
        }

        public string GetForm()
        {
            return this.form;
        }

        public void SetHupton(string hupton) // Setter gibt nie etwas zurück 
        {
            this.hupton = hupton;
        }

        public void SetGeschwindigkeit(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
        }


    }
}
