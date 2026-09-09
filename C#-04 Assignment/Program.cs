namespace C__04_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            //-------------------------------------------------------

            //Q2
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            //--------------------------------------------------------

            //Q3

            //int pages = 464;

            //string sizeLabel = (pages > 300) ? "Long Book" :"Short Book";
            //Console.WriteLine(sizeLabel);

            //--------------------------------------------------------

            //Q4

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i< books.Length; i++)
            //{
            //    Console.WriteLine($"Book number {i+1} is {books[i]}" );
            //}

            //---------------------------------------------------------

            //Q5

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;

            while(index < books.Length)
            {
                Console.WriteLine(books[index]);
                index ++;
            }

        }
    }
}
