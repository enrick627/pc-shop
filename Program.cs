// Enrick De Munter 5ITN nr4 2019/10/05
/* Analyse
 *Vraag welk artikel de persoon wil
 *Hvl stuks
 *wat is de prijs
 */
using System;

namespace pcshop
{
    class MainClass
    {
        static void Main(string[] args)
        {//DECLARATIES
            string input1, input2;
            string Artikel, ArtikelGROTELETTERS;
            int Stuks, eenheidsprijs;
            int Totaleprijs;

            //input
            //vraag naar de gegevens
            Console.Write("wat is de naam van het artikel?: ");
            Artikel = Console.ReadLine();

           

            Console.Write("Hoeveel stuks?: ");
            input1 = Console.ReadLine();
            Stuks = Convert.ToInt16(input1);

            Console.Write("Wat is de eenheidsprijs?: ");
            input2 = Console.ReadLine();
            eenheidsprijs = Convert.ToInt16(input2);

            //processing
            Totaleprijs = eenheidsprijs * Stuks;
            ArtikelGROTELETTERS = Artikel.ToUpper();

            //output
            Console.WriteLine(Stuks + " " + ArtikelGROTELETTERS);
            Console.WriteLine("kostprijs " + " $ " + Totaleprijs.ToString());
            Console.ReadLine();

            //wachten
            Console.WriteLine();
            Console.WriteLine("Druk op enter om af te sluiten: ");
            Console.WriteLine();
        }
    }
}
