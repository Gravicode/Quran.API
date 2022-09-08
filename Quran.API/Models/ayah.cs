using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table("ayah")]
    public class ayah
    {
        [Key]
        [Column( "idx")]
        public int idx { get; set; }

        [Column( "arabic")]
        public string arabic { get; set; }
    }
}
