using ArtGalleryMng.Model;
using ArtGalleryMng.Model.Repository;
using ArtGalleryMng.View;
using System;
using System.Windows.Forms;

namespace ArtGalleryMng.Presenter
{
    public class EmployeePresenter
    {
        private IEmployeeView employeeView;
        private IArtworkRepository artworkRepository;

        public EmployeePresenter(IEmployeeView employeeView)
        {
            this.employeeView = employeeView;
            artworkRepository = new ArtworkRepository();
        }

        public void AddArtwork()
        {
            try
            {
                Artwork artwork = ValidateInfo();
                if (artwork == null) return;
 
                bool success = artworkRepository.InsertArtwork(artwork);
                if (success)
                {
                    employeeView.SetMessage("Success", "Artwork added successfully!");
                }
            }
            catch (Exception ex)
            {
                employeeView.SetMessage("Error","An error occurred: " + ex.Message);
            }
        }

        public void EditArtwork()
        {
            DataGridViewRow selectedRow = employeeView.GetSelectedRow_AV();
            if (selectedRow == null)
            {
                employeeView.SetMessage("Error", "Please select an artwork to edit.");
                return;
            }

            try
            { 
                int artworkId = (int)selectedRow.Cells["Id"].Value;
                Artwork artwork = artworkRepository.GetArtworkById(artworkId);

                employeeView.SetArtworkTitle(artwork.Title);
                employeeView.SetArtistName(artwork.Artist);
                employeeView.SetYearMade(artwork.Year_made);
                employeeView.SetArtType(artwork.GetTypeId());
                employeeView.SetGalleryId(artwork.Gallery_id);
                employeeView.ToggleEditSaveBtns(true);
            }
            catch (Exception ex)
            {
                employeeView.SetMessage("Error", "An error occurred: " + ex.Message);
            }
        }

        public void SaveArtwork()
        {
            try
            {
                Artwork artwork = ValidateUpdate();
                if (artwork == null) return;

                bool success = artworkRepository.UpdateArtwork(artwork);
                if(success)
                {
                    employeeView.SetMessage("Success", "Artwork updated successfully!");
                    employeeView.ToggleEditSaveBtns(false);
                    this.ResetAddUpdateForm();
                }
                else
                {
                    employeeView.SetMessage("Failure", "Artwork failed to get updated!");
                }
            }
            catch (Exception ex )
            {
                employeeView.SetMessage("Error", "An error occurred: " + ex.Message);
            }
        }

        public Artwork ValidateUpdate()
        {
            DataGridViewRow selectedRow = employeeView.GetSelectedRow_AV();
            if (selectedRow == null)
            {
                employeeView.SetMessage("Incomplete information", "No artwork selected.");
                return null;
            }
            int id = (int)selectedRow.Cells["Id"].Value;
            string title = employeeView.GetArtworkTitle();
            if (string.IsNullOrEmpty(title))
            {
                employeeView.SetMessage("Incomplete information", "Title field cannot be empty.");
                return null;
            }

            string artist = employeeView.GetArtistName();
            if (string.IsNullOrEmpty(artist))
            {
                employeeView.SetMessage("Incomplete information", "Artist field cannot be empty.");
                return null;
            }
            int year = employeeView.GetYearMade();
            if (year < 0 ||  year > 2024)
            {
                employeeView.SetMessage("Incomplete information", "Year field cannot be empty or cannot exceed 4 digits.");
                return null;
            }
            int typeId = employeeView.GetArtType();
            int galleryId = employeeView.GetGalleryId();

            if (!artworkRepository.DoesGalleryExist(galleryId))
            {
                employeeView.SetMessage("Incomplete information", "Gallery ID does not exist.");
                return null;
            }

            return new Artwork(id, title, artist, year, typeId, galleryId);
        }

        private Artwork ValidateInfo()
        {
            string title = employeeView.GetArtworkTitle();
            if (string.IsNullOrEmpty(title))
            {
                employeeView.SetMessage("Incomplete information", "Title field cannot be empty.");
                return null;
            }

            string artist = employeeView.GetArtistName();
            if (string.IsNullOrEmpty(artist))
            {
                employeeView.SetMessage("Incomplete information", "Artist field cannot be empty.");
                return null;
            }
            int year = employeeView.GetYearMade();
            if (year > 2024)
            {
                employeeView.SetMessage("Incomplete information", "Year field cannot be empty or cannot exceed 4 digits.");
                return null;
            }
            int typeId = employeeView.GetArtType();
            int galleryId= employeeView.GetGalleryId();
            if (!artworkRepository.DoesGalleryExist(galleryId))
            {
                employeeView.SetMessage("Incomplete information", "Gallery ID does not exist.");
                return null;
            }

            if (artworkRepository.DoesArtworkExist(title, galleryId))
            {
                employeeView.SetMessage("Duplicate artwork", "An artwork with the same title already exists in this gallery.");
                return null;
            }

            return new Artwork(title, artist, year, typeId, galleryId);
        }

        public void ResetAddUpdateForm()
        {
            employeeView.SetArtworkTitle("");
            employeeView.SetArtistName("");
            employeeView.SetYearMade(0);
            employeeView.SetArtType(1);
            employeeView.SetGalleryId(1);
        }

    }
}
