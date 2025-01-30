namespace MenuSistemi.Models
{
    public class TBLMenu
    {
        public int MenuId { get; set; }

        public int CategoryId { get; set; }

        public string FoodName { get; set; }
        
        public int FoodPrice { get; set; }

        public string FoodImageUrl { get; set; }

        public string FoodDescription { get; set; }

        public TBLCategory Category { get; set; }
    }
}
