﻿using WebApiDemo.Entities;

namespace WebApiDemo.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        int AddBook(Book book);

        int UpdateBook(Book book);

        int DeleteBook(int id);


    }
}
