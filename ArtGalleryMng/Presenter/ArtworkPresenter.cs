using ArtGalleryMng.Model;
using ArtGalleryMng.Model.Repository;
using ArtGalleryMng.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace ArtGalleryMng.Presenter
{
    public class ArtworkPresenter
    {
        private IArtworkView artworkView;
        private IArtworkRepository artworkRepository;

        public ArtworkPresenter(IArtworkView artworkView)
        {
            this.artworkView = artworkView;
            this.artworkRepository = new ArtworkRepository();
        }

        public void LoadArtworks()
        {
            artworkView.ResetDgvArtworksList();
            int galleryId = GetSelectedGalleryId();
            DataTable table = artworkRepository.ArtworkTable(galleryId);
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    Model.Type type = Artwork.GetTypeFromId((int)row["Type_id"]);
                    artworkView.AddRowDgvList(new DataGridViewRow
                    {
                       Cells =
                       {
                            new DataGridViewTextBoxCell { Value = row["Id"] },
                            new DataGridViewTextBoxCell { Value = row["Title"] },
                            new DataGridViewTextBoxCell { Value = row["Artist"] },
                            new DataGridViewTextBoxCell { Value = row["Year_made"] },
                            new DataGridViewTextBoxCell { Value = type.ToString() }
                        }
                    });
                    
                }
            }
        }

        public void FilterByArtist(string artist, int galleryId)
        {
            if (string.IsNullOrWhiteSpace(artist))
            {
                artworkView.ResetDgvArtworksList();
                LoadArtworks();
                return;
            }

            List<Artwork> filtered = artworkRepository.GetArtworksByArtist(artist, galleryId);
            artworkView.SetDataGridView(filtered);
        }

        public void FilterByType(int type, int galleryId)
        {
            if (type < 0)
            {
                artworkView.ResetDgvArtworksList();
                LoadArtworks();
                return;
            }

            List<Artwork> filtered = artworkRepository.GetArtworksByType(type + 1, galleryId);
            artworkView.SetDataGridView(filtered);

        }

        public void BtnResetFilters()
        {
            artworkView.SetTxtArtist("");
            artworkView.SetCmbType(-1);
            int galleryId = artworkRepository.GetGalleryIdFromName(GetSelectedGalleryName());
            LoadArtworks();

        }

        public void LoadGalleryNames()
        {
            List<string> names = artworkRepository.GetGalleryNames();
            if (names != null)
            {
                SetGalleryNames(names);
            }
        }

        public void SetGalleryNames(List<string> galleryNames)
        {
            ComboBox comboBox = artworkView.GetCmbGallery() as ComboBox;
            if (comboBox != null)
            {
                comboBox.Items.Clear();
                comboBox.Items.AddRange(galleryNames.ToArray());
            }
        }

        public string GetSelectedGalleryName()
        {
            return artworkView.GetCmbGallery()?.SelectedItem?.ToString() ?? string.Empty;
        }

        public int GetSelectedGalleryId()
        {
            int id = 0;
            string selectedName = GetSelectedGalleryName();

            if(!string.IsNullOrEmpty(selectedName))
            {
                id = artworkRepository.GetGalleryIdFromName(selectedName);
            }
            return id;
        }

        public void HandleGallerySelectionChange()
        {
            string selectedGallery = GetSelectedGalleryName();
            if (!string.IsNullOrEmpty(selectedGallery))
            {
               artworkView.ResetDgvArtworksList();

               LoadArtworks();
            }
        }

        public void ApplyFilter()
        {
            int selectedGalleryId = GetSelectedGalleryId();
            if (selectedGalleryId == 0)
            {
                return;
            }

            int typeFilter = artworkView.GetCmbType();
            string artistFilter = artworkView.GetTxtArtist();

            if (typeFilter >= 0)
            {
                artworkView.ResetDgvArtworksList();
                FilterByType(typeFilter, selectedGalleryId);
            }
            else if (!string.IsNullOrEmpty(artistFilter))
            {
                artworkView.ResetDgvArtworksList();
                FilterByArtist(artistFilter, selectedGalleryId);
            }
            else
            {
                artworkView.ResetDgvArtworksList();
                LoadArtworks();
            }
        }

        public void DeleteArtwork()
        {
            DataGridViewRow selectedRow = artworkView.GetSelectedRow(); 
            if (selectedRow == null)
            {
                artworkView.SetMessage("Error", "Please select an artwork to delete.");
                return;
            }

            int artworkId = (int)selectedRow.Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this artwork?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                try
                {
                    if (artworkRepository.DeleteArtwork(artworkId))
                    {
                        artworkView.ResetDgvArtworksList();
                        LoadArtworks();
                        artworkView.SetMessage("Success", "Artwork deleted successfully.");
                    }
                    else
                    {
                        artworkView.SetMessage("Error", "An error occurred during deletion.");
                    }
                }
                catch (Exception ex)
                {
                    artworkView.SetMessage("Error", "An error occurred: " + ex.Message);
                }
            } 
        }

        public void ReturnToLoginForm()
        {
            LoginView loginForm = new LoginView();
            loginForm.ResetCredentials();
            loginForm.Show();
            this.artworkView.HideForm();
        }
    }
}
