using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNetV2.Data
{
    [Table("Clientes")]
    public class DataClient : Interfaces.Cliente
    {
        [Key]
        [Column(TypeName = "int")]
        public int ClienteId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int Edad { get; set; }

        public DataClient()
        {
            ClienteId = 0;
            Edad = 0;
            Name = string.Empty;
        }
    }
}