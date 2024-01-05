class Library
{
    public string Name;
    public List<Book> Books;
    public Library(){}
    public Library(string name)
    {
        Name = name;
    }    
    public void AddBook(Book book)
    {
    }
    public void RemoveBook(Book book)
    {
    }
    public void SearchBook(string title)
    {
    }
}

class Book
{
    public string Title;
    public string Author;
    public int PublicationYear;
    public Book() {}
    public Book(string title,string author,int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
}