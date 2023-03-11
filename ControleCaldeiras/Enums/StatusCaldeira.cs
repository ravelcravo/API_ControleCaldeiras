using System.ComponentModel;

namespace ControleCaldeiras.Enums
{
    public enum StatusCaldeira
    {
        [Description("Abaixo do normal")]
        AbaixoNormal = 1,
        [Description("Normal")]
        Normal = 2,
        [Description("Fora do normal")]
        ForaNormal = 3
    }
}
