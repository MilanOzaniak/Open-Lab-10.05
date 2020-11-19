using System;

namespace Open_Lab_10._05
{
    class Program
    {
        static void Main(string[] args)
        {

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.Print);

            Console.WriteLine();

            Book LOTR3 = new Book("The Fellowship of the Ring", 400);
            Console.WriteLine(LOTR3.Print);

            Console.WriteLine();

            Book HOBBIT = new Book("Hobbit", "J. R. R. Tolkien", 2012, "Adventure", 430);
            HOBBIT.Category = Book.categoryList[4];
            Console.WriteLine(HOBBIT.Print);


        }
    }
}
