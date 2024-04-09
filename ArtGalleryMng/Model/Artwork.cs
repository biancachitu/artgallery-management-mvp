using System;

namespace ArtGalleryMng.Model
{
    public enum Type
    {
        Painting = 1,
        Sculpture = 2,
        Photography = 3
    }
    public class Artwork
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year_made { get; set; }
        public Type ArtType { get; set; }

        public int Gallery_id { get; set; }

        public Artwork() { }

        public Artwork(string title, string artist, int year_made, int type, int gallery_id)
        {
            this.Title = title;
            this.Artist = artist;
            this.Year_made = year_made;
            this.ArtType = GetTypeFromId(type);
            this.Gallery_id = gallery_id;
        }

        public Artwork(int id, string title, string artist, int year_made, int type, int gallery_id)
        {
            this.Id = id;
            this.Title = title;
            this.Artist = artist;
            this.Year_made = year_made;
            this.ArtType = GetTypeFromId(type);
            this.Gallery_id = gallery_id;
        }


        public int GetTypeId()
        {
            return (int)ArtType;
        }


        public static Type GetTypeFromId(int typeId)
        {
            switch (typeId)
            {
                case 1:
                    return Type.Painting;
                case 2:
                    return Type.Sculpture;
                case 3:
                    return Type.Photography;
                default:
                    throw new ArgumentException("Invalid Type_id value: " + typeId);
            }
        }

    }
}
