using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Produto : Core
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public string Quantidade { get; set; }
        public Guid? ArquivoId { get; set; }

    }
}
