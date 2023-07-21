using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Cliente : Core
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int TelefoneResponsavel { get; set; }
        public string TelefoneResponsavel2 { get; set; }
        public Guid? EnderecoId { get; set; }

    }
}
