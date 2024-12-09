using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Data.Models
{
    public class Details
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal Price_Per_Unit { get; set; }

        public decimal Total { get; set; }

        //Relationships

        //Product 

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Producto Product { get; set; }

        //Order

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Orden Order { get; set; }
    }
}
