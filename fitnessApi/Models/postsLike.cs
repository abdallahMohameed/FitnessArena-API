﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace fitnessApi.Models
{
    [Table("postsLike")]
    public partial class postsLike
    {
        public int? postId { get; set; }
        public int? userId { get; set; }
        [JsonIgnore]
        [Key]
        public int likeId { get; set; }

        [JsonIgnore]
        [ForeignKey("postId")]
        [InverseProperty("postsLikes")]
        public virtual post post { get; set; }
        [JsonIgnore]
        [ForeignKey("userId")]
        [InverseProperty("postsLikes")]
        public virtual user user { get; set; }
    }
}