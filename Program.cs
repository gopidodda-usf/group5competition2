using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Library library = new Library();
        
        library.Books.Add(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        library.Books.Add(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        library.Books.Add(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));
        
        Student s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        Student s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
        Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
        
        library.Patrons.Add(s1);
        library.Patrons.Add(s2);
        library.Patrons.Add(staff1);
        
        library.DisplayBooks();
        library.DisplayPatrons();
        
        Console.WriteLine("\nBorrowing Books...");
        if (library.Books[1].BorrowBook())
            Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
        if (library.Books[2].BorrowBook())
            Console.WriteLine("Akhil borrowed 'Analytics in Action'");
        
        Console.WriteLine("\nBooks after borrowing:");
        library.DisplayBooks();
    }
}