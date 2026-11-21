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
            string Book1= "Clean Code";
            string Book2= "Clean Code";
            Console.WriteLine(Equals(Book1,Book2)) ;
            #endregion
        }
    }
}
