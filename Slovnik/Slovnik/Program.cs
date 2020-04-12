using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



/* ZADÁNÍ
 * 
 * Napište aplikaci pro překládání slovíček z jednoho jazyka do druhého.
 * 
 * Vytvořte třídy a metody, s jejichž pomocí budete možno realizovat slovník EN - CZ i CZ - EN (můžete zvolit jiné dva jazyky). 
 * Počítejte s tím, že k zadanému slovíčku může existovat více významů.
 * 
 */


    /* POKYNY PRO SPUŠTĚNÍ
     * 
     *  1. Vytvořit DB z přiloženého Query
     *  
     *  2. Nastavit <connectionStrings> jenž se nachází v app.config.
     * 
     */


///-----------------------------------------------------------------
///   Namespace:      <Class Namespace>
///   Class:          <Class Name>
///   Description:    <Description>
///   Author:         <Author Michal Chamrád>                    Date: <11.1.2020>
///   Notes:          <Notes>
///-----------------------------------------------------------------

namespace Slovnik
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
