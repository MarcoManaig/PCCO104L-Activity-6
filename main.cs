using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter activity number (1-5) or 'exit' to close the program: ");
            string actInput = Console.ReadLine();

            if (actInput.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }

            if (int.TryParse(actInput, out int actNumber))
            {
                switch (actNumber)
                {
                    case 1:
                        Money();
                        break;

                    case 2:
                        FooBar();
                        break;

                    case 3:
                        Input();
                        break;

                    case 4:
                        Pyramid();
                        break;

                    case 5:
                        SumVSAppend();
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Activity does not exist.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid Input. Activity does not exist.");
            }
        }
    }

    static void Money()
    {
        Console.WriteLine("Enter denomination: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal denomination))
        {
            switch (denomination)
            {
                case 0.01m:
                case 0.05m:
                case 0.25m:
                    Console.WriteLine($"No Person is found in PHP {denomination}");
                    break;
                case 1:
                    Console.WriteLine($"Jose Rizal is found in PHP {denomination}");
                    break;
                case 5:
                    Console.WriteLine($"Emilio Aguinaldo is found in PHP {denomination}");
                    break;
                case 10:
                    Console.WriteLine($"Andres Bonifacio and Apolinario Mabini are found in PHP {denomination}");
                    break;
                case 20:
                    Console.WriteLine($"Manuel L. Quezon is found in PHP {denomination}");
                    break;
                case 50:
                    Console.WriteLine($"MSergio Osmena is found in PHP {denomination}");
                    break;
                case 100:
                    Console.WriteLine($"Manuel Roxas is found in PHP {denomination}");
                    break;
                case 200:
                    Console.WriteLine($"Diosdado Macapagal is found in PHP {denomination}");
                    break;
                case 500:
                    Console.WriteLine($"Benigno Aquino Sr. and Corazon Aquino are found in PHP {denomination}");
                    break;
                case 1000:
                    Console.WriteLine($"Jose Abad Santos, Vicente Lim, and Josefa Llanes Escoda are found in PHP {denomination}");
                    break;
                default:
                    Console.WriteLine("Invalid Denomination");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Invalid Input.");
        }
    }

    static void FooBar()
    {
        Console.WriteLine("Enter a value: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FooBar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Input()
    {
        Console.WriteLine("Enter text. Type 'exit' to close the program.");

        string input = Console.ReadLine();

        while (input.ToLower() != "exit")
        {
            Console.WriteLine("You entered: " + input);
            input = Console.ReadLine();
        }
        Console.WriteLine("Closing Program...");
    }

    static void Pyramid()
    {
       while(true){
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();

            if (int.TryParse(num, out int n) && n >= 0){
                if (n == 0){
                    Console.WriteLine("Closing Program...");
                    break;
                }
                for (int i = 0; i < n; i++){
                    for (int j = 0; j < n - i - 1; j++){
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * i + 1; j++){
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                }
            else{
                Console.WriteLine("Invalid Value");
            }
        }
    }


    static void SumVSAppend()
    {
        int prevNum = 0;
        string mess = "";

        while (true)
        {
            Console.WriteLine("Enter a value: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Closing the program... ");
                break;
            }

            int num;
            bool isNumeric = int.TryParse(input, out num);

            if (isNumeric)
            {
                int currNum = int.Parse(input);
                int sum = prevNum + currNum;

                Console.WriteLine($"Sum of {prevNum} and {currNum} is {sum}");
                prevNum = currNum;
            }
            else
            {
                mess += input + "";
                Console.WriteLine("Current message is " + mess);
            }
        }
    }
}