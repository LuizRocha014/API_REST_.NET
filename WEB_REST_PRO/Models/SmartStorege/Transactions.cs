using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WEB_REST_PRO.Models.SmartStorege
{
	public class Transactions : Core
	{
        public Guid ProdutoId { get; set; }
        public Guid EmpresaFilialAtualId { get; set; }
        public Guid EmpresaFilialDestino { get; set; }
        public int Quantidade { get; set; }

        
    }
}

