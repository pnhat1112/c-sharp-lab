using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        BookList bookList = new BookList();
        bookList.InputList();
        bookList.DisplayList();
        while (true)
        {
            Console.WriteLine("Welcome to Minh Nhat EXERCISES BOOKS");
            Console.WriteLine("1.Sort ASC by Title");
            Console.WriteLine("2.Sort ASC by Author");
            Console.WriteLine("3.Sort ASC by Publisher");
            Console.WriteLine("4.Sort ASC by ISBN");
            Console.WriteLine("5.Sort by Year");
            int chooseFunc = Convert.ToInt32(Console.ReadLine());
            List<Book> listOfBook= new List<Book>();
            if (chooseFunc > 5 || chooseFunc < 1)
            {
                Console.WriteLine("Please re-Enter Function");
                chooseFunc = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                switch (chooseFunc)
                {
                    case 1:
                        List<Book> listSortTitle = new List<Book>();
                        listSortTitle = bookList.GetListBook();
                        /*listOfemployees.Add(new Book("b", "John", "b", "a", 2000));
                        listOfemployees.Add(new Book("f", "John", "b", "a", 2000));
                        listOfemployees.Add(new Book("e", "John", "b", "a", 2000));*/

                        BookComparer compareTitle = new BookComparer();
                        compareTitle.compareByFields = BookComparer.sortBy.title;
                        listSortTitle.Sort(compareTitle);
                        Console.WriteLine("Sort ARC by Title");
                        foreach (Book emp in listSortTitle)
                        {
                            Console.WriteLine("Title: " + emp.GetBookTitle() + " | Author: " + emp.GetBookAuthor() + " | Publisher: " + emp.GetBookPublisher() +
                                " | ISBN: " + emp.GetBookISBN() + " | Year: " + emp.GetBookYear());
                        }
                        break;
                    case 2:
                        List<Book> listSortAuthor = new List<Book>();
                        listSortAuthor = bookList.GetListBook();

                        BookComparer compareAuthor = new BookComparer();
                        compareAuthor.compareByFields = BookComparer.sortBy.author;
                        listSortAuthor.Sort(compareAuthor);
                        Console.WriteLine("Sort ARC by Author");
                        foreach (Book emp in listSortAuthor)
                        {
                            Console.WriteLine("Title: " + emp.GetBookTitle() + " | Author: " + emp.GetBookAuthor() + " | Publisher: " + emp.GetBookPublisher() +
                                " | ISBN: " + emp.GetBookISBN() + " | Year: " + emp.GetBookYear());
                        }
                        break;
                    case 3:
                        List<Book> listSortPublisher = new List<Book>();
                        listSortPublisher = bookList.GetListBook();

                        BookComparer comparePublisher = new BookComparer();
                        comparePublisher.compareByFields = BookComparer.sortBy.publisher;
                        listSortPublisher.Sort(comparePublisher);
                        Console.WriteLine("Sort ARC by Publisher");
                        foreach (Book emp in listSortPublisher)
                        {
                            Console.WriteLine("Title: " + emp.GetBookTitle() + " | Author: " + emp.GetBookAuthor() + " | Publisher: " + emp.GetBookPublisher() +
                                " | ISBN: " + emp.GetBookISBN() + " | Year: " + emp.GetBookYear());
                        }
                        break;
                    case 4:
                        List<Book> listSortISBN = new List<Book>();
                        listSortISBN = bookList.GetListBook();

                        BookComparer compareISBN = new BookComparer();
                        compareISBN.compareByFields = BookComparer.sortBy.isbn;
                        listSortISBN.Sort(compareISBN);
                        Console.WriteLine("Sort ARC by ISBN");
                        foreach (Book emp in listSortISBN)
                        {
                            Console.WriteLine("Title: " + emp.GetBookTitle() + " | Author: " + emp.GetBookAuthor() + " | Publisher: " + emp.GetBookPublisher() +
                                " | ISBN: " + emp.GetBookISBN() + " | Year: " + emp.GetBookYear());
                        }
                        break;
                    case 5:
                        List<Book> listSortYear = new List<Book>();
                        listSortYear = bookList.GetListBook();

                        BookComparer compareYear = new BookComparer();
                        compareYear.compareByFields = BookComparer.sortBy.year;
                        listSortYear.Sort(compareYear);
                        Console.WriteLine("Sort ARC by Year");
                        foreach (Book emp in listSortYear)
                        {
                            Console.WriteLine("Title: " + emp.GetBookTitle() + " | Author: " + emp.GetBookAuthor() + " | Publisher: " + emp.GetBookPublisher() +
                                " | ISBN: " + emp.GetBookISBN() + " | Year: " + emp.GetBookYear());
                        }
                        break;
                }
            }

        }
    }

    interface IBook
    {
        public string this[int index]
        {
            get; set;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        void Display();

    }

    public class Book : IBook 
    {
        private string title;
        private string author;
        private string publisher;
        private int year;
        private string isbn;
        private ArrayList chapter = new ArrayList();

        public Book(string title, string author, string publisher,  string isbn, int year)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.isbn = isbn;
        }

        public string GetBookTitle()
        {
            return title;
        }

        public void SetBookName(string title)
        {
            this.title = title;
        }

        public string GetBookAuthor()
        {
            return author;
        }

        public void SetBookAuthor(string author)
        {
            this.author = author;
        }
        public string GetBookPublisher()
        {
            return publisher;
        }

        public void SetBookPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public int GetBookYear()
        {
            return year;
        }
        public void SetBookYear(int year)
        {
            this.year = year;
        }
        public string GetBookISBN()
        {
            return isbn;
        }

        public void SetBookISBN(string isbn)
        {
            this.isbn = isbn;
        }

        public Book()
        {

        }

        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ISBN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public void Input()
        {
            Console.WriteLine("Enter Title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter Publisher: ");
            publisher = Console.ReadLine();
            Console.WriteLine("Enter ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chapter {finish when empy string} ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);

        }
        public void Display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("----------");
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new ArgumentOutOfRangeException();

            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
    public class BookComparer : IComparer<Book>
    {

        public enum sortBy
        {
            title,
            author,
            publisher,
            year,
            isbn
        }

        //Sort two employee Ages  
        public sortBy compareByFields = sortBy.title;
        public int Compare(Book x, Book y)
        {
            switch (compareByFields)
            {
                case sortBy.title:
                    return x.GetBookTitle().CompareTo(y.GetBookTitle());
                case sortBy.author:
                    return x.GetBookAuthor().CompareTo(y.GetBookAuthor());
                case sortBy.publisher:
                    return x.GetBookPublisher().CompareTo(y.GetBookPublisher());
                case sortBy.year:
                    return x.GetBookYear().CompareTo(y.GetBookYear());
                case sortBy.isbn:
                    return x.GetBookISBN().CompareTo(y.GetBookISBN());
                default: break;

            }
            return x.GetBookTitle().CompareTo(y.GetBookTitle());

        }

        /*int IComparer<Book>.Compare(Book? x, Book? y)
        {
            throw new NotImplementedException();
        }*/
    }
    
    public class BookList
    {
        public static List<Book> list = new List<Book>();
        
        public void addBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void DisplayList()
        {
            foreach (Book b in list)
            {
                b.Display();
            }
        }
        public void InputList()
        {
            int n;
            Console.WriteLine("Amount Of Books: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                addBook();
                n--;
            }
        }
        public List<Book> GetListBook()
        {
            List<Book> propertyList = new List<Book>();
            if (list != null)
            {
                foreach (var prop in list)
                {
                    propertyList.Add(prop);
                }
            }
            return propertyList;
        }
        internal void Sort(BookComparer compare)
        {
            throw new NotImplementedException();
        }
    }
}