using MMYOKutuphanem.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MMYOKutuphanem.Entites.Concrete
{
    [Table("Assigments")]
    public class Assignment : IEntity
    {
            [Key]
            public int Id { get; set; }
            public int UserId { get; set; }
            public int AssignDate { get; set; }
            public int ReturnDate{ get; set; }
            public int DealedDate { get; set; }
            public string Notes { get; set; }
            public long Barcod { get; set; }
            public int Statu { get; set; }
    }
}
