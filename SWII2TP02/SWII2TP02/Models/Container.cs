using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SWII2TP02.Models
{
        [Table("Container")]
        public class Container
        {
            [Display(Name = "Código")]
            [Column("Id")]
            public int Id { get; set; }

            [Display(Name = "Numero")]
            [Column("Numero")]
            public int Numero { get; set; }

            [Display(Name = "Tipo")]
            [Column("Tipo")]
            public string Tipo { get; set; }

            [Display(Name = "Tamanho")]
            [Column("Tamanho")]
            public string Tamanho { get; set; }
        }
}
