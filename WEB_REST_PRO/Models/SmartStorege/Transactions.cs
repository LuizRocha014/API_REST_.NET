namespace WEB_REST_PRO.Models.SmartStorege
{
    public class Transactions : Core
    {
        public tipoTransacao Type { get; set; } // Assuming this is an enum

        public Guid? SupplierId { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }

        public Guid? TargetCompanyId { get; set; }

        public Guid? OriginCompanyId { get; set; }

        public Guid UserId { get; set; }

        public string? PaymentMethod { get; set; }

        public string? Note { get; set; }

        public enum tipoTransacao
        {
            sale, buy,
        }
    }
}
