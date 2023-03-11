using ControleCaldeiras.Enums;

namespace ControleCaldeiras.Models
{
    public class CaldeiraModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public double? Temperatura { get; set; }
        public double? Pressao { get; set; }
        public double? Operador { get; set; }

        public StatusCaldeira Status { get; set; }

        public int? OperadorId { get; set; }

        public virtual OperadorModel? Operadorr { get; set; }

    }
}
