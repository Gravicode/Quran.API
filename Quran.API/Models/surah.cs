using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("surah")]
    public class surah
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("totalayah")]
        public int totalayah { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("latin")]
        public string latin { get; set; }

        [Column("place")]
        public string place { get; set; }
    }
}
