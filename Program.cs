namespace Övning_obj_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book mybook = new Book("boken", "hej", "då");
            string Title = Console.ReadLine();
            string Author = Console.ReadLine();
           string Summary = Console.ReadLine();

        }
    }
    public class Book
    {
        public string Title;
        public string Author;
        public string Summary;

        public Book(string title1, string author2, string Summary1)
        {
            Title = title1;
            Author = author2;
            Summary = Summary1;
        }
        public void names()
        {
            Console.WriteLine(Title,Author, Summary);
            
        }


    }
}