using ArtGalleryMng.Presenter;
using System;
using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    public partial class LoginView : Form, ILoginView
    {
        LoginPresenter loginPresenter;

        public LoginView()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
            loginBtn.Click += LoginAttempt_Click;
            viewArtBtn.Click += ViewArtworks_Click;
        }

        private void LoginAttempt_Click(object sender, EventArgs e)
        {  
            loginPresenter.LoginAttempt_Click();
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void ViewArtworks_Click(object sender, EventArgs e)
        {
            loginPresenter.GoToArtworkViewForm();
        }

        public string GetTxtEmail()
        {
            return this.txtEmail.Text;
        }

        public string GetTxtPassword()
        {
            return this.txtPassword.Text;
        }

        public void SetTxtEmail(string email)
        {
            this.txtEmail.Text = email;
        }

        public void SetTxtPassword(string password)
        {
            this.txtPassword.Text = password;
        }

        public void ResetCredentials()
        {
            this.loginPresenter.ResetLoginCredentials();
        }

    }
}
