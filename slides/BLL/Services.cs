using slides.DS;
using slides.Models;
using System.Collections.Generic;
using System.Linq;

namespace slides.BLL
{
    public class Services
    {
        private readonly SliderContext ds = new SliderContext();

        // Method to get the list of sliders
        public List<Slider> GetSliders()
        {
            return ds.Sliders.ToList();
        }
    }
}
