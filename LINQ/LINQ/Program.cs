using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*Vytvořte vhodnou kolekci (List, LinkedList, atd.), do které budete vkládat města. U každého města znáte jeho jméno a počet obyvatel. V kolekci vyhledejte všechna města:

- jejichž počet obyvatel přesahuje zadanou hodnotu. 

- dále vyhledejte všechna města, jejichž jméno je delší než zadaná hodnota.

Vyhledávání proveď pomocí linq i pomocí delegata.
*/

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<mesto> m = new List<mesto>();

            m.Add(new mesto("Praha", 1000000));
            m.Add(new mesto("Brno", 300000));
            m.Add(new mesto("Plzeň", 200000));
            m.Add(new mesto("Ostrava", 150000));

            var linqQuery = from mesto in m
                            where mesto.PocetObyvatel > 30000
                            select mesto;


            foreach(var mesto in linqQuery)
            {
                Console.WriteLine(mesto);
            }
            Console.ReadLine();

        }
    }
}
