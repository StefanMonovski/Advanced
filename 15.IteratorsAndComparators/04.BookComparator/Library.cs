using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            Books.Sort(new BookComparator());
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            public List<Book> Books { get; set; }
            private int Index = -1;

            public LibraryIterator(List<Book> books)
            {
                Books = books;
            }

            public Book Current => Books[Index];

            object IEnumerator.Current => Books[Index];

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++Index < Books.Count;
            }

            public void Reset()
            {
                Index = -1;
            }
        }
    }
}
