class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();
    
    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
    }
    
    public void DisplayPatrons()
    {
        Console.WriteLine("\nPatrons in Library:");
        foreach (var patron in Patrons)
        {
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
        }
    }
}