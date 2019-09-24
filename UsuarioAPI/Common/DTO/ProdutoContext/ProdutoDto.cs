using System;
using System.Collections.Generic;
using System.Text;

namespace Usuario.Common.DTO.ProdutoContext
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int IdUsuario { get; set; }
    }
}
