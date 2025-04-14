using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_domain.Entidades
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public Guid Codigo { get; set; }
        public string Descricao { get; set; }
        public string IdentificadorCorHex { get; set; }
        public Guid CodigoUsuario { get; set; }
    }
}
