using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wp11_movieFinder.Models
{
    internal class MovieItem
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Release_date { get; set; }
        public double Vote_average { get; set; }
        public string Original_Title { get; set; }
        public string Original_Language { get; set; }
        public bool Adult { get; set; }
        public string OverView { get; set; }
        public double Popularity { get; set; }
        public string Poster_path { get; set; }


    }
}
