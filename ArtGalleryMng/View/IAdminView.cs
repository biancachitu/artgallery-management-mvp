using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    public interface IAdminView : IView
    {

        void ResetDgvUsers();

        void AddRowDgv(DataGridViewRow row);

        DataGridViewRow GetSelectedUserRow();

        void ToggleEditSaveBtns(bool editmode);

        string GetFullName();

        void SetFullName(string fullName);

        string GetEmail();

        void SetEmail(string email);

        string GetPassword();

        void SetPassword(string password);

        int GetAccessId();

        void SetAccessId(int accessId);

    }
}
