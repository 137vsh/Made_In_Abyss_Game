using System;
using System.Diagnostics;
using System.Net.Security;

Console.WriteLine("||\\        //||     //\\     ||===**    ||=====");
Console.WriteLine("|| \\      // ||    //  \\    ||    **   ||     ");
Console.WriteLine("||  \\    //  ||   //    \\   ||     **  ||==== ");
Console.WriteLine("||   \\  //   ||  //======\\  ||     **  ||     ");
Console.WriteLine("||    \\//    || //        \\ ||====**   ||=====");
Console.WriteLine("");
Console.WriteLine("             ||  ||\\    ||");
Console.WriteLine("             ||  || \\   ||");
Console.WriteLine("             ||  ||  \\  ||");
Console.WriteLine("             ||  ||   \\ ||");
Console.WriteLine("             ||  ||    \\||");
Console.Write("\n");
Console.WriteLine("//\\     ||===**  \\     //  **===**  **===**");
Console.WriteLine("//  \\    ||    **  \\   //  //       //");
Console.WriteLine("//    \\   ||===**    \\ //   =======  =======");
Console.WriteLine("//======\\  ||     **   ||          \\       \\");
Console.WriteLine("//        \\ ||====**    ||    =======  ======");

Console.Write("\n");

Console.Write("> Press 'Enter' to begin . . . ");
Console.ReadKey();
Console.WriteLine("");
Console.WriteLine("Hello Adventurer, What is your name?");

Console.Write("> ");
string playerName = Console.ReadLine();
Console.WriteLine(" ");


Console.WriteLine("Your journey begins at an orphanage located in the town of Orth.");
Console.WriteLine("Orth is built along the perimeter of a great chasm known as The Abyss.");
Console.WriteLine("");

Console.WriteLine("You wake up in your bed, your vision slowly comes into focus.");
Console.WriteLine("You look to the window, you can see light filtering in through the curtains.");
Console.Write("\n");

Console.Write("> Press 'Enter' to continue . . . ");
Console.ReadLine();
Console.Write("\n");

Console.WriteLine("You are startled by a sudden knock at the door.");
Console.WriteLine("''" + playerName + " wake up, its time to do your chores.''");
Console.WriteLine("\n");

Console.WriteLine("''Oh no, its teacher, I should think of something quick.''");
Console.WriteLine("\t 1. Answer the door");
Console.WriteLine("\t 2. Explore the room");
Console.WriteLine("\t 3. Leave through the window");

string userChoice1 = Console.ReadLine();



