using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.Interfaces
{
    public interface INavegation
    {
        void ShowHome();
        void ShowMyProfile();
        void ShowOtherProfile();
        //void ShowSettings();
        void ShowLogin();
        void ShowRegister();
        void ShowNewPostForm();
        void ShowPostForm();
    }
}
