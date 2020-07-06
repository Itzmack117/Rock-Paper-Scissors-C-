using System;
using System.Collections.Generic;
using System.Threading;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            int pWinCount = 0;
            int cWinCount = 0;
            bool playing;
            Console.WriteLine("Who are you?");
             string name = Console.ReadLine();
                     Console.WriteLine($"Hello {name}, would you like to play Rock Paper Scissors? (Y/N)") ;
                        char choice = Console.ReadKey().KeyChar;
                        
                    Dictionary<string, string> weapons = new Dictionary<string, string>()
                    {
                    {"rock", ""},
                    {"paper", ""},
                    {"scissors", ""}
                    };
                if (choice == 'y')
                {   playing = true;
                    while(playing == true){
                    Console.WriteLine("\nVery well... \nMake your choice!");
                   Random rnd = new Random();
                    int num = rnd.Next(3);
                    string compChoice;
                    if (num == 0){
                        compChoice = "rock";
                    }
                    else if(num == 2){
                        compChoice = "paper";
                    }
                    else
                    {
                        compChoice = "scissors";
                    }
                   string pChoice = Console.ReadLine();
                    if(compChoice == pChoice)
                    {
                        Console.WriteLine("It's a draw, you reading my mind?");
                    }
                    else if(pChoice == "rock" && compChoice == "scissors")
                    {
                        Console.WriteLine($"{pChoice} beats {compChoice}, \nYou win, I'll get you next time");
                        pWinCount++;
                    }
                    else if(pChoice == "scissors" && compChoice == "paper")
                    {
                        Console.WriteLine($"{pChoice} beats {compChoice}, \nYou win, I'll get you next time");
                        pWinCount++;
                    }
                    else if(pChoice == "paper" && compChoice == "rock")
                    {
                        Console.WriteLine($"{pChoice} beats {compChoice}, \nYou win, I'll get you next time");
                        pWinCount++;
                    }
                    else if(pChoice == "paper" && compChoice == "scissors")
                    {
                        Console.WriteLine($"HA! {compChoice} beats {pChoice}! \nYou lose!");
                        cWinCount++;
                    }
                    else if(pChoice == "scissors" && compChoice == "rock")
                    {
                        Console.WriteLine($"HA! {compChoice} beats {pChoice}! \nYou lose!");
                        cWinCount++;
                    }
                    else if(pChoice == "rock" && compChoice == "paper")
                    {
                        Console.WriteLine($"HA! {compChoice} beats {pChoice}! \nYou lose!");
                        cWinCount++;
                    }
                    else
                    {
                        Console.WriteLine($"It's rock paper scissors, not rock paper scissors and {pChoice}");
                    }
                    Console.WriteLine($"I have beaten you {cWinCount} times, and you have beaten me {pWinCount} times \nShall we play again? (Y/N)");
                    char pAgain = Console.ReadKey().KeyChar;
                    if(pAgain == 'n'){
                        playing = false;
                        if (pWinCount > cWinCount){
                            Console.WriteLine("\nFine, I wasnt having fun anyways");
                            }
                            else if(pWinCount == cWinCount){
                                Console.WriteLine("\nFine, we'll settle this duel later");
                            }
                            else
                            {
                                Console.WriteLine("\nWhat? Are you afraid you'll lose again?");
                            }
                        }else 
                        {
                        playing = true;
                        }
                 }
                }
                else
                {
                    Console.WriteLine("\nAwwww are you afraid of me?");
                }
              }
        }
    }