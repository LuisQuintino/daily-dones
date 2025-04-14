using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_domain.Entidades.Enumeradores;
using api_domain.Messaging.Tarefa;

namespace api_domain.Entidades
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [Key]
        public Guid Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public SituacaoTarefa Situacao { get; set; }
        public DateTime DtSituacao { get; set; }
        public Guid CodigoUsuario { get; set; }

        public Tarefa() {}

        public Tarefa(InserirTarefaRequest inserirTarefaRequest)
        {
            Descricao = inserirTarefaRequest.Descricao;
            DtInclusao = DateTime.Now;
            Situacao = inserirTarefaRequest.Situacao;
            DtSituacao = DateTime.Now;
            CodigoUsuario = inserirTarefaRequest.CodigoUsuario;
        }

        public void Atualizar(AtualizarTarefaRequest atualizarTarefaRequest)
        {
            Descricao = atualizarTarefaRequest.Descricao;
            Situacao = atualizarTarefaRequest.Situacao;
        }
    }
}
