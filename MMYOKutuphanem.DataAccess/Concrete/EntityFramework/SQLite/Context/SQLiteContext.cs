using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MMYOKutuphanem.Entites.Concrete;
using System.Windows.Forms;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite
{
    public class SQLiteContext : DbContext
    {
        private static readonly string DatabasePath = Application.StartupPath + "\\data\\";
        private static readonly string DatabaseName = "MMYOKutuphanem.sqlite";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = DatabasePath + DatabaseName };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            optionsBuilder.UseSqlite(connectionString);
        }

        public SQLiteContext()
        {
       
        }
        DbSet<Assignment> Assigments { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Branch> Branchs { get; set; }
        DbSet<Book> Books { get; set; }
    }
}
