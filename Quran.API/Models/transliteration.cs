using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("transliteration")]
    public class transliteration
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("surahidx")]
        public int surahidx { get; set; }

        [Column("ayahidx")]
        public int ayahidx { get; set; }

        [Column("langid")]
        public int langid { get; set; }

        [Column("content")]
        public string content { get; set; }
    }
}
