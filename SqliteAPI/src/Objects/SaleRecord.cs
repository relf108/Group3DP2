namespace SqliteAPI.Objects
{
    public class SaleRecord
    {
        public SaleRecord(int id, int orderID, string itemName, double itemValue, string saleDate)
        {
            this.id = id;
            this.orderID = orderID;
            this.itemName = itemName;
            this.itemValue = itemValue;
            this.saleDate = saleDate;
        }

        public int id { get; }
        public int orderID { get; }
        public string itemName { get; }
        public double itemValue { get; }
        public string saleDate { get; }
    }
}