//ask user to enter number of sides for a pair of dice
string doesRoll = "";
string rollAgain = "";
int sides = 0;

//static overloaded diceRoller(overloaded var)
do
    {
        do
        {
            try
            {
                Console.WriteLine("How many sides does your pair of dice have?");
                sides = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (sides < 1 || sides > 20)
                {
                    throw new Exception("I don't beleive you. Enter a real number.");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error! Invalid number!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        while (sides == 0);


        //prompt user to roll dice

        while (doesRoll != "roll")
        {
            Console.WriteLine();
            Console.WriteLine("Wow thats cool. Type 'ROLL' to roll dice");
            doesRoll = Console.ReadLine();
            if (doesRoll.ToLower() == "roll")
            {
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Try again...");
            }
        }


        //app rolls 2 n sided dice. display result and total.


        Random rnd = new Random();
        int dice1 = (rnd.Next(1, sides));
        int dice2 = (rnd.Next(1, sides));
        int total = dice1 + dice2;

        Console.WriteLine($"You rolled {dice1} and {dice2}.");
        Console.WriteLine($"The total is {total}");
        //on 6 sided dice add code words



        if (sides == 6)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
            {
                Console.WriteLine("Ace Deuce!");
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("Box Cars!");
            }
            else if ((dice1 + dice2 == 7) || (dice1 + dice2 == 11))
            {
                Console.WriteLine("Win!");
            }
            else if ((dice1 + dice2 == 2) || (dice1 + dice2 == 3) || (dice1 + dice2 == 12))
            {
                Console.WriteLine("Craps!");
            }
        }
        else
        {
            break;
        }
        //roll again?

        Console.WriteLine();
        Console.WriteLine("Roll again? 'Y' or 'N'");
        rollAgain = Console.ReadLine();
        if (rollAgain.ToLower() == "n")
        {
            System.Environment.Exit(1);
        }
        else if (rollAgain.ToLower() == "y")
        {

        }
    }

    while (rollAgain == "y");













