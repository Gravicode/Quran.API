using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("bookmark")]
    public class bookmark
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("title")]
        public string title { get; set; }

        [Column("surah")]
        public int surah { get; set; }

        [Column("juz")]
        public int juz { get; set; }

        [Column("ayah")]
        public int ayah { get; set; }

        
    }
}
