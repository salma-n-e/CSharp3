using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 
            int pages = 464;
            bool isAvailable = true;
            if ( pages > 300 && isAvailable)
                {
                Console.WriteLine("You can borrow this book");
            }
            //2 
            string title = "Refactoring";
            
            switch (title)
            {
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }
        }
    }
}
