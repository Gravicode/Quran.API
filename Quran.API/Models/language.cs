using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("language")]
    public class language
    {
        [Key]

        [Column("langid")]
        public int langid { get; set; }

        [Column("lang")]
        public string lang { get; set; }

        [Column("dir")]
        public string dir { get; set; }
    }
}
