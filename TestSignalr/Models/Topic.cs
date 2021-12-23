namespace TestSignalr.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Top_Id { get; set; }

        [StringLength(50)]
        public string Top_Name { get; set; }
    }
}
