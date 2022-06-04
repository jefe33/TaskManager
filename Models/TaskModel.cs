﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }

        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Pole nazwa jest wymagane!")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayName("Opis")]
        [MaxLength(200)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
