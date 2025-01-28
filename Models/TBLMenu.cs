namespace MenuSistemi.Models
{
    public class TBLMenu
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string FoodName { get; set; }
        
        public int FoodPrice { get; set; }

        public string FoodImageUrl { get; set; }

        public TBLCategory Category { get; set; }
    }
}
