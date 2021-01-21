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
    [Table("Users")]
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReadBooks { get; set; }
        public int BranchId { get; set; }
    }
}
