using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_domain.Entidades
{
	[Table("Usuario")]
	public class Usuario
	{
		[Key]
		public Guid Codigo { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
	}
}
