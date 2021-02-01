using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffertenErsteller
{
    public class ArbeitsObjektList
    {
        public static ArbeitsObjekt[] ArbeitsObjekte { get; } = new ArbeitsObjekt[30]; // List for all Objects from preisListe.txt
        
        /*
         * Fills ArbeitsObjecte with all Names from the preisListe.txt
         */
        public static void FileReading()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\xdbat\source\repos\OffertenErsteller\OffertenErsteller\preisListe.txt");
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                string _name = "";
                float _preis = 0;
                string _typ = "";

                var something = line.Split(';');
                for (int a = 0; a < 3; a++)
                {
                    switch (a)
                    {
                        case 0:
                            _name = something[a];
                            break;
                        case 1:
                            _preis = float.Parse(something[a]);
                            break;
                        case 2:
                            _typ = something[a];
                            break;
                        default:
                            System.Console.WriteLine("Fehler");
                            break;
                    }
                }
                ArbeitsObjekte[count++] = new ArbeitsObjekt(_name, _preis, _typ);
            }
        }
    }
    
    /*
     * This class is needed to create an object from the preisListe.txt
     */
    public class ArbeitsObjekt
    {
        private readonly String _name;
        private readonly float _preis;
        private readonly String _stueckTyp;
        public String Name { get { return _name; } }
        public float Preis { get { return _preis; } }
        public String StueckTyp { get { return _stueckTyp; } }

        public ArbeitsObjekt(String Name, float Preis, String StueckTyp)
        {
            this._name = Name;
            this._preis = Preis;
            this._stueckTyp = StueckTyp;
        }
    }
}
