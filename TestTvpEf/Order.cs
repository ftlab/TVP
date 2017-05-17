namespace TestTvpEf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public double Sum { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Person Person { get; set; }
    }
}
