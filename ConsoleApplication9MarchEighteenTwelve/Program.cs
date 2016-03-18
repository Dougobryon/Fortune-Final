using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9MarchEighteenTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //get user name
                //get user last name
                //get birth month
                //Initialize some variables at this scope for use later

                string playAgain = "Y"; //we are setting this up to ask again
                string retireMoney = "$0";
                int retireAge = 0;
                string vacationHome = "home";
                string vehicle = "sailboat";

                while (playAgain == "Y" || playAgain == "y")
                {
                    Console.WriteLine("What is your First Name?");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("What is your Last Name?");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("What is your birth month?");
                    string month = Console.ReadLine();
                    Console.WriteLine("What is your age?");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many siblings do you have?");
                    int siblings = int.Parse(Console.ReadLine());

                    string colorAns = "HELP"; //initial value is help
                    while (colorAns == "HELP")
                    {
                        Console.WriteLine("Give me your favorite color, ROYGBIV - for help type \"help\"");
                        string colors = Console.ReadLine();
                        colorAns = colors.ToUpper();//change to upper case for ease of use
                        if (colorAns == "HELP")//if they write help, give help and loop back to ask again (while)
                        {
                            Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                        }
                    }
                    switch (colorAns)
                    {
                        case "RED"://red and r can both be the same case (etc. for other colors) 
                        case "R":
                            vehicle = "Lamborghini";
                            break;
                        case "ORANGE":
                        case "O":
                            vehicle = "camel";
                            break;
                        case "YELLOW":
                        case "Y":
                            vehicle = "pickup truck";
                            break;
                        case "GREEN":
                        case "G":
                            vehicle = "plane";
                            break;
                        case "BLUE":
                        case "B":
                            vehicle = "skateboard";
                            break;
                        case "INDIGO":
                        case "I":
                            vehicle = "moped";
                            break;
                        default:
                            vehicle = "hovercraft";
                            break;
                    }
                    switch (siblings)
                    {
                        case 0:
                            vacationHome = "Atlanta";
                            break;
                        //if siblings = 0, then you will live in (vacationhome) Atlanta
                        case 1:
                            vacationHome = "Boston";
                            break;
                        //if siblings = 1 different house Boston
                        case 2:
                            vacationHome = "Charlotte";
                            break;
                        //if 2 = different house Charlotte
                        case 3:
                            vacationHome = "Denver";
                            break;
                        //if 3 = different house Denver
                        default:
                            vacationHome = "England";
                            break;
                            //if more than 3 = different house England
                    }
                    //Console.WriteLine("Your vacation home is in " + vacationHome); TESTING
                    //if age is odd, retire in 5 years, if even retire in 10 years
                    if (age % 2 == 0)//this means it is even
                    {
                        retireAge = 10;
                    }
                    else
                    {
                        retireAge = 5;
                    }
                    //Console.WriteLine(retireAge);
                    string upperMonth = month.ToUpper();//convert month to uppercase in case they put it in lowercase
                    string upperFirst = firstName.ToUpper();//convert first name to uppercase
                    string upperLast = lastName.ToUpper();//convert last name to uppercase
                    if (upperMonth[0] == upperFirst[0] || upperMonth[0] == upperLast[0])
                    {//compare first letter of first name & first letter of last name to first letter of birth month
                        retireMoney = "$100";

                    }
                    else if (upperMonth[0] == upperFirst[1] || upperMonth[0] == upperLast[1])
                    {
                        retireMoney = "$4562.18";

                    }
                    else if (upperMonth[0] == upperFirst[2] || upperMonth[0] == upperLast[2])
                    {
                        retireMoney = "$7 MILLION DOLLARS$$";
                    }
                    else
                    {
                        retireMoney = "$ 10 MILLION DOLLARS";
                    }
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireAge + " years with " + retireMoney + " in the bank, a vacation home in " + vacationHome + " and a " + vehicle + ".");
                Console.WriteLine("Would you like to play again? Y/N");
                playAgain = Console.ReadLine();
                if (playAgain == "N" || playAgain == "n") 
            {
                Console.WriteLine("Thanks for playing - come again soon! ");
            }
            }


                //if they do not match then you are done with this part.
                //Console.WriteLine("Would you like to try again? :");
                //Console.WriteLine("If you would like to try again, enter /"Y"/)
                //If string = "Y", then 


            }
        }
    }

