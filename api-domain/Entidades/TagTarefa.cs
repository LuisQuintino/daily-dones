using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_domain.Entidades
{
    [Table("TagTarefa")]
    public class TagTarefa
    {
        [Key]
        public Guid CodigoTag { get; set; }
        public Guid CodigoTarefa { get; set; }
    }
}
