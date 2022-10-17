using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWII2TP02.Models
{
    [Table("BL")]
    public class BL
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Numero")]
        [Column("Numero")]
        public int Numero { get; set; }

        [Display(Name = "Consignee")]
        [Column("Consignee")]
        public string Consignee { get; set; }

        [Display(Name = "Navio")]
        [Column("Navio")]
        public string Navio { get; set; }
    }
}
