using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Program
{
    public class bookstructure
    {
        public static void Main()
        {
            Books b1 = new Books(101, "Bio", 20, "magazine");
            b1.PrintDetails();
            Books b2 = new Books(102, "Phy", 30, "novel");
            b2.PrintDetails();
            Books b3 = new Books(103, "civics", 20, "miscllenous");
        }
    }
    public struct Books
    {
        private int BOOKID;
        private string TITLE;
        private int PRICE;
        private string BOOKTYPE;
        public int bookid
        {
            get { return this.BOOKID; }
            set { this.BOOKID = value; }
        }
        public string Title
        {
            get { return this.TITLE; }
            set { this.TITLE = value; }
        }
        public int Price
        {
            get { return this.PRICE; }
            set { this.PRICE = value; }
        }
        public string booktype
        {
            get { return this.BOOKTYPE; }
            set { this.BOOKTYPE = value; }
        }
        public Books(int bookid, string title, int price, string booktype)
        {
            this.BOOKID = bookid;
            this.TITLE = title;
            this.PRICE = price;
            this.BOOKTYPE = booktype;
        }
        public void PrintDetails()
        {
            Console.WriteLine("BookId ={0} , Title ={1} ,Price={2} ,BookType={3}", this.BOOKID, this.TITLE, this.PRICE, this.BOOKTYPE);
        }
    }
    public enum bookType
    {
        magazine,
        novel,
        referenceBook,
        miscllenous
    }

}
