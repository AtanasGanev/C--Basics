using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _12.FallingRocks
{

    class FallingRocks
    {
        static void ResetBuffer()
        {
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
        }

        static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintStringAtPosition(int x, int y, string text, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(text);
        }

        struct Unit
        {
            public int x;
            public int y;
            public ConsoleColor color;
            public char symbol;
        }

        static void Main()
        {
            ResetBuffer();
            Random randomGenerator = new Random();
            List<Unit> RocksList = new List<Unit>();
            int livesCount = 1;
            int score = 0;
            char[] symbolList = { '^', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            int speed = 0;


            Unit Dwarf = new Unit();
            Dwarf.x = (Console.WindowWidth / 2) - 1;
            Dwarf.y = Console.WindowHeight - 1;
            Dwarf.color = ConsoleColor.White;
            Dwarf.symbol = '@';

            while (true)
            {
                bool hitted = false;

                int spawnBuffChance = randomGenerator.Next(0, 100);

                if (spawnBuffChance < 10)
                {
                    
                    Unit newBuff = new Unit();
                    newBuff.x = randomGenerator.Next(0, Console.WindowWidth - 2);
                    newBuff.y = 5;
                    newBuff.color = ConsoleColor.Red;
                    newBuff.symbol = '¤';
                    RocksList.Add(newBuff);
                }
                else
                {
                    Unit newInitRock = new Unit();
                    newInitRock.x = randomGenerator.Next(0, Console.WindowWidth - 2);
                    newInitRock.y = 5;
                    newInitRock.color = ConsoleColor.Cyan;
                    newInitRock.symbol = symbolList[randomGenerator.Next(0, 9)];
                    RocksList.Add(newInitRock);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable) { Console.ReadKey(true); }
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (Dwarf.x > 0)
                        {
                            Dwarf.x--;
                        }
                    }
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (Dwarf.x < Console.WindowWidth - 2)
                        {
                            Dwarf.x++;
                        }
                    }
                }

                List<Unit> newList = new List<Unit>();
                for (int i = 0; i < RocksList.Count; i++)
                {
                    Unit oldRock = RocksList[i];
                    Unit NewMovedRock = new Unit();
                    NewMovedRock.x = oldRock.x;
                    NewMovedRock.y = oldRock.y + 1;
                    NewMovedRock.color = oldRock.color;
                    NewMovedRock.symbol = oldRock.symbol;

                    if (NewMovedRock.symbol == '¤' && NewMovedRock.x == Dwarf.x && NewMovedRock.y == Dwarf.y)
                    {
                        speed = speed - 50;
                    }

                    if (NewMovedRock.symbol != '¤' && NewMovedRock.x == Dwarf.x && NewMovedRock.y == Dwarf.y)
                    {
                        livesCount--;
                        hitted = true;
                        speed = 0;
                        if (livesCount <= 0)
                        {
                            PrintStringAtPosition(42, 2, "GAME OVER", ConsoleColor.Red);
                            PrintStringAtPosition(33, 3, "Press Enter to continue", ConsoleColor.Red);
                            Console.ReadLine();
                        }
                    }
                    if (NewMovedRock.y < Console.WindowHeight)
                    {
                        newList.Add(NewMovedRock);
                    }
                    else
                    {
                        score++;
                    }
                }
                RocksList = newList;

                Console.Clear();

                if (hitted)
                {
                    PrintAtPosition(Dwarf.x, Dwarf.y, 'X', ConsoleColor.Red);
                    RocksList.Clear();
                }
                else
                {
                    PrintAtPosition(Dwarf.x, Dwarf.y, Dwarf.symbol, Dwarf.color);
                }

                foreach (Unit rock in RocksList)
                {
                    PrintAtPosition(rock.x, rock.y, rock.symbol, rock.color);
                }

                for (int i = 0; i < Console.WindowWidth; i++) 
                {
                    PrintAtPosition(i, 5, '-', ConsoleColor.Gray);
                }
                PrintStringAtPosition(10, 2, "Lives: " + livesCount, ConsoleColor.Green);
                PrintStringAtPosition(20, 2, "Score: " + score, ConsoleColor.Green);
                PrintStringAtPosition(20, 3, "Speed: " + speed, ConsoleColor.Green);

                if (speed < 170)
                {
                    speed++;
                }
                Thread.Sleep(250 - speed);
            }
        }
    }
}