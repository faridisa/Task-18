

namespace Task_18
{
    internal class CargoOrder
    {
        public static int id { get; set; }
        public string CourierId { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }


        public CargoOrder(int customerId, int courierId, decimal totalAmount)
        {
            id++;
            id = customerId;
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                throw new InvalidOperationException("Tamamlanmıs ve ya ləgv edilmis sifarisin statusu deyisdirile bilmez");
            }
        }
    }
}