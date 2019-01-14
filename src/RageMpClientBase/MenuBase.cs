using RAGE;
using RAGE.Game;
using RAGE.NUI;

namespace RageMpClientBase
{
    /// <summary>
    /// Base NativeUI Menu
    /// </summary>
    public abstract class MenuBaseScript : Events.Script
    {
        protected internal readonly MenuPool MenuPool;
        protected internal UIMenu MainMenu;

        public MenuBaseScript()
        {
            MenuPool = new MenuPool();
        }

        /// <summary>
        /// Adds a new item to main menu
        /// </summary>
        /// <param name="menu"></param>
        public void AddToMainMenu(UIMenuItem menu)
        {
            MainMenu.AddItem(menu);
        }

        /// <summary>
        /// Creates a Main Menu and adds to pool. Do it here because cannot set Title, Subtitle outside of Init?
        /// </summary>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
        public void CreateMainMenu(string title, string subtitle, bool createTickEvent = true)
        {
            MainMenu = new UIMenu(title, subtitle);
            MenuPool.Add(MainMenu);

            MainMenu.OnMenuClose += MainMenu_OnMenuClose;

            if (createTickEvent)
                RAGE.Events.Tick += DrawMenu;
        }

        protected virtual void MainMenu_OnMenuClose(UIMenu sender)
        {
            //Chat.Output("MenuBase closing");
        }

        /// <summary>
        /// Gets a new sub menu. Then use submenu add item.
        /// </summary>
        /// <param name="parentMenu"></param>
        /// <param name="text"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public UIMenu AddSubMenu(UIMenu parentMenu, string text, string desc)
        {
            return MenuPool.AddSubMenu(parentMenu, text, desc);
        }

        /// <summary>
        /// Draws menu to screen, if its open. Listens for <see cref="Control.InteractionMenu"/> which is M on keyboard. Toggles chat.
        /// </summary>
        /// <param name="nametags"></param>
        protected virtual void DrawMenu(System.Collections.Generic.List<RAGE.Events.TickNametagData> nametags)
        {
            //Activate the menu
            if (Pad.IsControlJustPressed(0, (int)Control.InteractionMenu))
            {
                if (!MenuPool.IsAnyMenuOpen())
                {
                    MainMenu.Visible = true;
                }
            }

            //Draw if visible
            if (MenuPool.IsAnyMenuOpen())
                MenuPool.ProcessMenus();
        }

        /// <summary>
        /// Refreshes the Menu pool index
        /// </summary>
        public void RefreshIndex()
        {
            MenuPool.RefreshIndex();
        }
    }
}