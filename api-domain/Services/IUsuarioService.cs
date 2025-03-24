using api_domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_domain.Services
{
	public interface IUsuarioService
	{
		public List<Usuario> ObterTodos();
		public void Inserir(Usuario usuario);
		public void Atualizar(Usuario usuario);
		public void Deletar(Usuario usuario);
	}
}
