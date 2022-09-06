using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Razor.Models
{
    [Table("admin")]
    public class Admin
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("senha", TypeName = "varchar(50)")]
        public string Senha { get; set; }
        public Admin()
        {
            Id = !string.IsNullOrEmpty(Id) ? Id : Guid.NewGuid().ToString();
        }
    }
}
