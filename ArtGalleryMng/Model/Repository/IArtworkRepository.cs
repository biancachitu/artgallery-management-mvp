using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryMng.Model.Repository
{
    public interface IArtworkRepository
    {
        DataTable ArtworkTable(int galleryId);

        bool InsertArtwork(Artwork artwork);

        bool UpdateArtwork(Artwork artwork);

        bool DeleteArtwork(int artworkId);

        Artwork GetArtworkById(int id);

        List<Artwork> GetArtworksByArtist(string artist, int galleryId);

        List<Artwork> GetArtworksByType(int typeId, int galleryId);

        bool DoesArtworkExist(string title, int galleryId);

        bool DoesGalleryExist(int galleryId);

        int GetGalleryIdFromName(string galleryName);

        List<string> GetGalleryNames();
    }
}