if (userChoice1 == "1" || userChoice1 == "1." || userChoice1 == "answer the door" || userChoice1 == "Answer the door")
{
    Console.WriteLine("");
    Console.WriteLine("You like taking directions from others, dont you?");
    Console.WriteLine("You clearly lack the rebellious spirit necessery to challenge The Abyss.");
    Console.WriteLine("");
    Console.WriteLine("Your Journey has ended.");

}
else if (userChoice1 == "2" || userChoice1 == "2." || userChoice1 == "explore the room" || userChoice1 == "Explore the room")
{
    Console.WriteLine("");
    Console.WriteLine("You explore the room. You notice a desk and a dresser.");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("");
    Console.WriteLine("\t 1. Examine the desk");
    Console.WriteLine("\t 2. Examine the dresser");

    string userChoice2 = Console.ReadLine();

    if (userChoice2 == "1" || userChoice2 == "1." || userChoice2 == "examine the desk" || userChoice1 == "Examine the desk")
    {
        Console.WriteLine("");
        Console.WriteLine("You examine the desk.");
        Console.WriteLine("The desk is dirty and unorganized. It is covered in a thin layer of dust.");
        Console.WriteLine("It is obvious learning hasn't taken place here for quite some time.");
        Console.WriteLine("");
        Console.Write("> Press 'Enter to continue . . . ");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("You obtained a paper and pencil.");
        Console.WriteLine("");

        Console.WriteLine("What do you want to do?");
        Console.WriteLine("");
        Console.WriteLine("\t 2. Examine the dresser");


        string userChoice2a = Console.ReadLine();

        if (userChoice2a == "2" || userChoice2a == "2." || userChoice2a == "examine the dresser" || userChoice2a == "Examine the dresser")
        {
            Console.WriteLine("");
            Console.WriteLine("You examine the dresser.");
            Console.WriteLine("Items are scattered on the top of the dresser.");
            Console.WriteLine("Clothes are carelessly stuffed into the drawers.");
            Console.WriteLine("");
            Console.Write("> Press 'Enter' to continue . . . ");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("You obtained a Pocket Knife.");
            Console.WriteLine("");

            Console.WriteLine("You leave through the window and embark on your journey.");

            Console.WriteLine("");
            Console.WriteLine("You run from Belchero Orphanage to the city center.");
            Console.WriteLine("You stop to catch your breath.");
            Console.WriteLine("The cold spring air burns your throat as it reaches your lungs.");
            Console.WriteLine("");
            Console.Write("> Press 'Enter' to continue . . . ");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("I suppose I could head towards The Abyss, or I can pay Laffi a visit.");
            Console.WriteLine("");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("");
            Console.WriteLine("\t 1. Head to Laffi's Shop");
            Console.WriteLine("\t 2. Venture towards The Abyss");

            string userChoice3a = Console.ReadLine();

            if (userChoice3a == "1" || userChoice3a == "1." || userChoice3a == "head to laffi's shop" || userChoice3a == "Head to Laffi's Shop")
            {
                Console.WriteLine("You head to Laffi's Shop.");
                Console.WriteLine("");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\t 1. Talk to Laffi");
                Console.WriteLine("\t 2. Talk to Hablog");

                string userChoice3aa = Console.ReadLine();
                if (userChoice3aa == "1" || userChoice3aa == "1." || userChoice3aa == "talk to laffi" || userChoice3aa == "Talk to Laffi")
                {
                    Console.WriteLine();
                    Console.WriteLine("''You look hungry, why don't you take a moment to eat something?''");
                    Console.WriteLine("You sit down to enjoy 'Laffi's Special Lunch.'");
                    Console.WriteLine(" ");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("You feel energy coursing through your body. You feel reinvigorated.");

                    Console.WriteLine(" ");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("\t 2. Talk to Hablog");

                    string userChoice3ab = Console.ReadLine();
                    if (userChoice3ab == "2" || userChoice3ab == "2." || userChoice3ab == "talk to hablog" || userChoice3ab == "Talk to Hablog")
                    {
                        Console.WriteLine("''Hey, " + playerName + " its been a while!''");
                        Console.WriteLine("''Would you like to use my telescope?''");
                        Console.WriteLine("");
                        Console.Write("> Press 'Enter to continue . . . ");
                        Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("You peer through the lens towards the First Layer of The Abyss.");
                        Console.WriteLine("You can see couds swirling above the opening. The Abyss is so deep it has it's own climate system.");

                        Console.WriteLine("");
                        Console.Write("> Press 'Enter to continue . . . ");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("''Beautiful isnt it? I suppose that's where you're heading?''");
                        Console.WriteLine("''I heard you're planning to make your final dive... Thank you for visiting me.''");

                    }

                }
                else if (userChoice3aa == "2" || userChoice3aa == "2." || userChoice3aa == "Talk to Hablog")
                {
                    Console.WriteLine("''Hey, " + playerName + " its been a while!''");
                    Console.WriteLine("''Would you like to use my telescope?''");
                    Console.WriteLine("");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("You peer through the lens towards the First Layer of The Abyss.");
                    Console.WriteLine("You can see couds swirling above the opening. The Abyss is so deep it has it's own climate system.");

                    Console.WriteLine("");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("''Beautiful isnt it? I suppose that's where you're heading?''");
                    Console.WriteLine("''I heard you're planning to make your final dive... Thank you for visiting me.''");

                }

            }
            else if (userChoice3a == "2" || userChoice3a == "2." || userChoice3a == "venture towards the abyss" || userChoice3a == "Venture towards The Abyss")
            {
                Console.WriteLine("");
                Console.WriteLine("You are not yet properly equipped to challenge The Abyss.");
                Console.WriteLine("Your Journey has ended.");
            }

        }
    }
    else if (userChoice2 == "2" || userChoice2 == "2." || userChoice2 == "examine the dresser" || userChoice1 == "Examine the dresser")
    {
        Console.WriteLine("");
        Console.WriteLine("Items are scattered on the top of the dresser.");
        Console.WriteLine("Clothes are carelessly stuffed into the drawers.");
        Console.WriteLine("");
        Console.Write("> Press 'Enter' to continue . . . ");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("You obtained a Pocket Knife.");
        Console.WriteLine("");

        Console.WriteLine("What do you want to do?");
        Console.WriteLine("");
        Console.WriteLine("\t 1. Examine the desk");

        string userChoice2b = Console.ReadLine();

        if (userChoice2b == "1" || userChoice2b == "1." || userChoice2b == "examine the desk" || userChoice2b == "Examine the desk")
        {
            Console.WriteLine("");
            Console.WriteLine("You examine the desk.");
            Console.WriteLine("The desk is dirty and unorganized. It is covered in a thin layer of dust.");
            Console.WriteLine("It is obvious learning hasn't taken place here for quite some time.");
            Console.WriteLine("");
            Console.Write("> Press 'Enter to continue . . . ");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("You obtained a paper and pencil.");
            Console.WriteLine("");
            Console.WriteLine("You leave through the window and embark on your journey.");


            Console.WriteLine("");
            Console.WriteLine("You run from Belchero Orphanage to the city center.");
            Console.WriteLine("You stop to catch your breath.");
            Console.WriteLine("The cold spring air burns your throat as it reaches your lungs.");
            Console.WriteLine("");
            Console.Write("> Press 'Enter' to continue . . . ");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("I suppose I could head towards The Abyss, or I can pay Laffi a visit.");
            Console.WriteLine("");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("");
            Console.WriteLine("\t 1. Head to Laffi's Shop");
            Console.WriteLine("\t 2. Venture towards The Abyss");

            string userChoice3b = Console.ReadLine();

            if (userChoice3b == "1" || userChoice3b == "1." || userChoice3b == "head to laffi's shop " || userChoice3b == "Head to Laffi's Shop")
            {
                Console.WriteLine("You head to Laffi's Shop.");

                Console.WriteLine("");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\t 1. Talk to Laffi");
                Console.WriteLine("\t 2. Talk to Hablog");

                string userChoice3bb = Console.ReadLine();

                if (userChoice3bb == "1" || userChoice3bb == "1." || userChoice3bb == "talk to laffi" || userChoice3bb == "Talk to Laffi")
                {
                    Console.WriteLine("''You look hungry, would you like a snack?''");
                    Console.WriteLine(" ");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("You obtain a Mustard Steamed Bun.");
                }
                else if (userChoice3bb == "2" || userChoice3bb == "2." || userChoice3bb == "talk to hablog" || userChoice3bb == "Talk to Hablog")
                {
                    Console.WriteLine("''Hey, " + playerName + " its been a while!''");
                    Console.WriteLine("''Would you like to use my telescope?''");
                    Console.WriteLine("");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("You peer through the lens towards the First Layer of The Abyss.");
                    Console.WriteLine("You can see couds swirling above the opening. The Abyss is so deep it has it's own climate system.");

                    Console.WriteLine("");
                    Console.Write("> Press 'Enter to continue . . . ");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("''Beautiful isnt it? I suppose that's where you're heading?''");
                    Console.WriteLine("''I heard you're planning to make your final dive... Thank you for visiting me.''");

                }


            }
            else if (userChoice3b == "2" || userChoice3b == "2." || userChoice3b == "venture towards the abyss" || userChoice3b == "Venture towards The Abyss")
            {
                Console.WriteLine("");
                Console.WriteLine("You are not yet properly equipped to challenge The Abyss.");
                Console.WriteLine("Your Journey has ended.");
            }
        }
    }
}
else if (userChoice1 == "3" || userChoice1 == "3." || userChoice1 == "leave through the window")
{
    Console.WriteLine("");
    Console.WriteLine("It's reckless to embark on your journey before collecting some equipment.");
    Console.WriteLine("");
    Console.WriteLine("Your Journey has ended.");
}
else
{
    Console.Write("\n");
    Console.WriteLine("Your Journey has ended.");
}

