using System;

class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */
      //This choose your own adventure is using user input to continue key aspects of the adventure. Using if statements and boolean operators to check to give specific outcomes for all options to an adventure

      //Obtaining the users name to begin the adventure
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      //Obtaining first option
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      string choiceOne = noiseChoice.ToUpper();

      if (choiceOne == "NO")
        {
          Console.WriteLine("Not much of an adventure if we don't leave our room...");
          Console.WriteLine("THE END.");
        }
        else if (choiceOne == "YES")
        {
          Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
          Console.WriteLine("You walk towards it. Do you open it or knock?");
        
      
          Console.Write("Type OPEN or KNOCK: ");
          string doorChoice = Console.ReadLine();
          string choiceTwo = doorChoice.ToUpper();

          if (choiceTwo == "KNOCK")
          {
            Console.WriteLine("A voice behind the door speaks. It says,");
            Console.WriteLine("\"Answer this riddle:\"");
            Console.WriteLine("\"poor people have it. Rich people need it. If you eat it, you die. What is it?\"");
            Console.WriteLine("Type your answer: ");
            string riddleAnswerLower = Console.ReadLine();
            string riddleAnswer = riddleAnswerLower.ToUpper();
            if (riddleAnswer == "NOTHING")
            {
            Console.WriteLine("The door opens and NOTHING is there. Strange...");
            Console.WriteLine("THE END.");
            }
            else
            {
             Console.WriteLine("You answered incorrectly. The door doesn't open.");
             Console.WriteLine("THE END.");
            }
          }
          else if (choiceTwo == "OPEN")
          {
            Console.WriteLine("The door is locked! See if one of your three keys will open it.");
            Console.WriteLine("Enter a number (1-3): ");
            string keyChoiceLower = Console.ReadLine();
            string keyChoice = keyChoiceLower.ToUpper();
            switch (keyChoice)
            {
              case "1":
              Console.WriteLine("You choose the first key. Lucky choice!");
              Console.WriteLine("The door opens and NOTHING is there. Strange...");
              Console.WriteLine("THE END.");
              break;

              case "2":
              Console.WriteLine("You choose the second key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;

              case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            }
          }   
          
        }
     }
  }