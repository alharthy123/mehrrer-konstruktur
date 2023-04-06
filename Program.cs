using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mehrrer_konstruktur
{
    
        class Mensch
        {
            //Eigenschaften
            public int Alter;
            public string Vorname, Name, Augenfarbe;

            //Konstruktor mit 4 Argumenten
            public Mensch(string vorname, string name, int alter, string augenfarbe)
            {
                Vorname = vorname;
                Name = name;
                Alter = alter;
                Augenfarbe = augenfarbe;
            }

            //Konstruktor mit 3 Argumenten
            public Mensch(string vorname, string name, int alter)
            {
                Vorname = vorname;
                Name = name;
                Alter = alter;

            }

            //Konstruktor mit 2 Argumenten
            public Mensch(string vorname, string name)
            {
                Vorname = vorname;
                Name = name;
            }
            //Konstruktor mit 1 Argument
            public Mensch(string vorname)
            {
                Vorname = vorname;
            }

            //Beispiel für eine Methode
            public void sichVorstellen()
            {

                if (Alter != 0 && Augenfarbe != null && Name != null)
                {
                    Console.WriteLine("Ich heiße " + Vorname + " " + Name + " und bin " + Alter +
                        " Jahre alt und meine Augen sind " + Augenfarbe + ".");
                }
                if (Augenfarbe == null && Alter != 0 && Name != null)
                {
                    Console.WriteLine("Ich heiße " + Vorname + " " + Name + " und bin "
                        + Alter + "Jahre alt.");
                }
                if (Augenfarbe == null && Alter == 0 && Name != null)
                {
                    Console.WriteLine("Ich heiße " + Vorname + " " + Name + ".");
                }
                if (Augenfarbe == null && Alter == 0 && Name == null)
                    Console.WriteLine("Ich heiße " + Vorname + ".");

            }
        }
    
        class Program
        {
            static void Main(string[] args)
            {
                //Anlegen von Objekten der Klasse
                Mensch d = new Mensch("Denis", "Müller", 28, "Grün");
                Mensch m = new Mensch("Michi", "Schmidt", 35);
                Mensch h = new Mensch("Heidi", "Zaun");

                Mensch ich = new Mensch("Hannah");



                //Aufrufen der Methoden der Klasse
                d.sichVorstellen();
                m.sichVorstellen();
                h.sichVorstellen();

                ich.sichVorstellen();

                Console.WriteLine("\n");
                Console.ReadLine();
                Console.WriteLine("\nStellen Sie sich mit Ihrem Vornamen vor!");
                Console.ReadLine();
                Console.Write("Vorname: ");
                string vorname = Console.ReadLine();
                Mensch ich2 = new Mensch(vorname);
                ich2.sichVorstellen();


                Console.WriteLine("\n");
                Console.ReadLine();
                Console.WriteLine("\nStellen Sie sich mit Ihrem vollständigen Namen vor!");
                Console.ReadLine();
                Console.Write("Vorname: ");
                vorname = Console.ReadLine();
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Mensch ich3 = new Mensch(vorname, Name);
                ich3.sichVorstellen();
                Console.WriteLine("\n");
                Console.ReadLine();
                Console.WriteLine("\n\nUnd jetzt werden noch einmal beide Vorstellungen ausgegeben");
                ich2.sichVorstellen();
                ich3.sichVorstellen();


                Console.ReadLine();
            }
            
        }
    
}
