using System;
using FileHelpers;

namespace Demo.Model.File
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class Transaction
    {
        [FieldOrder(7)] [FieldConverter(ConverterKind.Decimal, ".")] public decimal? Cost;

        [FieldOrder(2)] public string Customer;

        [FieldOrder(8)] [FieldConverter(ConverterKind.Date, "M/d/yyyy")] public DateTime? InvoiceDate;

        [FieldOrder(5)] public string Product;

        [FieldOrder(4)] public string ProductType;

        [FieldOrder(1)] public string Region;

        [FieldOrder(10)] public decimal? SalesAmount;

        [FieldOrder(3)] public int SalesOrder;

        [FieldOrder(9)] public int SalesQty;

        [FieldOrder(6)] public string Uom;
    }
}