using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryMng.View
{
    public interface ILoginView : IView
    {
        string GetTxtEmail();

        string GetTxtPassword();

        void SetTxtEmail(string txtEmail);

        void SetTxtPassword(string txtPassword);
    }
}
