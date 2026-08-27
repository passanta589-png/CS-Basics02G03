using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS_Basics02G03
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region question01
            //1.Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            // object obj;
            // obj = new book();


            static void Print(object x)
            {
                Console.WriteLine(x);
            }
            #endregion


            #region question02
            //2.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book. 
            //(1)ToString
            {
                //book book = new book();
                //book.title = "Emma";
                //book.page = 150;
                //Console.WriteLine(book.ToString());

                //(2)Equals
                //Book book01 = new Book() { title = "Emma" , page = 150 } ;
                //Book book02 = new Book() { title = "Emma" , page = 150 } ;
                //Console.WriteLine(book01.Equals(book02));

                //(3)Gethashcode
                //Book book01 = new Book() { title = "Emma", page = 150 };
                //Book book02 = new Book() { title = "Emma" ,page = 150 };
                //Console.WriteLine(book01.GetHashCode());
                //Console.WriteLine(book02.GetHashCode());

                //(3)GetType
                //Book book = new Book() { title = "Emma", page = 150 };
                // Console.WriteLine(book.GetType());


            }

            #endregion

            #region question03 
            {
                // Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
                // int pages = "464";
                // Compile - time error — you can't put text (string) into an int variable.
                // int pages = 464;
            }

            #endregion

            #region question04

            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            // try
            {
                //   int x = 10;
                //   int y = 0;
                //   int result = x / y;
                //   Console.WriteLine(result);
            }
            // catch(Exception ex)
            {
                //    Console.WriteLine("Finally");
            }
            //Console.WriteLine("Done");
            #endregion

            #region question05
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            {
                //   int page = 300;
                //   float f = 75.5f;
                //    double d = f;
            }
            #endregion

            #region question06
            //Declare a double price = 49.99; then convert it into an int using a cast.
            {
                // double d = 49.99;
                // int x = Convert.ToInt32(d);
                // Console.WriteLine(x);
            }
            #endregion

            #region question07
            // Given string pagesText = "464";, convert it into an int using the Convert class
            {
                //string pageText = "464";
                //int pageIndex = Convert.ToInt32(pageText);
                //Console.WriteLine(pageText);
            }
            #endregion

            #region question08
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //{ string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(yearText);

            // string badText = "abc";
            // int bad;
            //bool rasult = int.TryParse(badText, out int text);
            //Console.WriteLine(rasult);
            // Console.WriteLine(badText);
            // if (rasult == true)
            {
                //      Console.WriteLine($"valid badtext , {badText}");

            }
            // else
            {
                //      Console.WriteLine("Invalid badtext");
            }
            #endregion

            #region question09
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            {
                // int pages = 464;
                //     string pagesText = pages.ToString("f1");
                //     Console.WriteLine(pagesText);
            }
            #endregion

            #region question10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            {
              //  object obj = 100; //Boxing
             //   int x = (int)obj; //Unboxing
              //  Console.WriteLine(x);

              //  object obj  = 100;

              //  double x = (int) obj;
              //  Console.WriteLine.(x);
            }

              #endregion

        }
    } 
}
