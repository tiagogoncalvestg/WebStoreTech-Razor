using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Razor.Models
{
    [Table("cliente")]
    public class Client
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("nome", TypeName = "varchar(11)")]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [Column("dataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("cpf", TypeName = "varchar(11)")]
        public string CPF { get; set; }
        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}
