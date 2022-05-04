using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryLayer.Models
{
    public partial class TblEmployee
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("phone")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column("designation")]
        [StringLength(50)]
        public string Designation { get; set; }
    }
}
