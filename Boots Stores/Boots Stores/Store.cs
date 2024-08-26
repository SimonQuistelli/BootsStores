namespace Boots_Stores
{
    public class Store
    {
        public int StoreNumber { get; set; }

        public string StoreName { get; set; }

        public Store(int storeNumber, string storeName)
        {
            StoreNumber = storeNumber;
            StoreName = storeName;
        }
    }
}