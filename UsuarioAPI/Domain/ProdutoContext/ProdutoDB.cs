using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuario.Domain.ProdutoContext
{
    [Table("Tab_Produtos")]
    public partial class ProdutoDB
    {
        public ProdutoDB()
        {

        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("DESCRICAO")]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [Required]
        [Column("VALOR")]
        public decimal Valor { get; set; }

        [Required]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

    }
}
