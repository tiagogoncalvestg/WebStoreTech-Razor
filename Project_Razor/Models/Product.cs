using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Razor.Models
{
    [Table("produto")]
    public class Product
    {
        [Column("id", TypeName = "varchar(50)")]
        public string Id { get; set; }
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        [Column("descricao", TypeName = "varchar(50)")]
        public string Descricao { get; set; }
        [Display(Name = "Preço")]
        [Column("preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [Column("estoque")]
        public int Estoque { get; set; }
        [Display(Name = "Nome da Imagem")]
        [Column("imageName", TypeName = "varchar(50)")]
        public string ImageName { get; set; }

        public Product()
        {
            Id = !string.IsNullOrEmpty(Id) ? Id : Guid.NewGuid().ToString();
        }

    }
}
