using MMYOKutuphanem.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMYOKutuphanem.Worker.Abstract
{
    public interface IBookService 
    {
        Book Add(Book book);
        Book Modify(Book book);
        List<Book> GetList(Func<Book, bool> condition = null);
        Book Get(Func<Book, bool> condition = null);
        string[] GetNames(Func<Book, bool> condition = null);
        long[] GetBarcodCodes(Func<Book, bool> condition = null);
        int RecordCount(Func<Book, bool> condition = null);
        Book GetMAX(Func<Book, bool> condition = null);
        List<Book> GetDataManagementList();
        void SaveChanges();
    }
}
