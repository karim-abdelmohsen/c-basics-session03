using System.Diagnostics.SymbolStore;
using System.Text;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question(1)
            //1- Declare string title = "clean code";. Call title.ToUpper() and store it in a new
            // variable upperTitle. Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string UpperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(UpperTitle);
            #endregion
            #region Question(2)
            //2- Declare two separate string variables, both set to the literal "Clean Code".
            // Use ReferenceEquals() to check if they point to the same object in memory.
            //string Book1= "Clean Code";
            //string Book2= "Clean Code";
            //Console.WriteLine(Equals(Book1,Book2)) ;
            #endregion
            #region Question(3)
            //3- Create a StringBuilder, Append() the text "Book List", then Append() " - Updated"
            // onto the same object. Print the final result.
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb.ToString());
            #endregion
            #region Question(4)
            //4- Using the StringBuilder from the question above, use Replace() to change
            // "Book List" into "Library". Print the result.
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());  
            #endregion
            #region Question(5)
            //5- Given string title = "Clean Code"; and int pages = 464;, build the sentence
            // "Book: Clean Code, Pages: 464" using the + operator.
            //string title5 = "Clean Code";
            //int pages5 = 464;
            //string sentence1 = "Book: " + title5 + ", Pages: " + pages5;
            //Console.WriteLine(sentence1);
            #endregion
            #region Question(6)
            //6- Build the same sentence as above, but using string interpolation ($"...").
            //string sentence2 = $"Book: {title5}, Pages: {pages5}";
            //Console.WriteLine(sentence2);
            #endregion
            #region Question(7)
            //7- Build the same sentence again, but using string.Format().
            //string sentence3 = string.Format("Book: {0}, Pages: {1}", title5, pages5);
            //Console.WriteLine(sentence3);
            #endregion
            #region Question(8)
            //8- Given int pages = 464;, write an if / else statement that prints "Long Book"
            // if pages is greater than 300, otherwise prints "Short Book".
            //int pages8 = 464;
            //if (pages8 > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion
            #region Question(9)
            //9- Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book"
            // only if pages is greater than 300 and isAvailable is true. Use the && operator.
            //int pages9 = 464;
            //bool isAvailable = true;
            //if (pages9 > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            #endregion
            #region Question(10)
            //10- Given string title = "Refactoring";, write a switch statement that prints
            // "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring",
            // and "Never heard of it" for anything else.
            string title10 = "Refactoring";
            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion




        }
    }
}
