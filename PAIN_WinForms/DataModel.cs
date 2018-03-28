using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_WinForms
{
    public class Book
    {
        public event EventHandler RaiseEditEvent;
        
        protected virtual void OnRaiseEditEvent()
        {
            RaiseEditEvent?.Invoke(this, null);
        }

        public String Title { get; private set; }
        public String Author { get; private set; }
        public DateTime Date { get; private set; }
        public String Category { get; private set; }

        public void SetValues(String title, String author, DateTime date, String category)
        {
            this.Title = title;
            this.Author = author;
            this.Date = date;
            this.Category = category;
            OnRaiseEditEvent();
        }

        public Book(String title, String author, DateTime date, String category)
        {
            this.Title = title;
            this.Author = author;
            this.Date = date;
            this.Category = category;
        }
    }

    public class BookEventArgs : EventArgs
    {
        public Book Book { get; private set; }
        public BookEventArgs(Book book)
        {
            this.Book = book;
        }
    }

    public class BookList : IEnumerable<Book>
    {
        public delegate void BookEventHandler(object sender, BookEventArgs args);
        public event BookEventHandler RaiseAddEvent;
        public event BookEventHandler RaiseEditEvent;
        public event BookEventHandler RaiseDeleteEvent;

        private List<Book> books;

        public BookList()
        {
            books = new List<Book>();
        }

        public void AddBook(String title, String author, DateTime date, String category)
        {
            Book b = new Book(title, author, date, category);
            b.RaiseEditEvent += HandleElementEditEvent;
            books.Add(b);
            OnRaiseBookEvent(b, RaiseAddEvent);
        }

        public void Remove(Book book)
        {
            OnRaiseBookEvent(book, RaiseDeleteEvent);
            books.Remove(book);
        }

        void HandleElementEditEvent(object sender, EventArgs args)
        {
            Book book = (Book)sender;
            OnRaiseBookEvent(book, RaiseEditEvent);
        }

        protected virtual void OnRaiseBookEvent(Book book, BookEventHandler handler)
        {
            handler?.Invoke(this, new BookEventArgs(book));
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return ((IEnumerable<Book>)books).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Book>)books).GetEnumerator();
        }

        public Book this[int i]
        {
            get { return books[i]; }
        }

    }
}
