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
            string title5 = "Clean Code";
            int pages5 = 464;
            string sentence1 = "Book: " + title5 + ", Pages: " + pages5;
            Console.WriteLine(sentence1);
            #endregion


        }
    }
}
