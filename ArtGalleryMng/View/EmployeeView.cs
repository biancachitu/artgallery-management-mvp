using ArtGalleryMng.Model;
using ArtGalleryMng.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    public partial class EmployeeView : ArtworkView, IEmployeeView
    {
        private EmployeePresenter employeePresenter;

        public EmployeeView()
        {
            InitializeComponent();
            employeePresenter = new EmployeePresenter(this);
            
            Load += ArtworkView_Load;
            AddBtn.Click += AddBtn_Click;
            RemoveBtn.Click += DeleteButton_Click;
            EditBtn.Click += EditBtn_Click;
            SaveBtn.Click += SaveBtn_Click;
        }

        //getters and setters
        public DataGridViewRow GetSelectedRow_AV()
        {
            return GetSelectedRow();
        }

        public string GetArtworkTitle()
        {
            return txtTitle.Text;
        }
       
        public void SetArtworkTitle(string title)
        {
            this.txtTitle.Text = title;
        }

        public string GetArtistName()
        {
            return txtArtist.Text;
        }

        public void SetArtistName(string name)
        {
            this.txtArtist.Text = name;
        }

        public int GetYearMade()
        {
            return (int)this.NudYear.Value;
        }

        public void SetYearMade(int yearMade)
        {
            this.NudYear.Value = yearMade;
        }

        public int GetArtType()
        {
            return (int)this.NudType.Value;
        }

        public void SetArtType(int type)
        {
            this.NudType.Value = type;
        }

        public int GetGalleryId()
        {

            return (int)this.NudGallery.Value;
        }

        public void SetGalleryId(int galleryId) 
        {
            this.NudGallery.Value = galleryId;
        }


        public void ToggleEditSaveBtns(bool editmode)
        {
            this.EditBtn.Visible = !editmode;
            this.SaveBtn.Visible = editmode;
        }

        //button events
        public void AddBtn_Click(object sender, EventArgs e)
        {
            employeePresenter.AddArtwork();
            ArtworkView_Load(sender, e);
        }

        public void EditBtn_Click(object sender, EventArgs e)
        {
            employeePresenter.EditArtwork();
            
        }

        public void  SaveBtn_Click(object sender, EventArgs e)
        {
            employeePresenter.SaveArtwork();
            ArtworkView_Load(sender, e);
        }
    }
}
