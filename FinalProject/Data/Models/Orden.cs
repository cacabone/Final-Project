using System.ComponentModel.DataAnnotations.Schema;
using FinalProject.Data.Enum;
namespace FinalProject.Data.Models
{
    public class Orden
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public OrderStatus Status { get; set; }

        public decimal Total { get; set; }
        
        //Relationships

        //Provider

        public int ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        public Provider Provider { get; set; }

        //User

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
