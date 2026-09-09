using System.Text;

namespace C__04_Assignment
{
    internal class Program
    {
        static void PrintFirstBook(string[] arr)
        {
            if (arr == null)
            {
                return;
            }

            else
            {
                Console.WriteLine(arr[0]);
            }
        }

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

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int index = 0;

            //while(index < books.Length)
            //{
            //    Console.WriteLine(books[index]);
            //    index ++;
            //}

            //---------------------------------------------------------

            //Q6

            //int counter = 0;
            //do 
            //{
            //    Console.WriteLine("Checking book...");
            //    counter++;

            //} while (counter < 3);

            //---------------------------------------------------------

            //Q7

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books) { Console.WriteLine(book); }

            //----------------------------------------------------------

            //Q8

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{

            //    if (books[i] != "Refactoring")
            //    {
            //        Console.WriteLine(books[i]);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //---------------------------------------------------------

            //Q9

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i=0; i<books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(books[i]);
            //}

            //---------------------------------------------------------

            //Q10

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //PrintFirstBook(books);

            //=========================================================

            //Q1 String

            //string title = "clean code";
            //string title02 = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(title02);

            //==========================================================

            //Q2 String 

            //string s1 = "Clean Code";
            //string s2 = "Clean Code";

            //Console.WriteLine(ReferenceEquals(s1, s2)); 

            //==========================================================

            //Q3 String

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append("-Updated");
            //Console.WriteLine(sb);

            //==========================================================

            //Q4 String 

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("-Updated");
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);

        }
    }
}
