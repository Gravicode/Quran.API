using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("manzil")]
    public class manzil
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("surahfrom")]
        public int surahfrom { get; set; }

        [Column("surahto")]
        public int surahto { get; set; }
    }
}
