using api_domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace api_domain.Repositories
{
	public interface IUsuarioRepository
	{
		public List<Usuario> GetAll();
		public void Insert(Usuario usuario);
		public void Update(Usuario usuario);
		public void Delete(Usuario usuario);
	}
}
