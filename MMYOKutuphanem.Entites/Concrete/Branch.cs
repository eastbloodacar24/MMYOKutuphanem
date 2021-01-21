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
    [Table("Branchs")]
    public class Branch : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
