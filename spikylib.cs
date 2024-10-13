//
//                                              _ _          _ _ _     
//                                             (_) |        | (_) |    
//                                    ___ _ __  _| | ___   _| |_| |__  
//                                   / __| '_ \| | |/ / | | | | | '_ \ 
//                                   \__ \ |_) | |   <| |_| | | | |_) |
//                                   |___/ .__/|_|_|\_\\__, |_|_|_.__/ 
//                                   | |                __/ |          
//                                   |_|               |___/           
// 
//                                          (c) 2024 spiky1987k
//                                        LAST UPDATED: 13/10/2024
//                                                v.1.1.0
//
// GitHub Repository: https://github.com/spiky1987k/spikylib

using System.Net;

namespace spikylib
{
    public class spikylib
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////                                                                                                   ///
        ////                                     (!) REGULAR EXPRESSIONS                                       ///
        ////                                                                                                   ///
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void printf(dynamic text)
        {
            Console.WriteLine(text);
        }

        public dynamic getline()
        {
            return Console.ReadLine();
        }

        public void sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        public void system(string type)
        {
            if (type == "PAUSE")
            {
                printf("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                string err_msg = "Type " + type +  " does not exist on 'slib.system'";
                error(err_msg);
            }
        }

        public void Beep(int hz, int ms)
        {
            Console.Beep(hz, ms);
        }

        public void ignore(int chars)
        {
            Console.ReadKey();

            chars = chars - 1;

            if (chars > 0)
            {
                for (int i = 0; i < chars; i++)
                {
                    Console.ReadKey();
                }

                clear();
            }
            else
            {
                string msg = "Incorrect arguments given for 'slib.ignore' (given " + chars + "). Are you trying to use 'slib.system' instead?";
                error(msg);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////                                                                                                   ///
        ////                                      (!) CUSTOM EXPRESSIONS                                       ///
        ////                                                                                                   ///
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void printc(dynamic text, int color)
        {
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (color == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (color == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else if (color == 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (color == 9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (color == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void lclear(int lines)
        {
            if (lines > 0)
            {
                for (int i = 0; i < lines; i++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
            }
            else
            {
                string msg = "Incorrect arguments given for 'slib.lclear' (given " + lines + "). Are you trying to use 'slib.clear' instead?";
                error(msg);
            }
        }

        public void clear()
        {
            Console.Clear();
        }

        public bool isStrNum(string value)
        {
            return int.TryParse(value, out int n);
        }

        public bool isStrDecNum(string value)
        {
            return float.TryParse(value, out float n);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////                                                                                                   ///
        ////                                            (!) SLIB                                               ///
        ////                                                                                                   ///
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void error(string err)
        {
            string msg = "[!] slib: " + err + " :(";
            printc(msg, 1);
        }

        private void notify(string note)
        {
            string msg = "[!] slib: " + note + " :(";
            printc(msg, 7);
        }

        public void updateCheck()
        {
            string currentVersion = "1.0.1";

            var paste = "https://pastebin.com/raw/bSXu0vWR";
            string version = "";
            int i = 0;
            var client = new WebClient();
            using (var stream = client.OpenRead(paste))
            using (var reader = new StreamReader(stream))
            {
                version = reader.ReadLine();
            }

            if (version != currentVersion)
            {
                string msg = "There is a newer version of slib available (" + version + "). You are currently on " + currentVersion;
                error(msg);
            }
            else if (version == currentVersion)
            {
                string msg = "You are up to date with slib! Current version: v" + version;
                notify(msg);
            }
        }
    }
}
