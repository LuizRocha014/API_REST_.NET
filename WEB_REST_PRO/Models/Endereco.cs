using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Endereco : Core
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
