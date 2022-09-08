using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("hizb")]
    public class hizb
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("surahfrom")]
        public int surahfrom { get; set; }

        [Column("ayahfrom")]
        public int ayahfrom { get; set; }

        [Column("surahto")]
        public int surahto { get; set; }

        [Column("ayahto")]
        public int ayahto { get; set; }
    }
}
