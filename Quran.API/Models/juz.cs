using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("juz")]
    public class juz
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("arabic")]
        public string arabic { get; set; }
        
        [Column("name")]
        public string name { get; set; }

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
