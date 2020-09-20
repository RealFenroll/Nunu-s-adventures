using System;
using System.Collections.Generic;
using System.Text;

namespace Nunu_s_Adventures.Adventures
{
    public static class MakeTitles
    {
        public static void MenuTitleScreen()
        {
            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"         __  __                           __               ______      __                         __                                  ");
            Console.WriteLine(@"        /\ \/\ \                         /\ \             /\  _  \    /\ \                       /\ \__                               ");
            Console.WriteLine(@"        \ \ `\\ \  __  __    ___   __  __\ \/      ____   \ \ \L\ \   \_\ \  __  __     __    ___\ \ ,_\  __  __  _ __    __    ____  ");
            Console.WriteLine(@"         \ \ , ` \/\ \/\ \ /' _ `\/\ \/\ \\/      /',__\   \ \  __ \  /'_` \/\ \/\ \  /'__`\/' _ `\ \ \/ /\ \/\ \/\  __\/'__`\ /',__\ ");
            Console.WriteLine(@"          \ \ \`\ \ \ \_\ \/\ \/\ \ \ \_\ \      /\__, `\   \ \ \/\ \/\ \L\ \ \ \_/ |/\  __//\ \/\ \ \ \_\ \ \_\ \ \ \//\  __//\__, `\");
            Console.WriteLine(@"           \ \_\ \_\ \____/\ \_\ \_\ \____/      \/\____/    \ \_\ \_\ \_____\ \___/ \ \____\ \_\ \_\ \__\\ \____/\ \_\\ \____\/\____/");
            Console.WriteLine(@"            \/_/\/_/\/___/  \/_/\/_/\/___/        \/___/      \/_/\/_/\/____ /\/__/   \/____/\/_/\/_/\/__/ \/___/  \/_/ \/____/\/___/ ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nWelcome to the game of Nunu's Adventures!");
            Console.WriteLine("No Idea what this is about!");
        }

        public static void SFcreation()
        {
            Console.Clear();
            Console.WriteLine();

            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" ____                                  ____         ___               ____                          __                           ");
            Console.WriteLine(@"/\  _`\                               /\  _`\   __ /\_ \             /\  _`\                       /\ \__  __                    ");
            Console.WriteLine(@"\ \,\L\_\     __     __  __     __    \ \ \L\_\/\_\\//\ \      __    \ \ \/\_\  _ __    __     __  \ \ ,_\/\_\    ___     ___    ");
            Console.WriteLine(@" \/_\__ \   /'__`\  /\ \/\ \  /'__`\   \ \  _\/\/\ \ \ \ \   /'__`\   \ \ \/_/_/\`'__\/'__`\ /'__`\ \ \ \/\/\ \  / __`\ /' _ `\  ");
            Console.WriteLine(@"   /\ \L\ \/\ \L\.\_\ \ \_/ |/\  __/    \ \ \/  \ \ \ \_\ \_/\  __/    \ \ \L\ \ \ \//\  __//\ \L\.\_\ \ \_\ \ \/\ \L\ \/\ \/\ \ ");
            Console.WriteLine(@"   \ `\____\ \__/.\_\\ \___/ \ \____\    \ \_\   \ \_\/\____\ \____\    \ \____/\ \_\\ \____\ \__/.\_\\ \__\\ \_\ \____/\ \_\ \_\");
            Console.WriteLine(@"    \/_____/\/__/\/_/ \/__/   \/____/     \/_/    \/_/\/____/\/____/     \/___/  \/_/ \/____/\/__/\/_/ \/__/ \/_/\/___/  \/_/\/_/");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void SFLoad()
        {
            Console.Clear();
            Console.WriteLine();

            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" ____                                  ____         ___                    ");
            Console.WriteLine(@"/\  _`\                               /\  _`\   __ /\_ \                   ");
            Console.WriteLine(@"\ \,\L\_\     __     __  __     __    \ \ \L\_\/\_\\//\ \      __    ____  ");
            Console.WriteLine(@" \/_\__ \   /'__`\  /\ \/\ \  /'__`\   \ \  _\/\/\ \ \ \ \   /'__`\ /',__\ ");
            Console.WriteLine(@"   /\ \L\ \/\ \L\.\_\ \ \_/ |/\  __/    \ \ \/  \ \ \ \_\ \_/\  __//\__, `\");
            Console.WriteLine(@"   \ `\____\ \__/.\_\\ \___/ \ \____\    \ \_\   \ \_\/\____\ \____\/\____/");
            Console.WriteLine(@"    \/_____/\/__/\/_/ \/__/   \/____/     \/_/    \/_/\/____/\/____/\/___/ ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AdventureTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();

            //Create Title Banner
            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" ______      __                         __                                  ");
            Console.WriteLine(@"/\  _  \    /\ \                       /\ \__                               ");
            Console.WriteLine(@"\ \ \L\ \   \_\ \  __  __     __    ___\ \ ,_\  __  __  _ __    __    ____  ");
            Console.WriteLine(@" \ \  __ \  /'_` \/\ \/\ \  /'__`\/' _ `\ \ \/ /\ \/\ \/\`'__\/'__`\ /',__\ ");
            Console.WriteLine(@"  \ \ \/\ \/\ \L\ \ \ \_/ |/\  __//\ \/\ \ \ \_\ \ \_\ \ \ \//\  __//\__, `\");
            Console.WriteLine(@"   \ \_\ \_\ \___,_\ \___/ \ \____\ \_\ \_\ \__\\ \____/\ \_\\ \____\/\____/");
            Console.WriteLine(@"    \/_/\/_/\/__,_ /\/__/   \/____/\/_/\/_/\/__/ \/___/  \/_/ \/____/\/___/ ");

            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void CavernTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();

            //Create Title Banner
            Console.SetWindowSize(80, 50);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" ____                                               ");
            Console.WriteLine(@"/\  _`\                                             ");
            Console.WriteLine(@"\ \ \/\_\     __     __  __     __   _ __    ___    ");
            Console.WriteLine(@" \ \ \/_/_  /'__`\  /\ \/\ \  /'__`\/\`'__\/' _ `\  ");
            Console.WriteLine(@"  \ \ \L\ \/\ \L\.\_\ \ \_/ |/\  __/\ \ \/ /\ \/\ \ ");
            Console.WriteLine(@"   \ \____/\ \__/.\_\\ \___/ \ \____\\ \_\ \ \_\ \_\");
            Console.WriteLine(@"    \/___/  \/__/\/_/ \/__/   \/____/ \/_/  \/_/\/_/");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
