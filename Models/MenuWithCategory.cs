namespace MenuSistemi.Models
{
    public class MenuWithCategory
    {


        public List<TBLCategory> Category { get; set; }

        public List<MenuLeftJoinCategory> MenuLeftJoin { get; set; }

        public List<CategoryMenuCount> MenuCount { get; set; }


    }
}
