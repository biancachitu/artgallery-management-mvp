using ArtGalleryMng.Presenter;
using System;
using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    public partial class AdminView : ArtworkView, IAdminView
    {
        AdminPresenter adminPresenter;

        public AdminView()
        {
            InitializeComponent();
            adminPresenter = new AdminPresenter(this);

            this.dataGridView1.AutoSize = true;
            Load += Userview_Load;
            AddBtn.Click += AddBtn_Click;
            DeleteBtn.Click += DeleteBtn_Click;
            EditBtn.Click += EditBtn_Click;
            SaveBtn.Click += SaveBtn_Click;
        }

        public void ResetDgvUsers()
        {
            dataGridView1.Rows.Clear();
        }

        public void AddRowDgv(DataGridViewRow row)
        {
            dataGridView1.Rows.Add(row);
        }

        public void Userview_Load(object sender, EventArgs e)
        {
            adminPresenter.LoadUsers();
        }

        //getters and setters

        public string GetFullName()
        {
            return this.TxtFullName.Text;
        }

        public void SetFullName(string fullName)
        {
            this.TxtFullName.Text = fullName;
        }

        public string GetEmail()
        {
            return this.TxtEmail.Text;
        }

        public void SetEmail(string email)
        {
            this.TxtEmail.Text = email;
        }

        public string GetPassword()
        {
            return this.TxtPassword.Text;
        }

        public void SetPassword(string password) 
        { 
            this.TxtPassword.Text = password;
        }

        public int GetAccessId()
        {
            return (int)this.NudAccessId.Value;
        }

        public void SetAccessId(int accessId)
        {
            this.NudAccessId.Value = accessId;
        }

        public DataGridViewRow GetSelectedUserRow()
        {
            return dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;
        }

        public void ToggleEditSaveBtns(bool editmode)
        {
            this.EditBtn.Visible = !editmode;
            this.SaveBtn.Visible = editmode;
        }

        //button events

        public void AddBtn_Click(object sender, EventArgs e)
        {
            adminPresenter.AddUser();
        }

        public void DeleteBtn_Click(object sender, EventArgs e)
        {
            adminPresenter.DeleteUser();
        }

        public void EditBtn_Click(object sender, EventArgs e)
        {
            adminPresenter.EditUser();
        }

        public void SaveBtn_Click(object sender, EventArgs e)
        {
            adminPresenter.SaveUser();
        }
    }
}
