namespace If_and_else_statements_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which part of the code would you like to run (choose between 1-5)");
            Console.WriteLine("1 - Space Boxing");
            Console.WriteLine("2 - Simple Calculator");
            Console.WriteLine("3 - Quiz");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();    //Clears the option menu

            if (choice == 1) Part1();
            else if (choice == 2) Part2();
            else if (choice == 3) Part3();
            else Console.WriteLine("Invalid number :(");



            Console.ReadLine();
        }



        static void Part1()
        {
            //Space Boxing
            string choice;
            double earthWeight, result;

            Console.Write("What is your current weight on earth?: ");
            if (!double.TryParse(Console.ReadLine(), out earthWeight))
            {
                Console.WriteLine("Your choice is invalid, enter a number.");
                return;
            }

            Console.WriteLine("We have information for the following planets");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter");
            Console.WriteLine("4. Saturn 5. Uranus 6. Neptune");
            Console.Write("Which planet do you choose?: ");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (choice == "1")
            {
                result = earthWeight * 0.78;
                Console.WriteLine("Your weight on Venus would be " + result + " pounds.");
            }
            else if (choice == "2")
            {
                result = earthWeight * 0.39;
                Console.WriteLine("Your weight on Mars would be " + result + " pounds.");
            }
            else if (choice == "3")
            {
                result = earthWeight * 2.65;
                Console.WriteLine("Your weight on Jupiter would be " + result + " pounds.");
            }
            else if (choice == "4")
            {
                result = earthWeight * 1.17;
                Console.WriteLine("Your weight on Saturn would be " + result + " pounds.");
            }
            else if (choice == "5")
            {
                result = earthWeight * 1.05;
                Console.WriteLine("Your weight on Uranus would be " + result + " pounds.");
            }
            else if (choice == "6")
            {
                result = earthWeight * 1.23;
                Console.WriteLine("Your weight on Neptune would be " + result + " pounds.");
            }
            else
                Console.WriteLine("You typed an invalid choice, pick between 1-6" + ".");

        }



        static void Part2()
        {
            //Simple Calculator

            int choice;
            double num1, num2, squareRoot;
            Console.WriteLine("Do you want to use a mulitipcation calculator or a square root calculator");
            Console.Write("1 for multiplaction or 2 for square root: ");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1)
            {
                Console.Write("Enter your first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter a number to determine the square root.");
                num1 = Convert.ToDouble(Console.ReadLine());

                squareRoot = Math.Sqrt(num1);

                Console.WriteLine("The square root of " + num1 + " is " + squareRoot + ".");
            }

        }



        static void Part3()
        {
            //Quiz

            string choice;
            int albums, score = 0;
            double precentage;


            Console.WriteLine("Rock Music Quiz");

            //Question 1
            Console.WriteLine("Who was the drummer for Led Zeppelin:");
            Console.WriteLine("a - Ringo Starr          b - Robert Plant");
            Console.WriteLine("c - John Bonham          d - Neil Peart");
            Console.WriteLine();
            Console.Write(": ");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (choice == "a")
            {
                Console.WriteLine("Ringo was the drummer for The Beatles! Not Led Zeppelin!");
            }
            else if (choice == "b")
            {
                Console.WriteLine("Robert Plant was the lead singer for Led Zeppelin not the drummer!");
            }
            else if (choice == "c")
            {
                Console.WriteLine("Correct! John Bonham was the drummer for Led Zeppelin.");
                score++;
            }
            else if (choice == "d")
            {
                Console.WriteLine("Incorrect! Neil Peart was the drummer for Rush not Led Zeppelin");
            }
            else
            {
                Console.WriteLine("This is an invalid choice, try a,b,c,d,");
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();



            //Question 2
            Console.Write("Who is the lead guitarist in Guns N' Roses?: ");
            choice = Console.ReadLine().ToLower();
            if (choice.ToLower() == "slash")
            {
                Console.WriteLine("Correct Slash is the guitarist for Guns N' Roses");
                score++;
            }
            else
            {
                Console.WriteLine(choice + " is incorrect");
            }



            //Question 3
            Console.WriteLine("How many albums did The Beatles release?:");
            Console.WriteLine();
            Console.Write(": ");
            int.TryParse(Console.ReadLine(), out albums);
            Console.WriteLine();
            if (albums == 13)
            {
                Console.WriteLine("Correct! The Beatles released 13 albums");
                score++;
            }
            else if (albums == 1)
            {
                Console.WriteLine(albums + " album is incorrect!");
            }
            else
            {
                Console.WriteLine(albums + " albums is incorrect!");
            }
            
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();



            //Question 4
            Console.WriteLine("TRUE OR FALSE");
            Console.Write("Metallica has played a concert on all 7 continents of the world?: ");
            choice = Console.ReadLine().ToLower();
            if (choice.ToLower() == "true")
            {
                Console.WriteLine("Correct! It is true that Metallica played a concert on all 7 continents.");
                score++;
            }
            else if (choice ==  "false")
            {
                Console.WriteLine("False is incorrect.");
            }
            else
            {
                Console.WriteLine("This is a true or false question! " + choice + " is incorrect");
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();



            //Results
            precentage = (score / 4.0)* 100;
            if (score >= 2) 
            {
                Console.WriteLine("You passed with a score of " + precentage + "% and got " + score + "/4.");
            }
            else
            {
                Console.WriteLine("You failed with a score of " + precentage + "% and got " + score + "/4.");
            }
        }
    }
}
