using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleCall.Menu.MenuItem;

namespace ConsoleCall.Menu
{
    public class MenuItem
    {
        public delegate void Function();
        private event Function? Action;

        public string MenuText { get; private set; }
        public MenuItem? MenuItemParent { get; private set; }
        public List<MenuItem> MenuItemChildren { get; private set; } = new List<MenuItem>();

        public MenuItem(string menuText, MenuItem? consoleMenuParent = null, Function? action = null)
        {
            MenuText = menuText;
            Action = action;
            MenuItemParent = consoleMenuParent;
        }

        public MenuItem AddMenuItemChild(MenuItem newMenuItem)
        {
            newMenuItem.MenuItemParent = this;
            MenuItemChildren.Add(newMenuItem);
            return newMenuItem;
        }

        public void TriggerAction()
        {
            Action?.Invoke();
        }
    }

    public class ConsoleMenu
    {
        public MenuItem TargettMenuItem { get; private set; }

        public ConsoleMenu(MenuItem menuItem)
        {
            TargettMenuItem = menuItem;
        }

        public void Start()
        {
            WriteMenu();

            var targetMenuItemIndex = GetSelectedMenuNumber();

            if (targetMenuItemIndex == 0 && TargettMenuItem.MenuItemParent == null)
                Process.GetCurrentProcess().Kill();

            TargettMenuItem = GetTargetMenuItemByIndex(targetMenuItemIndex);

            TargettMenuItem.TriggerAction(); ;
            if (TargettMenuItem.MenuItemChildren.Count == 0)
                TargettMenuItem = TargettMenuItem.MenuItemParent;
        }

        private void WriteMenu()
        {
            for (int i = 0; i < TargettMenuItem.MenuItemChildren.Count; i++)
                Console.WriteLine($"{i + 1} - {TargettMenuItem.MenuItemChildren[i].MenuText}");

            Console.WriteLine("0 - " + (TargettMenuItem.MenuItemParent == null ? "Выход" : TargettMenuItem.MenuText));
            Console.Write(">> ");
        }

        private MenuItem GetTargetMenuItemByIndex(int targetMenuItemIndex)
        {
            if (targetMenuItemIndex > TargettMenuItem.MenuItemChildren.Count) return TargettMenuItem;

            if (targetMenuItemIndex != 0) return TargettMenuItem.MenuItemChildren[targetMenuItemIndex - 1];
            else return TargettMenuItem.MenuItemParent;
        }

        private int GetSelectedMenuNumber()
        {
            StringBuilder consoleNum = new StringBuilder(Console.ReadLine() ?? "");
            while (String.IsNullOrEmpty(consoleNum.ToString()) || !int.TryParse(consoleNum.ToString(), out _))
            {
                Console.Write(">> ");
                consoleNum = new StringBuilder(Console.ReadLine() ?? "");
            }

            return int.Parse(consoleNum.ToString());
        }
    }
}
