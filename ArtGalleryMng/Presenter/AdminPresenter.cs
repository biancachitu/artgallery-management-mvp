using ArtGalleryMng.Model.Repository;
using ArtGalleryMng.Model;
using ArtGalleryMng.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ArtGalleryMng.Presenter
{
    public class AdminPresenter
    {
        private readonly IAdminView adminView;
        private UserRepository userRepository;

        public AdminPresenter(IAdminView adminView)
        {
            this.adminView = adminView;
            userRepository = new UserRepository();
        }

        public void LoadUsers()
        {
            adminView.ResetDgvUsers();
            DataTable table = userRepository.UserTable();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    AccessType accessType = User.GetAccessTypeFromId((int)row["AccessTypeId"]);
                    adminView.AddRowDgv(new DataGridViewRow
                    {
                        Cells =
                       {
                            new DataGridViewTextBoxCell { Value = row["Id"] },
                            new DataGridViewTextBoxCell { Value = row["FullName"] },
                            new DataGridViewTextBoxCell { Value = row["Email"] },
                            new DataGridViewTextBoxCell { Value = row["Pass"] },
                            new DataGridViewTextBoxCell { Value = accessType.ToString() }
                        }
                    });

                }
            }
        }

        public void AddUser()
        {
            try
            {
                User user = ValidateInfo();
                if (user == null) return;

                bool success = userRepository.InsertUser(user);
                if (success)
                {
                    adminView.SetMessage("Success", "User added successfully!");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                adminView.SetMessage("Error", "An error occurred: " + ex.Message);
            }
        }

        public void DeleteUser()
        {
            DataGridViewRow selectedRow = adminView.GetSelectedUserRow();
            if (selectedRow == null)
            {
                adminView.SetMessage("Error", "Please select an user to delete.");
                return;
            }

            int userId = (int)selectedRow.Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (userRepository.DeleteUser(userId))
                    {
                        adminView.ResetDgvUsers();
                        LoadUsers();
                        adminView.SetMessage("Success", "User deleted successfully.");
                    }
                    else
                    {
                        adminView.SetMessage("Error", "An error occurred during deletion.");
                    }
                }
                catch (Exception ex)
                {
                    adminView.SetMessage("Error", "An error occurred: " + ex.Message);
                }
            }
        }

        public void EditUser()
        {
            DataGridViewRow selectedRow = adminView.GetSelectedUserRow();
            if (selectedRow == null)
            {
                adminView.SetMessage("Error", "Please select an user to edit.");
                return;
            }

            try
            {
                int id = (int)selectedRow.Cells["Id"].Value;
                User user = userRepository.GetUserById(id);

                adminView.SetFullName(user.FullName);
                adminView.SetEmail(user.Email);
                adminView.SetPassword(user.Pass);
                adminView.SetAccessId(user.GetAccessTypeId());
                adminView.ToggleEditSaveBtns(true);
            }
            catch (Exception ex)
            {
                adminView.SetMessage("Error", "An error occurred: " + ex.Message);
            }
        }

        public void SaveUser()
        {
            try
            {
                User user = ValidateUpdate();
                if (user == null) return;

                bool success = userRepository.UpdateUser(user);
                if (success)
                {
                    adminView.SetMessage("Success", "User updated successfully!");
                    adminView.ToggleEditSaveBtns(false);
                    ResetAddUpdateForm();
                    LoadUsers();
                }
                else
                {
                    adminView.SetMessage("Failure", "User failed to get updated!");
                }
            }
            catch (Exception ex)
            {
                adminView.SetMessage("Error", "An error occurred: " + ex.Message);
            }
        }

        public void ResetAddUpdateForm()
        {
            adminView.SetFullName("");
            adminView.SetEmail("");
            adminView.SetPassword("");
            adminView.SetAccessId(1);
        }

        public User ValidateUpdate()
        {
            int id = (int)adminView.GetSelectedUserRow().Cells["Id"].Value;
            string name = adminView.GetFullName();
            if (string.IsNullOrEmpty(name))
            {
                adminView.SetMessage("Incomplete information", "Name field cannot be empty.");
                return null;
            }

            string email = adminView.GetEmail();
            if (string.IsNullOrEmpty(email)) 
            {
                adminView.SetMessage("Incomplete information", "Email field cannot be empty.");
                return null;
            }
            if (!userRepository.IsValidEmail(email))
            {
                adminView.SetMessage("Incomplete information", "Invalid email format.");
                return null;
            }

            string password = adminView.GetPassword();
            if (string.IsNullOrEmpty(password))
            {
                adminView.SetMessage("Incomplete information", "Password field cannot be empty.");
                return null;
            }

            int accessId = adminView.GetAccessId();


            return new User(id, name, email, password, accessId);
        }

        private User ValidateInfo()
        {
            string fullName = adminView.GetFullName();
            if (string.IsNullOrEmpty(fullName))
            {
                adminView.SetMessage("Incomplete information", "Name field cannot be empty.");
                return null;
            }

            string email = adminView.GetEmail();
            if (string.IsNullOrEmpty(email))
            {
                adminView.SetMessage("Incomplete information", "Email field cannot be empty.");
                return null;
            }

            string password = adminView.GetPassword();
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                adminView.SetMessage("Incomplete information", "Password field cannot be empty or shorter than 5 characters.");
                return null;
            }

            int accessId = adminView.GetAccessId();

            return new User(fullName, email, password, accessId);
        }
    }
}
