using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //NullConditionalDemo();

            //PlayerCharacter[] players = new PlayerCharacter[]
            //{
            //    new PlayerCharacter { Name = "Sarah"},
            //    new PlayerCharacter(),
            //    null
            //};
            PlayerCharacter[] players = null;
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

        }

        private static void NullConditionalDemo()
        {
            PlayerCharacter player = new PlayerCharacter();
            player.DaysSinceLastLogin = 42;


            //PlayerDisplayer.Write(player);
            int days = player?.DaysSinceLastLogin ?? -1;


            Console.WriteLine(days);
        }
    }
}
