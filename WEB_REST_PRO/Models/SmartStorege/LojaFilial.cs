using System;
namespace WEB_REST_PRO.Models.SmartStorege
{
	public class LojaFilial : Core
	{
		public string? Localidade { get; set; }	
		public string Nome { get; set; }
		public Guid EmpresaId { get; set; }

	}
}

