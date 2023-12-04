using IComparable_Example;

List<Book> books = new List<Book>();

books.Add(new Book(){ Title = "Java", Price = 1150 });
books.Add(new Book(){ Title = "ASP .Net", Price = 1200 });

books.Sort();

foreach (Book book in books)
{
    Console.WriteLine(book.Title + "," + book.Price);
}