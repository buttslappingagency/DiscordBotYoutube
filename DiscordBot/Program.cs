using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DiscordBot
{
    /// <summary>
    /// Classe de threading
    /// </summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        { 
            Console.Title = "Discord Youtube Bot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            CommandReading:
            string command = Console.ReadLine();

            if(command == "help")
            {
                Console.WriteLine("help: affiche cet écran d'aide" + Environment.NewLine + "gnu: affiche la licence GNU de ce logiciel" + Environment.NewLine + "listen: met en écoute les actions d'upload de façon permanente");
                goto CommandReading;
            }
            else if(command == "gnu")
            {
                Process.Start("http://www.gnu.org/licenses/gpl.html");
                goto CommandReading;
            }
            else if(command == "listen")
            {
                goto CommandReading;
            }
            else
            {
                Console.WriteLine("Commande invalide. Essayez 'help'!");
                goto CommandReading;
            }
        }
    }
}
