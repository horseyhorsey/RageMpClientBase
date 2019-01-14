using RAGE;

namespace RageMpClientHelpers
{
    public static class ChatHelper
    {
        /// <summary>
        /// Shows and Activates the chat.
        /// </summary>
        /// <param name="chat"></param>
        /// <param name="enable"></param>
        /// <param name="activate"></param>
        public static void EnableChat(bool enable, bool activate= false)
        {
            Chat.Activate(activate);
            Chat.Show(enable);
        }
    }
}
