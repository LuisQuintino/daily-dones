using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_domain.Messaging.Tarefa
{
    public class UltimasTarefasResponse
    {
        public Entidades.Tarefa Tarefa { get; set; }
        public List<Entidades.Tag> Tags { get; set; }
    }
}
