namespace Dapr.DispatchService.Domain.Models
{
    public class OrderLine
    {
        public string ProductCode { get; set; }

        public int Quantity { get; set; }
    }
}