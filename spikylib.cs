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
//                                        LAST UPDATED: 12/10/2024
//                                                v.1.0.0
//
// Repository: https://github.com/spiky1987k/spikylib

//////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                   ///
////                                           (!) IMPORTS                                             ///
////                                                                                                   ///
//////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                   ///
////                                     (!) REGULAR EXPRESSIONS                                       ///
////                                                                                                   ///
//////////////////////////////////////////////////////////////////////////////////////////////////////////
static void print(string text)
{
    Console.WriteLine(text);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                   ///
////                                      (!) CUSTOM EXPRESSIONS                                       ///
////                                                                                                   ///
//////////////////////////////////////////////////////////////////////////////////////////////////////////
static void printc(string text, int color)
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
