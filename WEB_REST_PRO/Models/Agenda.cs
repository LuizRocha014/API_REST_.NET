using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Agenda : Core
    {
        public Guid? MidiaId { get; set; }
       
        public Guid? ClienteId { get; set; }

        public string Observacao { get; set; }
       
        public Guid AgendaCategoriaId { get; set; }

        public DateTime Data { get; set; }

        public DateTime Horario { get; set; }
    }
}
