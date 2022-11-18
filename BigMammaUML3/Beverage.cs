using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Beverage : MenuItem
    {
		private bool _isAlcoholic;
		private bool _containsAddedSugar;

		public bool IsAlcoholic
		{
			get { return _isAlcoholic; }
			set { _isAlcoholic = value; }
		}
		public bool ContainsAddedSugar
		{
			get { return _containsAddedSugar; }
			set { _containsAddedSugar = value; }
		}

		public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool isAlcoholic, bool containsAddedSugar) :base(number, name, description, price, type, isVegan, isOrganic)
		{
			_isAlcoholic=isAlcoholic;
			_containsAddedSugar=containsAddedSugar;
		}

		public override string PrintInfo()
		{
			return base.PrintInfo() + $"\nIs it alcoholic? {_isAlcoholic}\nDoes it contain sugar? {_containsAddedSugar}";
		}
	}
}
