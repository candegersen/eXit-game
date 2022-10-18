using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace eXit
{
    public class Program
    {

        //answers to each input:
        //move barrel
        //enter tunnel
        //read note
        //leave
        //look
        //get on boat
        public static void Main(string[] args)
        {
            gameTitle();
            first();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to eXit");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;
            Console.WriteLine("\nYou're trapped in a dungeon with your friend.");
            Console.WriteLine("You see a barrel. What do you do?");
            Console.WriteLine("1. Move the barrel");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Sit down and wait");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "move the barrel":
                case "move":
                    {
                        Console.WriteLine("\nThe barrel rolls aside and you find a secret tunnel.");
                        Console.WriteLine("You shout for help and your voice echoes through the area.");
                        Console.WriteLine("What do you do?");
                        Console.ReadLine();
                        break;
                    }
                case "2":
                case "sleep":
                    {
                        Console.WriteLine("You try to sleep but very anxious");
                        Console.WriteLine("You don't know how much time has passed.");
                        Console.WriteLine("You hear a noise and you wake up. It was a rat.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "Sit down and wait":
                case "sit":
                    {
                        Console.WriteLine("You sit down and wait for help to come.");
                        Console.WriteLine("After a few hours you understand that you're completely alone.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;
                    }

                    //second stage soon
            }
        }
    }
}





