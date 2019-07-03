using System;

namespace PhotoManager
{
    public interface IRegisterView
    {
        event Action<User> CreateAccountEvent;
        void ShowMessage(bool success, string message);
        void ClearTextBoxes();
    }
}
