using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCEP.Models
{
    [Table("Ends")]
    public class End
    {
        [Key]
        public int EndId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cep { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Logradouro { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Complemento { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Localidade { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Uf { get; set; }
    }
}
