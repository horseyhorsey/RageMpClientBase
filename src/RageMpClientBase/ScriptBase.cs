using RAGE;
using RageMpClientHelpers;
using RageMpClientShared;

namespace RageMpClientBase
{
    public abstract class ScriptBase : Events.Script
    {
        public string Name { get; private set; }

        public ScriptBase()
        {

        }

        protected virtual void Notify(string message, string title = "Title")
        {
            UiHelper.SendNotification(message);
        }

        /// <summary>
        /// Quick way to send pic notification
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="notifyChar"></param>
        protected virtual void NotifyPic(string message, string title = "Title",  NotifyChar notifyChar = NotifyChar.CHAR_BRYONY)
        {
            UiHelper.SendPicNotification(title, Name, message, notifyChar: notifyChar);
        }
    }
}
