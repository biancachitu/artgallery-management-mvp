using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtGalleryMng.Model;
using ArtGalleryMng.Model.Repository;
using ArtGalleryMng.Presenter;
using ArtGalleryMng.View;

namespace ArtGalleryMng
{
    public partial class ArtworkView : Form, IArtworkView
    {
        private ArtworkPresenter artworkPresenter;

        public ArtworkView()
        {
            InitializeComponent();
            artworkPresenter = new ArtworkPresenter(this);
            Load += ArtworkView_Load;

            this.dgvArtworksList.AutoSize = true;
            txtArtistFilter.KeyUp += ApplyFilter;
            cmbFilterType.SelectedIndexChanged += ApplyFilter;
            btnResetFilters.Click += BtnResetFilters_Click;
            cmbPickGallery.SelectedIndexChanged += GalleryPicker_SIG;
            btnBack.Click += BackBtn_Click;
        }

        public void ResetDgvArtworksList()
        {
            dgvArtworksList.Rows.Clear();
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            artworkPresenter.DeleteArtwork();
        }

        public void ArtworkView_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("ArtworkView loaded.");

            artworkPresenter.LoadArtworks();

            artworkPresenter.LoadGalleryNames();
        }

        public void AddRowDgvList(DataGridViewRow row)
        {
            dgvArtworksList.Rows.Add(row);
        }

        public List<DataGridViewRow> GetDgvArtworksList()
        {
            return new List<DataGridViewRow>(dgvArtworksList.Rows.Cast<DataGridViewRow>());
        }

        public DataGridViewRow GetSelectedRow()
        {
            return dgvArtworksList.SelectedRows.Count > 0 ? dgvArtworksList.SelectedRows[0] : null;
        }

        public void SetDataGridView(List<Artwork> artworks)
        {
            dgvArtworksList.Rows.Clear();

            foreach (var artwork in artworks)
            {
                dgvArtworksList.Rows.Add(artwork.Id, artwork.Title, artwork.Artist, artwork.Year_made, artwork.ArtType);
            }
        }

        public void BtnResetFilters_Click(object sender, EventArgs e)
        {
            ResetDgvArtworksList();
            artworkPresenter.BtnResetFilters();
        }

        public string GetTxtArtist()
        {
            if(txtArtistFilter.Text != null)
            {
                return this.txtArtistFilter.Text;
            }
            return string.Empty;
        }

        public void SetTxtArtist(string txtArtist)
        {
            this.txtArtistFilter.Text = txtArtist;
        }

        public int GetCmbType()
        {
            return this.cmbFilterType.SelectedIndex;
        }

        public void SetCmbType(int typeID)
        {
            this.cmbFilterType.SelectedIndex = typeID;
        }


        public ComboBox GetCmbGallery()
        {
            return cmbPickGallery; 
        }

        public void GalleryPicker_SIG(object sender, EventArgs e)
        {
            artworkPresenter.HandleGallerySelectionChange();
        }

        public void ApplyFilter(object sender, EventArgs e)
        {
            artworkPresenter.ApplyFilter();
        }

        public void BackBtn_Click(object sender, EventArgs e)
        {
            artworkPresenter.ReturnToLoginForm();
        }

    }
}
