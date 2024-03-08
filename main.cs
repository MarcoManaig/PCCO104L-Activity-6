using System;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine("Choose the Activity that you want to do");

    while(true)
    {
            Console.WriteLine("\nSelect an activity from 1-5 (O to exit):" );

            string activityChoice = Console.ReadLine();

            switch (activityChoice)
            {
                case "1":
                    Money();
                    break;
                case "2":
                    FooBar();
                    break;
                case "3":
                    Input();
                    break;
                case "4":
                    Pyramid();
                    break;
                case "5":
                    SumAppend();
                    break;
                case "0":
                    Console.WriteLine("Closing Program...");
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    static void Money()
      {
Console.WriteLine("Welcome to Philippine Bank Note Scanner!");
        Console.WriteLine("Please enter the denomination (in PHP):");

        if (double.TryParse(Console.ReadLine(), out double denomination))
        {
            string personality = banknotepersonality(denomination);
            if (personality != null)
                Console.WriteLine($"Personality found on {denomination} PHP: {personality}");
            else
                Console.WriteLine("No person is found on the banknote.");
        }
        else
        {
            Console.WriteLine("Invalid Denomination");
        }
    }

    static string banknotepersonality(double denomination)
    {
        switch (denomination)
        {
            case 1: return "Jose Rizal";
            case 5: return "Emilio Aguinaldo";
            case 10: return "Andres Bonifacio, Apolinario Mabini";
            case 20: return "Manuel L. Quezon";
            case 50: return "Sergio Osmena";
            case 100: return "Manuel Roxas";
            case 200: return "Diosdado Macapagal";
            case 500: return "Benigno Sr. and Corazon Aquino";
            case 1000: return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            default: return null;
        }
    }

    static void FooBar()
    {
    int num = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i <= num; i++){
        if (i % 3 == 0 && i % 5 == 0){
          Console.WriteLine($"{i} - Foobar");
          }
        else if (i % 5 == 0){
          Console.WriteLine($"{i} - Bar");
          }
        else if (i % 3 == 0){
          Console.WriteLine($"{i} - Foo");
          }
        else{
          Console.WriteLine(i);
          }
    }
    }
    static void Input()

    {   Console.WriteLine("Enter text or type 'exit' to end the program:");

          string input;
          while ((input = Console.ReadLine()) != "exit")
          {
              Console.WriteLine("You entered this text: " + input);
          }

          Console.WriteLine("Closing Program... ");
          Console.ReadKey();
      }
    static void Pyramid()
      {
        int num;
        bool valid;

        do { Console.Write("Enter the number of rows: ");
             string input = Console.ReadLine();

             valid = int.TryParse(input, out num) && num >= 0;

            if(!valid) {
                Console.Write("Invalid Input, Input a non-negative Integer:  ");
            } 

            else if (num == 0) {
                Environment.Exit(0);
            }
            else {
             for (int i = 1; i <= num; i++) {
                    for (int j = 1; j <= num - i; j++) {
                    Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++) {
                        Console.Write("*");
                        if (j < i) {
                            Console.Write("*");
                        }
                    }

                    Console.WriteLine();
                }
            }

        } while (!valid || num != 0);
     }
      static void SumAppend()                    {
        string inputstring = "String of words: ";
        int sumofintegers = 0;

        while (true)
        {
            Console.Write("Enter a string or an integer(Enter 'exit' to exit program): ");
            string userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                sumofintegers += number;
                Console.WriteLine("Sum of integers: " + sumofintegers);
            }
            else
            {
               inputstring += userInput;
               Console.WriteLine(inputstring); 
            }
        }
      }
}