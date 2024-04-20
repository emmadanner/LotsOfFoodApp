using SQLite;

namespace LotsOfFoodApp.Models
{
    internal class FoodItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Notes { get; set; }
        public bool AddToOrder { get; set; }
    }
}