using System.Security.Cryptography.X509Certificates;

namespace topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bad();
             better();
             dice();
            magic();
            
        
        
        
        
        
     
        
        }



        public static void bad()
        {

            //BAD GUESSING GAME
            Random Generator = new Random();
            int randnum, min, max;
            Console.WriteLine("Names Dave partner il guess what your thinking");
            Console.WriteLine("Enter a minumum number");
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
            Console.WriteLine(" Welcome to the best guessing game of all time pick a number between 1 and 10");
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
            string ans;
            Console.WriteLine("Welcome to the dice roller you wanna roll? \n yes/no");
            ans = Console.ReadLine().ToUpper();
            if ( ans  == "YES"){


                Random Genertor = new Random();
                dice1 = Genertor.Next(0, 7);
                dice2 = Genertor.Next(0, 7);
                sum = dice1 + dice2;
                Console.WriteLine(" You rolled " + dice1 + " and " + dice2 + " so you would have " + sum);
            }

            else if ( ans == "NO")
            {
                Console.WriteLine("WHAT WHY???????");
            }
        
        
        }
      
        public static void magic()
        {
            string ask;
            int ball;
            Random Genertor = new Random();
            Console.WriteLine("Welcome to the magic 8 ball");
             Console.WriteLine("ask any yes/no question");
            ask = Console.ReadLine(); 
            ball = Genertor.Next(0,11);
            // good answers
            if (ball == 1)
            {
               
                Console.WriteLine("It is certain");
            }
            else if (ball == 2)
            {
                
                Console.WriteLine("Yes deffintly");
            }
            else if (ball == 3)
            {
               
                Console.WriteLine("Without a doubt");
          
       
            }

            else if (ball == 4)
            {
                
                Console.WriteLine("Outlook good");
            }
            //medium
            else if (ball == 5)
            {
                
                Console.WriteLine("Ask again later");
               
            }
            else if (ball == 6)
            {
                
                Console.WriteLine("Answer hazy");
            }
            // bad
            else if (ball == 7)
            {
              
                Console.WriteLine("Dont count on it");
            }
            else if (ball == 8)
            {
                
                Console.WriteLine("My reply is no");
            }
            else if (ball == 9)
            {
                
                Console.WriteLine("Verry doubtfull");
            }
            else if (ball == 10)
            {
                
                Console.WriteLine("Outlook not so good");
            }













        }









       
         
    
    } 




}
