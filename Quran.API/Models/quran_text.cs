using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("quran_text")]
    public class quran_text
    {
        [Key]

        [Column("index")]
        public int index { get; set; }
        [Column("sura")]
        public int sura { get; set; }
        [Column("aya")]
        public int aya { get; set; }
        [Column("text")]
        public string text { get; set; }
    }
}
