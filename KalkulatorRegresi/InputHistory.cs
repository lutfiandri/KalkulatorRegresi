namespace KalkulatorRegresi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InputHistory")]
    public partial class InputHistory
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(1024)]
        public string X { get; set; }

        [Required]
        [StringLength(1024)]
        public string Y { get; set; }

        public virtual User User { get; set; }
    }
}
