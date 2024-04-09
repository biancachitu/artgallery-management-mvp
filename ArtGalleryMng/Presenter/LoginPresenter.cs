using ArtGalleryMng.Model;
using ArtGalleryMng.Model.Repository;
using ArtGalleryMng.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArtGalleryMng.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private readonly UserRepository userRepository;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            userRepository = new UserRepository();
        }

        public LoginPresenter(ILoginView loginView, UserRepository userRepository)
        {
            this.loginView = loginView;
            this.userRepository = userRepository;
        }
        public void GoToArtworkViewForm()
        {
            ArtworkView artworkView = new ArtworkView();
            artworkView.Show();
            this.loginView.HideForm();
        }

        public void GoToEmployeeViewForm()
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
            this.loginView.HideForm();
        }

        public void GoToAdminViewForm()
        {
            AdminView adminView = new AdminView();
            adminView.Show();
            this.loginView.HideForm();
        }

        public void LoginAttempt_Click()
        {
            string email = loginView.GetTxtEmail();
            string password = loginView.GetTxtPassword();

            if (!(userRepository.IsValidEmail(email)))
            {
                loginView.SetMessage("Error", "Invalid email format...");
                return;
            }

            User user = userRepository.GetUserByEmail(email);
            if(user == null)
            {
                loginView.SetMessage("Error", "User doesn't exist...");
                return;
            }

            if(user.Pass != password)
            {
                loginView.SetMessage("Error", "Invalid password. Try again...");
                return;
            }

            switch (user.AccessType)
            {
                case AccessType.Admin:
                    GoToAdminViewForm();
                    break;
                case AccessType.Employee:
                    GoToEmployeeViewForm();
                    break;
                default:
                    loginView.SetMessage("Error", "Invalid access type...");
                    break;
            }
        }


        public void ResetLoginCredentials()
        {
            loginView.SetTxtEmail("");
            loginView.SetTxtPassword("");
        }
    }
}
