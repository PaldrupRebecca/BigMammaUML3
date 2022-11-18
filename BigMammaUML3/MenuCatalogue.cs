using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMammaUML3
{
    public class MenuCatalogue : IMenuCatalogue
    {
        List<IMenuItem> _menuItems;

        public MenuCatalogue()
        {
            _menuItems = new List<IMenuItem>();
        }
        public int Count
        {
            get { return _menuItems.Count; }
        }


        public void Add(IMenuItem aMenuItem)
        {
            try
            {
                IMenuItem foundItem = Search(aMenuItem.Number);
                if (foundItem == null)
                    _menuItems.Add(aMenuItem);
                else
                    throw new MenuItemNumberExist("The item you are trying to add already exists");
            }
            catch (MenuItemNumberExist mineEx)
            {
                Console.WriteLine("Something went wrong: " + mineEx.Message);
            }

        }

        public void Delete(int number)
        {
            IMenuItem item = Search(number);
            _menuItems.Remove(item);
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organic = new List<IMenuItem>();
            foreach (MenuItem aMenuitem in _menuItems)
            {
                if (aMenuitem.IsOrganic == true && aMenuitem.Type == type)
                {
                    organic.Add(aMenuitem);
                }
            }
            return organic;
        }

        public void PrintOrganicItems(List<IMenuItem> organicItems)
        {
            foreach (IMenuItem item in organicItems)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> vegan = new List<IMenuItem>();
            foreach (MenuItem aMenuitem in _menuItems)
            {
                if (aMenuitem.IsVegan == true && aMenuitem.Type == type)
                { 
                    vegan.Add(aMenuitem);
                }
            }
            return vegan;
        }

        public void PrintVeganItems(List<IMenuItem> veganItems)
        {
            foreach (IMenuItem item in veganItems)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public IMenuItem MostExpensiveMenuItem()
        {

            if (_menuItems.Count > 0)
            {
                IMenuItem mostExpensive = _menuItems[0];

                foreach (IMenuItem item in _menuItems)
                {
                    if (item.Price > mostExpensive.Price)
                    {
                        mostExpensive = item;
                    }
                }
                return mostExpensive;
            }
            return null;
        }

        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.Type == MenuType.Beverage)
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.Type == MenuType.Pizza)
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintPastasMenu()
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.Type == MenuType.Pasta)
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (item.Type == MenuType.Topping)
                    Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintAll()
        {
            foreach (IMenuItem item in _menuItems)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _menuItems)
            {
                if (number == item.Number)
                    return item;
            }
            return null;
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            int i = 0;
            while (i < _menuItems.Count)
            {
                if (_menuItems[i].Number == number)
                {
                    _menuItems[i] = theMenuItem;
                    break;
                }
                i++;
            }
        }
    }
}
