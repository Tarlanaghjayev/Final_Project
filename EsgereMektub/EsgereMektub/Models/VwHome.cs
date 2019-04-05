using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsgereMektub.Models
{
    public class VwHome
    {
        public Setting Setting { get; set; }
        public List<Slider> Slider { get; set; }
        public Counter Counter { get; set; }
        public Contact Contact { get; set; }
        public About About { get; set; }
        public List<Letters> Letters { get; set; }
        public List<FightMemory> FightMemory { get; set; }
        public FMtext FMtext { get; set; }
    }
}