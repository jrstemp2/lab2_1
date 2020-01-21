using System;

namespace stempowskiLab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain;
            string size;

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            do
            {


                Console.Write("Please Enter a room length: ");
                string input1 = Console.ReadLine();
                double length = double.Parse(input1);

                Console.Write("Please Enter a room width: ");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);

                Console.Write("Please Enter a room height: ");
                string input3 = Console.ReadLine();
                double height = double.Parse(input3);

                double area = (length * width);
                double perimeter = ((length * 2) + (width * 2));
                double volume = (length * width * height);

                if (area > 650)
                {
                    size = "Large";
                }
                else if (area >= 250)
                {
                    size = "Medium";
                }
                else
                {
                    size = "small";
                }
                Console.WriteLine("The Area of the Room is: " + area + " feet");
                Console.WriteLine("This is a " + size + " room!");
                Console.WriteLine("The Perimeter of the room is: " + perimeter + " feet");
                Console.WriteLine("The Volume of the room is: " + volume + " feet");
                Console.Write("Would you like to measure another room: (yes/no)");
                goAgain = Console.ReadLine();

            } while (goAgain == "yes" || goAgain == "y");

            Console.WriteLine("Thank you for using the Room Detail Generator!");
        }
    }
}

