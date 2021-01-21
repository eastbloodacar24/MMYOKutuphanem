using MMYOKutuphanem.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMYOKutuphanem.Entites.Concrete
{
    [Table("Books")]
    public class Book : IEntity
    {
        [Key]
        public int Id { get; set; }
        public long Barcod { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int RCount { get; set; }
        public int Statu { get; set; }
    }
}
