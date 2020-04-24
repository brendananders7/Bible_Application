using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bible_Application.Models
{
    public class BooksInBible
    {
        public List<Book> booksOfBible { get; set; }

        public BooksInBible()
        {
            this.booksOfBible = getBooksInBible();
        }

        public List<Book> getBooksInBible()
        {
            List<Book> booksList = new List<Book>();
            booksList.Add(new Book(1, "Genesis"));
            booksList.Add(new Book(2, "Exodus"));
            booksList.Add(new Book(3, "Leviticus"));
            booksList.Add(new Book(4, "Numbers"));
            booksList.Add(new Book(5, "Deuteronomy"));
            booksList.Add(new Book(6, "Joshua"));
            booksList.Add(new Book(7, "Judges"));
            booksList.Add(new Book(8, "Ruth"));
            booksList.Add(new Book(9, "1 Samuel"));
            booksList.Add(new Book(10, "2 Samuel"));
            booksList.Add(new Book(11, "1 Kings"));
            booksList.Add(new Book(12, "2 Kings"));
            booksList.Add(new Book(13, "1 Chronicles"));
            booksList.Add(new Book(14, "2 Chronicles"));
            booksList.Add(new Book(15, "Ezra"));
            booksList.Add(new Book(16, "Nehemiah"));
            booksList.Add(new Book(17, "Esther"));
            booksList.Add(new Book(18, "Job"));
            booksList.Add(new Book(19, "Psalm"));
            booksList.Add(new Book(20, "Proverbs"));
            booksList.Add(new Book(21, "Ecclesiastes"));
            booksList.Add(new Book(22, "Song of Songs"));
            booksList.Add(new Book(23, "Isaiah"));
            booksList.Add(new Book(24, "Jeremiah"));
            booksList.Add(new Book(25, "Lamentations"));
            booksList.Add(new Book(26, "Ezekiel"));
            booksList.Add(new Book(27, "Daniel"));
            booksList.Add(new Book(28, "Hosea"));
            booksList.Add(new Book(29, "Joel"));
            booksList.Add(new Book(30, "Amos"));
            booksList.Add(new Book(31, "Obadiah"));
            booksList.Add(new Book(32, "Jonah"));
            booksList.Add(new Book(33, "Micah"));
            booksList.Add(new Book(34, "Nahum"));
            booksList.Add(new Book(35, "Habakkuk"));
            booksList.Add(new Book(36, "Zephaniah"));
            booksList.Add(new Book(37, "Haggai"));
            booksList.Add(new Book(38, "Zechariah"));
            booksList.Add(new Book(39, "Malachi"));
            booksList.Add(new Book(40, "Matthew"));
            booksList.Add(new Book(41, "Mark"));
            booksList.Add(new Book(42, "Luke"));
            booksList.Add(new Book(43, "John"));
            booksList.Add(new Book(44, "Acts"));
            booksList.Add(new Book(45, "Romans"));
            booksList.Add(new Book(46, "1 Corinthians"));
            booksList.Add(new Book(47, "2 Corinthians"));
            booksList.Add(new Book(48, "Galatians"));
            booksList.Add(new Book(49, "Ephesians"));
            booksList.Add(new Book(50, "Philippians"));
            booksList.Add(new Book(51, "Colossians"));
            booksList.Add(new Book(52, "1 Thessalonians"));
            booksList.Add(new Book(53, "2 Thessalonians"));
            booksList.Add(new Book(54, "1 Timothy"));
            booksList.Add(new Book(55, "2 Timothy"));
            booksList.Add(new Book(56, "Titus"));
            booksList.Add(new Book(57, "Philemon"));
            booksList.Add(new Book(58, "Hebrews"));
            booksList.Add(new Book(59, "James"));
            booksList.Add(new Book(60, "1 Peter"));
            booksList.Add(new Book(61, "2 Peter"));
            booksList.Add(new Book(62, "1 John"));
            booksList.Add(new Book(63, "2 John"));
            booksList.Add(new Book(64, "3 John"));
            booksList.Add(new Book(65, "Jude"));
            booksList.Add(new Book(66, "Revelation"));

            return booksList;
        }

    }

    public class Book
    {
        public Book(int referenceNum, string name)
        {
            this.referenceNum = referenceNum;
            Name = name;
        }

        public int referenceNum { get; set; }
        public String Name { get; set; }

    }
}