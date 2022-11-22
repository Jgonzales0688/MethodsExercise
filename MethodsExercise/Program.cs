namespace MethodsExercise
{
    public class Program
    {
        //---------------------Exercise 2 ------------------

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static void UseParams(params int[] list)
        {
            Console.WriteLine("---------------------Exercise 2 ------------------");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var sumExercise = Sum(2, 6);
            var multipExercise = Multiply(1, 2, 3);
            int[] myIntArray = { 1, 2, 3 };

            UseParams(myIntArray);

            Console.WriteLine(sumExercise);
            Console.WriteLine(multipExercise);


            Console.WriteLine("---------------------Exercise 1 ------------------");
            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is answesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favority band");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your story");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"The was a person named {userName}. \nThey owned the coolest {color} {animal},");
            Console.WriteLine($"That playedd in a band called {band}.\n-The End");
        }


    }
}
