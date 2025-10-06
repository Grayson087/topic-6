using System.Security.Cryptography.X509Certificates;

namespace topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Bad();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            Better();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();


            Dice();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            Magic();
            
        
        
        
        
        
     
        
        }



        public static void Bad()
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

        public static void Better()
        {
            int randnum, pick;
            Random Genertor = new Random();
            randnum = Genertor.Next(1, 11);
            Console.WriteLine("Welcome to the best guessing game of all time pick a number between 1 and 10");
            int.TryParse(Console.ReadLine(), out pick);
            if (pick > 10)
            {
                Console.WriteLine("Invalid input");
            }
            else if (pick < 1)
            {
                Console.WriteLine("Invalid input");
            }
            else if (randnum != pick)
            {
                Console.WriteLine("WRONG you picked " + pick + " the number was " + randnum);
            }
            else
            {
                Console.WriteLine("Correct " + pick + " was the number");
            }
           
           

        }
        public static void Dice()
        {
            Random Genertor = new Random();

            int dice1, dice2, sum;
            string ans;
            Console.WriteLine("Welcome to the dice roller you wanna roll? \n yes/no");
            ans = Console.ReadLine().ToUpper();
            if (ans == "YES")
            {


                dice1 = Genertor.Next(1, 7);
                dice2 = Genertor.Next(1, 7);
                sum = dice1 + dice2;
                Console.WriteLine(" You rolled " + dice1 + " and " + dice2 + " so you would have " + sum);
            }

            else if (ans == "NO")
            {
                Console.WriteLine("WHAT WHY???????");
            }
            else {

                Console.WriteLine("Not one of the valid imputs");
            
            
            }
        
        
        }
      
        public static void Magic()
        {
            string ask;
            int ball;
            Random Genertor = new Random();

            Console.WriteLine("Welcome to the magic 8 ball");
            Console.WriteLine("ask any yes/no question");
            ask = Console.ReadLine(); 

            ball = Genertor.Next(1,11);
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
            else
            {
                
                Console.WriteLine("Outlook not so good");
            }













        }









       
         
    
    } 




}
