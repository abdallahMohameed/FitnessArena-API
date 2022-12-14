// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace fitnessApi.Models
{
    [Table("inbody")]
    public partial class inbody
    {
        [Key]

        public int inbodyId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? muscle { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? minerals { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? proteins { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? water { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal weight { get; set; }
        public int? height { get; set; }

        public int traineeId { get; set; }

        [ForeignKey("traineeId")]
        [InverseProperty("inbodies")]
        [JsonIgnore]
        
        public virtual user trainee { get; set; }
    }
}