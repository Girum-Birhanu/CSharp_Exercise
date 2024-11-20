using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("plsease enter your firstname");
            String firstName = Console.ReadLine();

            Console.WriteLine("plsease enter your lastname");
            String lastName = Console.ReadLine();

            Console.WriteLine("hello {0},{1}", firstName, lastName);

            Console.WriteLine("Hello" + userName);

            -------------------------------

            int i = 0;

            Console.WriteLine(" Min = {0}", int.MinValue);
            Console.WriteLine(" Max = {0}", int.MaxValue);

            string Name = "\"Girum\"";
            Console.WriteLine(Name);
            string name = @"one\ntwo\nthree\nfoure";
            Console.WriteLine("Name = {0},{1}", Name, name);
            */

            //-----------------------------------------------
            //int Number = 10;


            //bool IsNumber10 = Number == 10 ? true : false; 

            //if (Number == 10) 
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}
            //Console.WriteLine(" Number == 10 is {0}", IsNumber10);

            //--------------------------------------------------

            /*
            nullable data type

             string is reference data type
             int is value data type
             bool? Gender = null means the person remine silent without the programming assing the value true or flase.
             it will add the third option he is not choose anything.
             it is store on the database either it is string,int, nullable data type.
             the value and reference data types are only the c# concepts.

             bool? Gender = null;

            bool? AreYouMajor = false;


            if (AreYouMajor == true)
            {
                Console.WriteLine("user is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("user  is not Major");
            }
            else
            {
                Console.WriteLine("User Didn't Answer the question");
            }
                */


            //-----------------------------------------------------------

            // Null Coalescing operator

            /*
            int? TicketOnSale = 100;
            int AvailableTickets = TicketOnSale ?? 0;
            Console.WriteLine("AvailableTickets = {0}", TicketOnSale);
            */

            /*
            int? TicketOnSale = 100;
            int AvailableTickets;
            if (TicketOnSale == null)
            {
                AvailableTickets = 0;
            }
            else 
            {
                AvailableTickets = TicketOnSale.Value;
               // AvailableTickets = (int)TicketOnSale;
            }
            Console.WriteLine("AvailableTickets = {0}", TicketOnSale);
             */

            //-------------------------------------------------------------

            /*
            float f = 123.45F;
           
            //int i = (int)f; // We can't get Exeception if its Greater than int values can holdes
           
            int i = Convert.ToInt32(f);//We will find Exception handling if we put larger num in integer that above its limite
           
            Console.WriteLine(i);
            */

            // --------------------------------------------------------------

            // Parsing

            /*
            string strNumber = "100";

            int i = int.Parse(strNumber);

            Console.WriteLine(i);
            */

            /*
            string strNumber = "100";
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);//after converting string and store value on "Result"
            
            if(IsConversionSuccessful )
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            */

            //---------------------------------------------------------------------------

            // Arrays.
            // Advantage --time store mulitple similar data and Dis-advantage of arrays.---array cant grow in time once initialized

            /*
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[0] = 2;

            Console.WriteLine(EvenNumbers[1]);
            */


            //---------------------------------------------------------------------
            // IF STATMENT

            /*

             || is will check one from the option then if its true and then it will execute.best for run time
             | is check both of then even one of the option get false.
             && these sames true to the above option
             these sames true to the above option
            */

            /*
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());


            if (userNumber == 10 || userNumber == 20) { Console.WriteLine("Hey! User Num is b/n 10 & 20"); }
            */

            /*
              if (userNumber == 1)
            {
                Console.WriteLine("You Get it");
            }
              else if (userNumber == 2) { Console.WriteLine("Your num is Two"); }
              else if (userNumber == 3) { Console.WriteLine("Your Num is Three"); }
            else { Console.WriteLine("Your Number is not between 1 and 3"); }
            */

            //-------------------------------------------------------------------------------

            // Switch statetment in C#

            /*
            Console.WriteLine("Enter Number please");
            int UserNumber = int.Parse(Console.ReadLine());

             switch(UserNumber)
            {
                case 10:
                   
                case 20:
                    
                case 30:
                    Console.WriteLine("Your Number is = {0}", UserNumber); //storing the value of UserNumber into 0 index.
                    break;
                default:
                    Console.WriteLine("Your Number is not 10,20 and 30");
                    break;
            }
            */

            /*
            
           Start:

               int TotalCoffeeCost = 0;
               Console.WriteLine("Please Select a Coffee Size : 1-small, 2-meduim,3-larg");
               int userChoise = int.Parse(Console.ReadLine());


               switch (userChoise)
               {
                   case 1:
                       TotalCoffeeCost += 1;
                       break;
                   case 2:
                       TotalCoffeeCost += 2;
                       break;
                   case 3:
                       TotalCoffeeCost += 3;
                       break;

                   default:
                       Console.WriteLine("Your are choose {0} is invaild ", userChoise);
                       goto Start;
               }
               Console.WriteLine("Thankyou shopping with us");
               Console.WriteLine("The Bill amount is {0}", TotalCoffeeCost);

                decide:

               Console.WriteLine("Do Want to shop other Coffee?");
               string userdecide = Console.ReadLine();


               switch (userdecide.ToUpper())
               {
                   case "YES":
                       goto Start;
                   case "NO":
                       break;
                   default:
                       Console.WriteLine("Your Choise {0} is invaild",userdecide);
                       goto decide;*/




            //--------------------------------------------------------------

            // Class assignment

            /*

            Console.WriteLine("Enter 10 Digit Numbers");
            Console.ReadLine();
            int[] CommArray = { 10, 23, 34 };
            int evencount = 0;
            int oddcount = 0;
            int evensum = 0;
            for (int i = 0; i < evencount; i++)
            {
                evensum += CommArray[i];
            }

            int[] evenArray = new int[];
            for (int i = 0; i < CommArray.Length; i++)
            {
                if (CommArray[i] % 2 == 0)
                {
                    evenArray[evencount] = CommArray[i];
                    evencount++;
                }
            }
            Console.WriteLine("Number of all even number in the array:" + evencount);
            Console.WriteLine("Element of the Array");
            foreach (int even in CommArray)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("The Sum of Even Numbers is ", +evensum);


        }
     }
            */

            //-----------------------------------------------------------

            Console.WriteLine("please enter your target ");
            int usertarget = int.Parse(Console.ReadLine());
            int start = 0;
            while(start <= usertarget)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
           


}
        
    