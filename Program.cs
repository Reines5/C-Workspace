using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("1) Kitap Ekle");
                Console.WriteLine("2) Kitapları Listele");
                Console.WriteLine("3) Kitap Arama");
                Console.WriteLine("4) Kitap Silme");
                Console.WriteLine("5) Çıkış");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;

                    case "2":
                        ListBooks();
                        break;

                    case "3":
                        SearchBook();
                        break;

                    case "4":
                        DeleteBook();
                        break;

                    case "5":
                        continueRunning = false; break;

                    default:
                        Console.WriteLine("Geçersiz işlem..."); break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Kitap İsmini Giriniz: ");
            string title = Console.ReadLine();
            Console.Write("Yazar İsmini Giriniz: ");
            string author = Console.ReadLine();
            Console.Write("Yayın Yılını Giriniz: ");
            int year = Convert.ToInt32(Console.ReadLine());

            books.Add(new Book { Title = title, Author = author, Year= year});
        }

        static void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Listelinecek kitap bulunamadı.");
                return;
            }

            Console.WriteLine("Kitap Listesi:");
            foreach (var book in books) 
            { 
                Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Author}, Yıl: {book.Year}");
            }
        }

        static void SearchBook()
        {
            Console.Write("Aranacak Kitap İsmini Giriniz: ");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Geçersiz kitap ismi.");
                return;
            }

            var result = books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("Kitap bulunamadı.");
            }
            else
            {
                Console.WriteLine("Bulunan Kitaplar:");
                foreach (var book in result)
                {
                    Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Author}, Yıl: {book.Year}");
                }
            }
        }

        static void DeleteBook()
        {
            Console.Write("Silinecek Kitap İsmini Girin: ");
            string title = Console.ReadLine();

            var bookToRemove = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Kitap başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı.");
            }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
        }
    }
}
