using Microsoft.EntityFrameworkCore;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context
{
    public class MySqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string _servername = "";
            string _databasename = "";
            string _userid = "";
            string _password = "";
            string _connnectionstring = "Server=" + _servername + ";Port=3306;Database=" + _databasename + ";User ID=" + _userid + ";Password=" + _password + "";

            optionsBuilder.UseMySQL(_connnectionstring);
        }

        public MySqlContext()
        {
         
        }
        DbSet<Assignment> Assigments { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Branch> Branchs { get; set; }
        DbSet<Book> Books { get; set; }
    }
}
