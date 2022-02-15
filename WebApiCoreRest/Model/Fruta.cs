using System.ComponentModel.DataAnnotations;

namespace WebApiCoreRest.Model
{
    public class Fruta
    {
        [Key]
        public int IdFruta { get; set; }
        public string NombreFruta { get; set; }
        public string PesoFruta { get; set; }
        public DateTime FechaExpiracion { get; set; }
    }
}
