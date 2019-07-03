using System;

namespace PhotoManager
{
    public interface IView
	{
        event Action<User> LoggingEvent;
        IRegisterView IVievRegister { get; }
        IMainViev IVievForm { get; }
        void ClearTextBoxes();
        void hideLoggingWindow();
        void ShowMessage(bool success, string message);
    }
}
