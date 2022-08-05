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
    [Table("workout")]
    public partial class workout
    {
        public workout()
        {
            programWorkouts = new HashSet<programWorkout>();
        }

        [Key]
        public int workoutId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string name { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string targetMuscle { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string description { get; set; }

        [JsonIgnore]
        [InverseProperty("workout")]
        public virtual workoutMedium workoutMedium { get; set; }
        [InverseProperty("workout")]
        [JsonIgnore]
        public virtual ICollection<programWorkout> programWorkouts { get; set; }
    }
}