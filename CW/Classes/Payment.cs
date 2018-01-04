namespace CW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Payment_Id { get; set; }

        public int User_Id { get; set; }

        public int Service_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
