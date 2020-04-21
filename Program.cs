using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nNumber Guessing Game");
            Console.WriteLine("\nLevels and Instructions");
            Console.WriteLine("easy -- guess a number between 1 and 10, you get only 6 guesses.");
            Console.WriteLine("medium -- guess a number between 1 and 20, you get only 4 guesses.");
            Console.WriteLine("hard -- guess a number between 1 and 50, you get only 3 guesses.");
            Console.WriteLine("P.S = Level name is case sensitive");

            string level;
            Console.Write("\nChoose your level: ");
            level = Console.ReadLine();

            if (level == "easy")
            {
                Console.WriteLine("\nEasy level selected");
                Console.WriteLine("Guess any number from 1 - 10.");

                for(int i = 0; i < 6; i++)
                {
                    try
                    {
                        int [] guessleft = new int [6];
                        guessleft[0] = 6;
                        guessleft[1] = 5;
                        guessleft[2] = 4;
                        guessleft[3] = 3;
                        guessleft[4] = 2;
                        guessleft[5] = 1;

                        Console.WriteLine(guessleft[i] + " guesses left");

                        int guess = 8;
                        int input;
                        Console.Write("\nEnter your guess: \n");
                        input = int.Parse(Console.ReadLine());
                            
                        if (input == guess)
                        {
                            Console.WriteLine("\nYou got it right!");
                            break;
                        }
                        
                        else if (input <=10)
                        {
                            Console.WriteLine("\nThat was wrong");

                            if (guessleft[i] == guessleft[5] )
                            {
                                Console.WriteLine("Game Over!\n");
                            }
                        }

                        else if (input > 10)
                        {
                            Console.WriteLine("\nNumber must be between 1 and 10.");
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("\nThis is not a number.");
                        
                    }
                }
            }


            else if (level == "medium")
            {
                Console.WriteLine("Medium level selected");
                Console.WriteLine("Guess any number from 1 - 20.");

                for(int i = 0; i < 4; i++)
                {
                    try
                    {
                        int [] guessleft = new int [4];
                        guessleft[0] = 4;
                        guessleft[1] = 3;
                        guessleft[2] = 2;
                        guessleft[3] = 1;

                        Console.WriteLine(guessleft[i] + " guesses left");

                        int guess = 17;
                        int input;
                        Console.Write("\nEnter your guess: \n");
                        input = int.Parse(Console.ReadLine());


                        if (input == guess)
                        {
                            Console.WriteLine("\nYou got it right!");
                            break;
                        }
                        
                        else if (input <=20)
                        {
                            Console.WriteLine("\nThat was wrong");

                            if (guessleft[i] == guessleft[3] )
                            {
                                Console.WriteLine("Game Over!\n");
                            }
                            continue;
                        }
                        else if (input > 20)
                        {
                            Console.WriteLine("\nNumber must be between 1 and 20.");
                        }
                    }

                    catch (FormatException)
                    {
                    Console.WriteLine("\nThis is not a number.");
                    
                    continue;
                    }   
                }
            }


            else if (level == "hard")
            {
                Console.WriteLine("Hard level selected");
                Console.WriteLine("Guess any number from 1 - 50.");

                for(int i = 0; i < 3; i++)
                {
                    try
                    {
                        int [] guessleft = new int [3];
                        guessleft[0] = 3;
                        guessleft[1] = 2;
                        guessleft[2] = 1;

                        Console.WriteLine(guessleft[i] + " guesses left");

                        int guess = 39;
                        int input;
                        Console.Write("\nEnter your guess: \n");
                        input = int.Parse(Console.ReadLine());


                        if (input == guess)
                        {
                            Console.WriteLine("\nYou got it right!");
                            break;
                        }
                        
                        else if (input <= 50)
                        {
                            Console.WriteLine("\nThat was wrong");

                            if (guessleft[i] == guessleft[2] )
                            {
                                Console.WriteLine("Game Over!\n");
                            }
                            continue;
                        }
                        else if (input > 50)
                        {
                            Console.WriteLine("\nNumber must be between 1 and 50.");
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("\nThis is not a number.");
                        continue;
                    }   
                }
            }


            else
            {
                Console.WriteLine("Choose from the levels displayed above.\n");
            }

            Console.WriteLine("Thanks for Playing\n");
        }
    }
}
