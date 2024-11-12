using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_REST_PRO.Models.SmartStorege
{
    public class ShopCustomer : Core
    {
        public Guid CustomerId { get; set; }

        public Guid ShopId { get; set; }
    }
}
