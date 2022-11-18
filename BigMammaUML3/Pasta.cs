using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pasta : MenuItem
    {
		private bool _isGlutenFree;

		public bool IsGlutenFree
		{
			get { return _isGlutenFree; }
			set { _isGlutenFree = value; }
		}

		public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool isGlutenFree) :base(number, name, description, price, type, isVegan, isOrganic)
		{
			_isGlutenFree =isGlutenFree;
		}

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\nIs it gluten free? {IsGlutenFree}";
        }
    }
}
