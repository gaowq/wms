using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wms.Entities
{
    [Table("classify")]
    public class Classify
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string Name { get; set; }

    }
}
