using System;

namespace UnitOfWork
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime CreateDate { get; set; }
    }
}