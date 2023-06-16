using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;




namespace CoinFlipChallange

{
    class Program
    {
        static void Main(string[] args)
        {
  
            int randNum = 0;

            int headcount = 0;
            int tailcount = 0;
            string name; 
          
            string heads;
            string tails;
            string userAnswer;

            string yes;

            string no;
            
            

            Console.WriteLine("What is your name? \n");
            name = Console.ReadLine();

            Console.WriteLine($" Welcome {name} Would you like to play THE COIN FLIP CHALLENGE? : \n");
            Console.WriteLine("yes / no \n");


            userAnswer = Console.ReadLine().ToLower();
            


            if (userAnswer == "yes")
            {


                for (int i = 1; i <= 5; i++)
                {

                    Console.WriteLine("What is your guess? heads or tails? \n\n");
                    var flipChoice = Console.ReadLine();


                    Random rand = new Random();
         
                    rand.Next(0,1);

                    if (randNum == 0 && flipChoice == "heads")
                    {
                        headcount++;
                        Console.WriteLine("The coin landed on heads. \n");
                        Console.WriteLine("------------------------------------");
                    }
                    if (randNum == 1 && flipChoice == "tails") 
                    {
                        Console.WriteLine("The coin landed on tails. \n");
                        tailcount++;
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("------------------------------------");
                    }
                    Console.WriteLine($" {name} You flippeed    Heads: {headcount} Tails: {tailcount} \n");
                    
                }

                
            }
            else
            {
                Console.WriteLine($" {name} you Coward!");
            }
            Console.WriteLine("========== press any key to exit ==========");
            Console.ReadKey();
        }






    }


}




