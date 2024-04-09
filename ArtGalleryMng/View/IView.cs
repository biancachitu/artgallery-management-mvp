using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryMng.View
{
    public interface IView
    {
        void SetMessage(string title, string message);
        void HideForm();
    }
}
