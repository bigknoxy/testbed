using System;

namespace Demo.Model.Database
{
    public class Transaction
    {
        public virtual int Id { get; set; }
        public virtual string Region { get; set; }
        public virtual string Customer { get; set; }
        public virtual int SalesOrder { get; set; }
        public virtual string ProductType { get; set; }
        public virtual string Product { get; set; }
        public virtual string Uom { get; set; }
        public virtual decimal? Cost { get; set; }
        public virtual DateTime? InvoiceDate { get; set; }
        public virtual int SalesQty { get; set; }
        public virtual decimal? SalesAmount { get; set; }
        public virtual decimal? RebateByRevenue { get; set; }
        public virtual decimal? RebateByUnits { get; set; }
    }
}