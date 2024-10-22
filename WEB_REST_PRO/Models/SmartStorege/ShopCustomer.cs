using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_REST_PRO.Models.SmartStorege
{
    public class ShopCustomer : Core
    {
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }

        [ForeignKey("Shop")]
        public Guid ShopId { get; set; }

        public virtual Customer? Customer { get; set; }

        public virtual Shop? Shop { get; set; }
    }
}
