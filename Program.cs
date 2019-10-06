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
            int aantalartikelen, prijs, tebetalen;
            string artikel;

            //input
            Console.Write("welk artikel?: ");
            artikel =  Console.ReadLine();
            Console.Write("wat is de prijs?: ");
            prijs = Convert.ToInt32(Console.ReadLine());
            Console.Write("aantalartikelen = ");
            aantalartikelen = Convert.ToInt16(Console.ReadLine());
            
            //processing
            tebetalen = (aantalartikelen * prijs);
            //output
            Console.WriteLine("Totaal te betalen = " + tebetalen.ToString());
            Console.ReadLine();
        }
    }
}
