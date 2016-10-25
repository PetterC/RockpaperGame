using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Game
    {

        string rock;
        string paper;
        string scissors;
        string lizard;
        string spock;

        bool playAgain = true;

        

                    Random rnd = new Random();

        randomInt = rnd.Next(1, 5);

                    switch (option)
                    {
                        case 1:
                            rock = "rock";
                            Console.WriteLine("Computer chose rock");
                            if (inputPlayerOne == "rock")
                            {
                                Console.WriteLine("draw \n");
                            }
                            else if (inputPlayerTwo == "paper")
                            {
                                Console.WriteLine("lose \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "scissors")
                            {
                                Console.WriteLine(" win \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "lizard")
                            {
                              Console.WriteLine("win \n");
                             }
                             else if (inputPlayerTwo == "spock")
                             {
                              Console.WriteLine("lose \n");
                            break;
                        case 2:
                            inputPlayerOne = "paper";
                            Console.WriteLine("Computer chose paper");
                            if (inputPlayerTwo == "paper")
                            {
                                Console.WriteLine("draw \n");
                            }
                            else if (inputPlayerTwo == "rock")
                            {
                                Console.WriteLine("win \n");
                                inputPlayer++;
                            }
                            else if (inputPlayerTwo == "scissor")
                            {
                                Console.WriteLine("lose \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "lizard");
                            {
                               Console.WriteLine("lose \n");
                             }
                            else if (inputPlayerTwo == "spock");
                             {
                                 Console.WriteLine("lose \n");
                              }
                            break;
                        case 3:
                            inputPlayerOne = "scissors";
                            Console.WriteLine("Computer chose scissors");
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("draw \n");
                            }
                            else if (inputPlayerTwo == "rock")
                            {
                                Console.WriteLine("win \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "paper")
                            {
                                Console.WriteLine("win \n");
                                scoreplayer++;
                            }
                            else if (inpputPlayerTwo == "lizard");
                              {
                              Console.WriteLine("win \n");
                              }
                             else if (inputPlayerTwo == "spock");
                            {
                            Console.WriteLine("lose" \n);
                            }
                            break;
                       case 4:
                          
                             inputPlayerOne = "lizard";
                            Console.WriteLine("Computer chose lizard");
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("lose \n");
                            }
                            else if (inputPlayerTwo == "rock")
                            {
                                Console.WriteLine("lose \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "paper")
                            {
                                Console.WriteLine("win \n");
                                scoreplayer++;
                            }
                            else if (inpputPlayerTwo == "lizard");
                              {
                              Console.WriteLine("draw \n");
                              }
                             else if (inputPlayerTwo == "spock");
                            {
                            Console.WriteLine("win" \n);
                            }
                           break;
                     case 5:
                         inputPlayerOne = "spock";
                            Console.WriteLine("Computer chose scissors");
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("win \n");
                            }
                            else if (inputPlayerTwo == "rock")
                            {
                                Console.WriteLine("win \n");
                                scorePlayer++;
                            }
                            else if (inputPlayerTwo == "paper")
                            {
                                Console.WriteLine("lose \n");
                                scoreplayer++;
                            }
                            else if (inpputPlayerTwo == "lizard");
                              {
                              Console.WriteLine("lose \n");
                              }
                             else if (inputPlayerTwo == "spock");
                            {
                            Console.WriteLine("draw" \n);
                            }

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
              

                if (scorePlayerOne == 3)
                {
                    Console.WriteLine("PlayerOne WON!");
                }
                else if (scorePlayeerTwo == 3)
                {
                    Console.WriteLine("PlayerTwo WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
 


    
            }
        }
    


