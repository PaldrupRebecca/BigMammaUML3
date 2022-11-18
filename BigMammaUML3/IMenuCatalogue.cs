using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public interface IMenuCatalogue
    {
        int Count { get; }
        void Add(IMenuItem aMenuItem);
        IMenuItem Search(int number);
        void Delete(int number);
        void PrintPizzasMenu();
        void PrintBeveragesMenu();
        void PrintPastasMenu();
        void PrintToppingsMenu();
        void PrintAll();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(MenuType type);
        void PrintVeganItems(List<IMenuItem> veganItems);
        List<IMenuItem> FindAllOrganic(MenuType type);
        void PrintOrganicItems(List<IMenuItem> organicItems);
        IMenuItem MostExpensiveMenuItem();
    }
}
