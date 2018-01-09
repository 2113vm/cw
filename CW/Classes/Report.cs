namespace CW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Report_Id { get; set; }

        public int Serivce_Id { get; set; }

        public int User_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int Meterage { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
