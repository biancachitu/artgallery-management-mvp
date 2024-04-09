using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtGalleryMng.Model;

namespace ArtGalleryMng.View
{
    public interface IArtworkView : IView
    {
        
        void ResetDgvArtworksList();

        List<DataGridViewRow> GetDgvArtworksList();

        DataGridViewRow GetSelectedRow();

        void SetDataGridView(List<Artwork> artworks);

        void AddRowDgvList(DataGridViewRow row);

        string GetTxtArtist();

        void SetTxtArtist(string artist);

        int GetCmbType();

        void SetCmbType(int typeID);

        ComboBox GetCmbGallery();

        void DeleteButton_Click(object sender, EventArgs e);

    }
}
