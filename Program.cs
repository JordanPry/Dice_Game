using Dice_Game;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace diceGame
{

    class Program
    {        
        //Function Used to Start a Solo game against the Computer
        public static void startGame(string gameType)
        {
            //Variables
            Player player = new Player();
            Player enemy = new Player();
            Random roll = new Random();
            if (gameType == "soloGame")
            {
                Console.WriteLine("Please enter your name.");
                player.playerName = Console.ReadLine();

                for (int i = 0; i < 10; i++)
                {
                    //Player Rolling
                    Console.WriteLine(player.playerName + " Press a key to roll the dice.\n");
                    Console.ReadKey();
                    player.rolledScore = roll.Next(1, 7);
                    Console.WriteLine(player.playerName + " Rolled a " + player.rolledScore);

                    Console.WriteLine("......");
                    System.Threading.Thread.Sleep(500);

                    // Enemy Rolling
                    enemy.rolledScore = roll.Next(1, 7);
                    Console.WriteLine("Enemy Rolled a " + enemy.rolledScore);

                    //Increasing Scores
                    if (player.rolledScore > enemy.rolledScore)
                    {
                        player.score++;
                        Console.WriteLine("Congratualations You won The roll, your Score has increased by 1");

                    }
                    else if (player.rolledScore < enemy.rolledScore)
                    {
                        enemy.score++;
                        Console.WriteLine("Enemy Wins the Roll Their Score has increased by 1");

                    }
                    else
                    {
                        Console.WriteLine("It's a Draw!");
                    }

                    Console.WriteLine("The score is now " + player.playerName + ": " + player.score);
                    Console.WriteLine("The score is now Enemy : " + enemy.score);
                    Console.WriteLine("");



                }
                //Outcome Of winner
                if (player.rolledScore > enemy.rolledScore)
                {
                    Console.WriteLine("You Win!!");

                }

                else if (player.rolledScore > enemy.rolledScore)
                {
                    Console.WriteLine("You lose :(");

                }

                else
                {
                    Console.WriteLine("The game has ended in a draw");
                    Console.WriteLine("The Final score was Player: " + player.score);
                    Console.WriteLine("The Final score was Enemy: " + enemy.score);

                }

            }
            else 
            {
                Player player2 = new Player();
                Console.WriteLine("Please enter your name.");
                player.playerName = Console.ReadLine();
                Console.WriteLine("Please enter the Name for Player 2.");
                player2.playerName = Console.ReadLine();

                for (int i = 0; i < 5; i++)
                {
                    //Player Rolling
                    Console.WriteLine(player.playerName + " Press a key to roll the dice.\n");
                    Console.ReadKey();
                    player.rolledScore = roll.Next(1, 7);
                    Console.WriteLine(player.playerName + " Rolled a " + player.rolledScore);

                    Console.WriteLine(player2.playerName + " Press a key to roll the dice.\n");
                    Console.ReadKey();

                    // Player2 Rolling
                    player2.rolledScore = roll.Next(1, 7);
                    Console.WriteLine(player2.playerName + " Rolled a " + player2.rolledScore);

                    //Increasing Scores
                    if (player.rolledScore > player2.rolledScore)
                    {
                        player.score++;
                        Console.WriteLine(player.playerName + " Won the Roll Their score has increased by 1.");

                    }
                    else if (player.rolledScore < player2.rolledScore)
                    {
                        player2.score++;
                        Console.WriteLine(player2.playerName + " Wins the Roll Their Score has increased by 1");

                    }
                    else
                    {
                        Console.WriteLine("It's a Draw!");
                    }

                    Console.WriteLine("The score is now " + player.playerName + ": " + player.score);
                    Console.WriteLine("The score is now " + player2.playerName + ": " + player2.score);
                    Console.WriteLine("");



                }
                //Outcome Of winner
                if (player.rolledScore > player2.rolledScore)
                {
                    Console.WriteLine(player.playerName + " Wins, congratulations");

                }

                else if (player.rolledScore > player2.rolledScore)
                {
                    Console.WriteLine(player2.playerName + " Wins, congratulations");

                }

                else
                {
                    Console.WriteLine("The game has ended in a draw");
                    Console.WriteLine("The Final score was Player " + player.score);
                    Console.WriteLine("The Final score was Enemy: " + player2.score);

                }
            }
                

            //Console.ReadKey();
        }

        
        //Function Called at the end of each game to play again
        static void restartGame(string gameType) {

            Console.WriteLine("You have finished the Game");
            Console.WriteLine("Would you like to...");
            Console.WriteLine("1. Play again.");
            Console.WriteLine("2. Return to start screen.");
            Console.WriteLine("3. Exit the program");
            string? input = Console.ReadLine();
            if (input == "1") 
            {
                startGame(gameType);
            
            }
            if (input == "2") 
            {
                Main(null);
            
            }
            if (input == "3")
            {
                exitGame();
                
            }
            else 
            {
                Console.WriteLine("Invalid input given, Please try again.\n" );
                restartGame(gameType);
            } 
                    
        }
        static void exitGame()
        {
            Console.WriteLine("Thank you For playing.\nSee you again soon!\nGoodbye!\n\n");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void menuInput(string input, string gameType) 
        { 

        
        }

        static void Main(string[] args = null) 
        
        {
            bool running = true;
            while (running)
            {
                string gameType;
                Console.WriteLine("Welcome to the Dice Rolling Game;");
                Console.WriteLine("Please Choose an Option");
                Console.WriteLine("1. Play Solo Against the Computer");
                Console.WriteLine("2. Play with a Friend");
                Console.WriteLine("3. Learn the rules");
                Console.WriteLine("4. Exit the Program");

                string? input = Console.ReadLine();

                if (input == "1")
                {
                    gameType = "soloGame";
                    startGame(gameType) ;
                    restartGame(gameType);

                }

                if (input == "2")
                {
                    gameType = "multiGame";
                    startGame(gameType);
                    restartGame(gameType);
                }

                if (input == "3")
                {
                    Console.WriteLine("\nThe rules of the game are simple.");
                    Console.WriteLine("Players will take turns rolling a dice 10 times and whoever rolls the highest the most time wins!");
                    Console.WriteLine("In Singleplayer the computer will roll against you");
                    Console.WriteLine("Have Fun!\n");
                    Main(null);

                }
               
                if (input == "4")
                {
                    exitGame();

                }
                else
                {
                    Console.WriteLine("That was an incorrect Input, please try again!\n");


                }
                

            }
            

        }

    }













}