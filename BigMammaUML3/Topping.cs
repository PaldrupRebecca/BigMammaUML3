using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Topping : MenuItem
    {
		private string _category;

		public string Category
		{
			get { return _category; }
			set { _category = value; }
		}

		public Topping(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, string category) :base(number, name, description, price, type, isVegan, isOrganic)
		{
			_category = category;
		}

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\nCategory: {_category}";
        }
    }
}
