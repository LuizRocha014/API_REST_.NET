using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Estoque : Core
    {

        public Guid ProdutoId { get; set; }

        public int Quantidade { get; set; }
    }
}
