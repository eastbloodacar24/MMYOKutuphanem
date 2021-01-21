using System;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using System.Collections.Generic;

namespace MMYOKutuphanem.Worker.Contrete.Managers
{
    public class BookManager : IBookService
    {
        private IBookDal _bookdal;
        public BookManager(IBookDal bookdal)
        {
            _bookdal = bookdal;
        }

        public Book Add(Book book)
        {
            return _bookdal.Add(book);
        }

        public Book Get(Func<Book, bool> condition = null)
        {
            return _bookdal.Get(condition);
        }

        public List<Book> GetList(Func<Book, bool> condition = null)
        {
            return _bookdal.GetList(condition);
        }

        public Book GetMAX(Func<Book, bool> condition = null)
        {
            return _bookdal.GetMAX(condition);
        }

        public Book Modify(Book book)
        {
            return _bookdal.Modify(book);
        }

        public int RecordCount(Func<Book, bool> condition = null)
        {
            return _bookdal.RecordCount(condition);
        }
        public string[] GetNames(Func<Book, bool> condition = null)
        {
            return _bookdal.GetNames(condition);
        }

        public long[] GetBarcodCodes(Func<Book, bool> condition = null)
        {
            return _bookdal.GetBarcodCodes(condition);
        }

        public List<Book> GetDataManagementList()
        {
            return _bookdal.GetDataManagementList();
        }

        public void SaveChanges()
        {
            _bookdal.SaveChanges();
        }
    }
}
