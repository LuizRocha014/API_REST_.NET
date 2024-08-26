using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WEB_REST_PRO.Models.SmartStorege
{
	public class ProdutoArquivo
	{
        public string? Descricao { get; set; }
        public Guid Produto_id { get; set; }
        public Guid Arquivo_id { get; set; }

    }
}


