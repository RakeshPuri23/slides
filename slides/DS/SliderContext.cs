using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using slides.Models;

namespace slides.DS
{
    public class SliderContext:DbContext
    {
        public SliderContext() { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Slider>().ToTable("Slider");
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}