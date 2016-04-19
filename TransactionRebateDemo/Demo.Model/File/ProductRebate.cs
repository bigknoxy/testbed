using FileHelpers;

namespace Demo.Model.File
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class ProductRebate
    {
        [FieldOrder(2)] public int Month;

        [FieldOrder(1)] public string ProductType;

        [FieldConverter(ConverterKind.Decimal, ".")] [FieldOrder(4)] public decimal RebateAmount;

        [FieldOrder(3)] public int Year;
    }
}