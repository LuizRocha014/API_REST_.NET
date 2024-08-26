using System;
namespace WEB_REST_PRO.Models.SmartStorege
{
	public class Core
	{
		public Guid Id { get; set; } = Guid.NewGuid();

		public DateTime Inclusao { get; set; }

        public DateTime Alteracao { get; set; }

        public bool Ativo { get; set; }
    }
}

