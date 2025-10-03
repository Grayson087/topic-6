using System.Security.Cryptography.X509Certificates;

namespace topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // bad();
            // better();
            // dice();
            magic();
        
        
        
        
        
     
        
        }



        public static void bad()
        {

            //BAD GUESSING GAME
            Random Generator = new Random();
            int randnum, min, max;
            Console.WriteLine("names dave partner il guess what your thinking");
            Console.WriteLine("enter a minumum number");
            int.TryParse(Console.ReadLine(), out min);
            Console.WriteLine("enter a max number");
            int.TryParse(Console.ReadLine(), out max);
            randnum = Generator.Next(min, max);
            Console.WriteLine("Your number is " + randnum);
        }

        public static void better()
        {
            int randnum, pick;
            Random Genertor = new Random();
            randnum = Genertor.Next(0, 11);
            Console.WriteLine(" welcome to the best guessing game of all time pick a number between 1 and 10");
            int.TryParse(Console.ReadLine(), out pick);
             if (pick >= 10)
            {
                Console.WriteLine("invalid imput try again");
            }
            else if (pick <= 1)
            {
                Console.WriteLine("invalid imput try again");
            }
            else if (randnum != pick)
            {
                Console.WriteLine("WRONG you picked " + pick + " the number was " + randnum);
            }
            else if (randnum == pick)
            {
                Console.WriteLine("correct " + pick + " was the number");
            }
           
           

        }
        public static void dice()
        {
            int dice1, dice2, sum;
            
            Random Genertor = new Random();
            dice1 = Genertor.Next(0, 7);
            dice2 = Genertor.Next(0, 7);
            sum = dice1 + dice2;
            Console.WriteLine(" You rolled " + dice1 + " and " + dice2 + " so you would have " + sum);
            
        }
      
        public static void magic()
        {

        }
    
    
    
    
    } 




}
