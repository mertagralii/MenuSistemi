namespace MenuSistemi.Models
{
    public class MenuLeftJoinCategory
    {
        public int MenuId { get; set; }

        public string CategoryId { get; set; }
        public string FoodName { get; set; }

        public int FoodPrice { get; set; }

        public string FoodImageUrl { get; set; }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string FoodDescription { get; set; }

        public int CategorySum { get; set; }
    }
}
