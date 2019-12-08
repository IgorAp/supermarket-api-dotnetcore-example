using System.ComponentModel;

namespace supermarket.Domain.Models
{
    public enum EUityOfMeasurement
    {
        [Description("UN")]
        Unity = 1,
        [Description("MG")]
        Milligram = 2,
        [Description("G")]
        Gram = 3,
        [Description("KG")]
        Kilogram = 4,
        [Description("L")]
        Liter = 5
    }
}