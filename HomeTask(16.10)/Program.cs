namespace HomeTask_16._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book(18.00, 1, 28, "To Kill a Mockingbird", "Classic");

            library.AddBook(book1);


            while (true)
            {
                Console.WriteLine("Kitabxanaya xos geldiniz");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1.Kitab elave etmek ucun 1 secin.");
                Console.WriteLine("2.Min ve max qiymetler daxil ederek kitablari filter etmek ucun 2 secin.");
                Console.WriteLine("3.Janra gore kitablari filter etmek ucun 3 secin.");
                Console.WriteLine("4.Kitabxanadaki kitablarin siyahisini gormek ucun 4 secin.");
                Console.WriteLine("Proqramdan cixis etmek ucun 0 secin.");
                Console.WriteLine("");
                Console.WriteLine("Zehmet olmasa qiymet daxil edin:");

                string input = (Console.ReadLine());

                if (input == "1")
                {
                    Console.Write("Kitabin adini daxil edin:");
                    string name = Console.ReadLine();

                    Console.WriteLine(" ");

                    Console.Write("Kitabin qiymetini daxil edin:");


                    double price = double.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.Write("Kitabin sayini daxil edin:");
                    int count = int.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.Write("Kitabin janrini daxil edin:");
                    string genre = Console.ReadLine();

                    Console.WriteLine(" ");

                    Console.Write("Zehmet olmasa kitabin nomresini daxil edin:");
                    int i = int.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.WriteLine("Qeyd etdiyiniz kitab ugurla kitabxanaya elave olundu.");
                    continue;
                }
                else if (input == "2")
                {
                    Console.Write("Zehmet olmasa minimum qiymet daxil edin:");
                    double minPrice = double.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.Write("Zehmet olmasa maximum qiymet daxil edin:");
                    double maxPrice = double.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Book filteredBook = library.GetFilteredBooks(minPrice, maxPrice);

                    if (filteredBook != null)
                    {
                        Console.WriteLine("Daxil etdiyiniz qiymet uzre kitablar:");
                        Console.WriteLine(" ");
                        filteredBook.showInfo();

                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz qiymet uzre kitab tapilmadi.");
                    }

                    Console.WriteLine("");

                }

                else if (input == "3")
                {
                    Console.Write("Zehmet olmasa filterlemek istediyiniz janri daxil edin:");
                    string genre = Console.ReadLine();

                    Book filteredBook = library.GetFilteredBooks(genre);
                    if (filteredBook != null)
                    {
                        Console.WriteLine("Secdiyiniz janr uzre kitablar:");
                        Console.WriteLine(" ");
                        filteredBook.showInfo();
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz janr uzre kitab tapilmadi.");
                    }



                }
                else if (input == "3")
                {
                    library.ShowAllBooks();
                    Console.WriteLine(" ");
                }

                else if (input == "0")
                {
                    Console.WriteLine("Proqramdan cixilir.");
                    break;
                }

                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Yanlis secim etdiniz.Zehmet olmasa ancaq yuxarida qeyd olunan secimlerden birini edin.");
                    continue;
                }

            }
        }
    }
}
