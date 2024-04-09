using ArtGalleryMng.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ArtGalleryMng.View
{
    public interface IEmployeeView : IView
    {
        void ResetDgvArtworksList();

        DataGridViewRow GetSelectedRow_AV();
        void ArtworkView_Load(object sender, EventArgs e);

        void ToggleEditSaveBtns(bool editmode);

        string GetTxtArtist();

        void SetTxtArtist(string artist);
  
        string GetArtworkTitle();

        void SetArtworkTitle(string title);

        string GetArtistName();

        void SetArtistName(string artistName);

        int GetYearMade();

        void SetYearMade(int yearMade);

        int GetArtType();

        void SetArtType(int artType);

        int GetGalleryId();

        void SetGalleryId(int galleryId);
    }
}
    

