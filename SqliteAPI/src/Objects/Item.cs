
namespace SqliteAPI.Objects
{
    public class Item
    {
        public int id { get; }
        public string name { get; }
        public double value { get; }

        public Item(int id, string name, double value)
        {
            this.id = id;
            this.name = name;
            this.value = value;
        }
    }
}