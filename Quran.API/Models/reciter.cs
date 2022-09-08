using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("reciter")]
    public class reciter
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }
        [Column("name")]
        public string name { get; set; }
       
        [Column("mediaurl")]
        public string mediaurl { get; set; }
    }
}
