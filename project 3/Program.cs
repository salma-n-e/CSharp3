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
            //3 
            int pages2 = 464;
            string sizeLabel = pages2 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            //4
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            //5
            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;

            while (index < books2.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            //6
            int count = 0;

            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);


            //7

            string[] books3 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books3)
            {
                Console.WriteLine(book);
            }
        }
        
    }
}
