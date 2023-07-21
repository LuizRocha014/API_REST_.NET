using WEB_REST_PRO.Models.Common;

namespace WEB_REST_PRO.Models
{
    public class Usuario : Core
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
