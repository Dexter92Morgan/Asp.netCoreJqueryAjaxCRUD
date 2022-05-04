using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryLayer.Models
{
    public partial class TblDesgnation
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
