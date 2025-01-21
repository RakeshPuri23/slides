using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace slides.Models
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SliderId{get;set;}
        [Required]
        public string SliderName{get;set;}
        [Required]
        public bool Sliderstatus { get;set;}
        [Required]
        public string Filepath { get; set; }
        [NotMapped]
        public HttpFileCollectionBase Files { get; set; }   
    }
}