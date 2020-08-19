namespace PHPSales.SqliteAPI.Objects
{
    public class SaleRecord
    {
        public SaleRecord(int id, string itemName, double itemValue, string saleDate)
        {
            this.id = id;
            this.itemName = itemName;
            this.itemValue = itemValue;
            this.saleDate = saleDate;
        }

        public int id { get; }
        public string itemName { get; }
        public double itemValue { get; }
        public string saleDate { get; }
    }
}