namespace Övning_obj_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv boken");
            String bok = Console.ReadLine();
            Console.WriteLine("Skriv författaren");
            String författare = Console.ReadLine();
            Console.WriteLine("Vad tyckte du om boken?");
            String omdöme = Console.ReadLine();
            Book mybook = new Book(bok, författare, omdöme);
            mybook.names();


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
            Console.WriteLine(Title +  " är boken," + Author + " är författaren.");
            
        }


    }
}