using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryMng.Model
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public Gallery() { }

        public Gallery(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
