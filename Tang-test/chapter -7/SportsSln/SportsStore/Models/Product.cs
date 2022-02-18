using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    public class Product
    {
        public long ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        [Column(TypeName="decimal(8,2)")]   //Mapping to database Column
        public decimal Price { set; get; }
        public string Category { set; get; }
    }
}