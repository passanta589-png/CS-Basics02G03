using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Basics02G03
{
    internal class Book
    {
        public string title { get; set; }
        public int page { get; set; }
        public override string ToString()
        {
            return $"title: {title},page:{page}";
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Book)
                return false;
            Book book = obj as Book;
            return book.title == title  && book.page == page ;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(title , page);
        }

    }
}
